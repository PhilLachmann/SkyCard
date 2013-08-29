Imports Microsoft.VisualBasic

Public Class AssetReportParms
    Friend _whereClause As String
    Friend _buildingLocID As Integer
    Friend _reportByTitle As String
    Friend _reportFormat As String

    Public Overridable Property WhereClause() As String
        Get
            Return _whereClause
        End Get
        Set(ByVal value As String)
            _whereClause = value
        End Set
    End Property

    Public Overridable Property BuildingLocID() As Integer
        Get
            Return _buildingLocID
        End Get
        Set(ByVal value As Integer)
            _buildingLocID = value
        End Set
    End Property

    Public Overridable Property ReportByTitle() As String
        Get
            Return _reportByTitle
        End Get
        Set(ByVal value As String)
            _reportByTitle = value
        End Set
    End Property

    Public Overridable Property ReportFormat() As String
        Get
            Return _reportFormat
        End Get
        Set(ByVal value As String)
            _reportFormat = value
        End Set
    End Property

End Class
