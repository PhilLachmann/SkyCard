
Partial Class UntrappedError
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim strErrorIntro As String = "An unhandled error has occured in this application.  The error that has been trapped is:" & "<br>"
        Dim strErrorClosing As String = "<br>" & "If this error continues, please notify Enterprise Mobility."

        If Session("UntrappedError") IsNot Nothing Then
            Dim pgError As Exception = Session("UntrappedError")
            Session("UntrappedError") = Nothing
            Session("ItemID") = Nothing
            Session("ProductID") = Nothing

            Dim mstr As GMechMaster = CType(Me.Master, gmechMaster)
            mstr.ShowErrorMessage(strErrorIntro & pgError.Message & strErrorClosing)
        End If

    End Sub
End Class
