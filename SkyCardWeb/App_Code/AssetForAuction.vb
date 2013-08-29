Imports Microsoft.VisualBasic

Public Class AssetForAuction
    Friend _tagNumber As String
    Friend _description As String

    Public Overridable Property TagNumber() As String
        Get
            Return _tagNumber
        End Get
        Set(ByVal value As String)
            _tagNumber = value
        End Set
    End Property

    Public Overridable Property Description() As String
        Get
            Return _description
        End Get
        Set(ByVal value As String)
            _description = value
        End Set
    End Property

End Class
