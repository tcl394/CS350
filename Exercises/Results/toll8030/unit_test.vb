Module unit_test
    Function test_user() As Boolean
        Dim t As Boolean = True

        t = test_create()

        If t Then
            MsgBox("ok")
        Else
            MsgBox("not ok")
        End If
        Return t
    End Function

    Function test_create() As Boolean
        Dim t As Boolean = False
        Dim User As Object = User().ToString
        If User IsNot Nothing Then
            t = True
        End If
        Return t
    End Function

    Sub User()
        Dim first, last, email As String
        first = ""
        last = ""
        email = ""
        Dim name As Array
        name = {first, last}


    End Sub

    Sub UserList(user)
        Dim list As ArrayList
        list.Add(user)

    End Sub

    Function test_name() As Boolean
        Dim t As Boolean = False
        If User().name IsNot Nothing Then
            t = True
        End If
        Return t
    End Function
    Function test_email() As Boolean
        Dim t As Boolean = False
        If User().email IsNot Nothing Then
            t = True
        End If
        Return t
    End Function

    Sub Main()
        test_user()
    End Sub

End Module
