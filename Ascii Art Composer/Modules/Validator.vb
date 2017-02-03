Imports System.ComponentModel.DataAnnotations

Module ControlValidator
    Dim _ep As New ErrorProvider() With {.RightToLeft = True}

    'Private _validationResults As New List(Of ValidationResult)
    Public Property ValidationResults As List(Of ValidationResult)
    '    Get
    '        Return _validationResults
    '    End Get
    '    Set(value As List(Of ValidationResult))
    '        _validationResults = value
    '        value.Reverse()
    '        ValidationSource.DataSource = value
    '        ValidationSource.ResetBindings()
    '    End Set
    'End Property
    Public ValidationSource As New BindingSource With {.DataSource = ValidationResults}
    Private ControlList As New List(Of Control)

    'Controls should only be passed to this once
    Sub AddControlsToValidator(ByRef obj As Control)
        GetAllContols(obj, New List(Of Control))
        If ControlList.Count > 0 Then
            For Each control As Control In ControlList : AddHandler control.Validating, AddressOf ControlPropertyValid : Next
        End If
        ValidateControlList()
    End Sub

    'Gets all sub controls using recursion 
    Function GetAllContols(control As Control, ByRef list As List(Of Control)) As IEnumerable(Of Control)
        Dim Controls = control.Controls.Cast(Of Control)()

        For Each con As Control In control.Controls

            If con.Controls.Count > 0 Then
                If con.DataBindings.Count > 0 Then ControlList.Add(con)
                GetAllContols(con, list)
            ElseIf con.DataBindings.Count > 0 Then
                ControlList.Add(con)
            End If

        Next

        Return ControlList
    End Function

    'Validates bound properties that fire property changed event
    Function ControlPropertyValid(obj As Control, e As EventArgs, Optional customEP As ErrorProvider = Nothing, Optional control As Control = Nothing) As Boolean
        Dim message As String = Nothing
        Dim hasBrokenRule = False
        Dim propertyResults As New List(Of ValidationResult)

        For Each binding As Binding In obj.DataBindings
            ValidationResults.RemoveAll(Function(x) x.MemberNames.Any(Function(y) y = binding.BindingMemberInfo.BindingField))
            Dim context As ValidationContext = New ValidationContext(binding.BindingManagerBase.Current) With {.MemberName = binding.BindingMemberInfo.BindingField}
            hasBrokenRule = Validator.TryValidateProperty(binding.Control.Text, context, propertyResults)

            If propertyResults.Count > 0 Then
                hasBrokenRule = True
                For i As Integer = 0 To propertyResults.Count - 1
                    message += vbNewLine & propertyResults(i).ErrorMessage
                Next
            End If
        Next

        ValidationResults = ValidationResults.Concat(propertyResults).ToList
        ValidationSource.DataSource = ValidationResults
        'ValidationSource.ResetBindings(True) ' = ValidationResults
        If customEP IsNot Nothing AndAlso hasBrokenRule Then : customEP.SetError(obj, message) : Return Not hasBrokenRule
        ElseIf hasBrokenRule Then : _ep.SetError(obj, message) : Return Not hasBrokenRule
        Else : _ep.SetError(obj, "") : Return Not hasBrokenRule
        End If
    End Function

    Function ValidateControlList() As List(Of ValidationResult)
        ValidationResults = New List(Of ValidationResult)
        For Each control In ControlList
            For Each binding As Binding In control.DataBindings
                Dim context As ValidationContext = New ValidationContext(binding.BindingManagerBase.Current) With {.MemberName = binding.BindingMemberInfo.BindingField}
                Validator.TryValidateProperty(binding.Control.Text, context, ValidationResults)
            Next
        Next
        ValidationResults = ValidationResults
        ValidationSource.DataSource = ValidationResults
        Return ValidationResults
    End Function

    Function ValidateAllObjectProperties(obj As Object) As Boolean
        Dim results As New List(Of ValidationResult)
        Return Validator.TryValidateObject(obj, New ValidationContext(obj), Nothing, True)
    End Function

    'Function ControlObjectValid(obj As Control, e As EventArgs, Optional ep As ErrorProvider = Nothing, Optional control As Control = Nothing) As Boolean
    '    'If obj Is Nothing Then Return False 'Not sure if I need to check for this because a control should never be sent empty
    '    Dim results As New List(Of ValidationResult)
    '    Dim message As String = Nothing

    '    For Each binding As Binding In obj.DataBindings
    '        Validator.TryValidateObject(binding.BindingManagerBase.Current, New ValidationContext(binding.BindingManagerBase.Current, Nothing, Nothing), results, True)
    '        'results = results.Where(Function(x) x.MemberNames.First(Function(y) y = binding.BindingMemberInfo.BindingField))

    '        If results.Count > 0 Then
    '            For i As Integer = 0 To results.Count - 1
    '                message += i & ". " & results(i).ErrorMessage
    '            Next
    '        End If
    '    Next

    '    If Not String.IsNullOrEmpty(message) AndAlso ep IsNot Nothing Then
    '        message.Insert(0, "Warning, cannot save. Validation errors found: " & vbNewLine)
    '        ep.SetError(obj, message)
    '        Return False
    '    Else
    '        ep.SetError(obj, "")
    '        Return True
    '    End If
    'End Function
End Module
