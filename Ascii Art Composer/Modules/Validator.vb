Imports System.ComponentModel.DataAnnotations

Module ControlValidator
    Function ValidateAllObjectProperties(obj As Object) As Boolean
        Dim results As New List(Of ValidationResult)

        Return Validator.TryValidateObject(obj, New ValidationContext(obj), Nothing, True)
    End Function

    Function ControlPropertyValid(obj As Control, Optional ep As ErrorProvider = Nothing, Optional control As Control = Nothing) As Boolean
        'If obj Is Nothing Then Return False 'Not sure if I need to check for this because a control should never be sent empty
        Dim results As New List(Of ValidationResult)
        Dim message As String = Nothing


        For Each binding As Binding In obj.DataBindings
            Dim dic As New Dictionary(Of Object, Object)
            Dim context As ValidationContext = New ValidationContext(binding.BindingManagerBase.Current, dic) With {.MemberName = binding.BindingMemberInfo.BindingField}

            Validator.TryValidateProperty(binding.Control.Text, context, results)
            'results = results.Where(Function(x) x.MemberNames.First(Function(y) y = binding.BindingMemberInfo.BindingField))

            If results.Count > 0 Then
                For i As Integer = 0 To results.Count - 1
                    message += i & ". " & results(i).ErrorMessage
                Next
            End If
        Next

        If Not String.IsNullOrEmpty(message) AndAlso ep IsNot Nothing Then
            message.Insert(0, "Warning, cannot save. Validation errors found: " & vbNewLine)
            ep.SetError(obj, message)
            Return False
        Else
            ep.SetError(obj, "")
            Return True
        End If
    End Function

    Function ControlObjectValid(obj As Control, Optional ep As ErrorProvider = Nothing, Optional control As Control = Nothing) As Boolean
        'If obj Is Nothing Then Return False 'Not sure if I need to check for this because a control should never be sent empty
        Dim results As New List(Of ValidationResult)
        Dim message As String = Nothing

        For Each binding As Binding In obj.DataBindings
            Validator.TryValidateObject(binding.BindingManagerBase.Current, New ValidationContext(binding.BindingManagerBase.Current, Nothing, Nothing), results, True)
            'results = results.Where(Function(x) x.MemberNames.First(Function(y) y = binding.BindingMemberInfo.BindingField))

            If results.Count > 0 Then
                For i As Integer = 0 To results.Count - 1
                    message += i & ". " & results(i).ErrorMessage
                Next
            End If
        Next

        If Not String.IsNullOrEmpty(message) AndAlso ep IsNot Nothing Then
            message.Insert(0, "Warning, cannot save. Validation errors found: " & vbNewLine)
            ep.SetError(obj, message)
            Return False
        Else
            ep.SetError(obj, "")
            Return True
        End If
    End Function
End Module
