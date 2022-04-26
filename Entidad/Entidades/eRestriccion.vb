Public Class eRestriccion

    Private _idPlanesPorEdad As Int32
    Private _idPlan As Int64
    Private _edadDesde As String
    Private _edadHasta As String
    Private _idTipoPersona As Int16
    Public Property idTipoPersona() As Int16
        Get
            Return _idTipoPersona
        End Get
        Set(ByVal value As Int16)
            _idTipoPersona = value
        End Set
    End Property
    Private _idPlanPadre As Int64
    Public Property idPlanPadre() As Int64
        Get
            Return _idPlanPadre
        End Get
        Set(ByVal value As Int64)
            _idPlanPadre = value
        End Set
    End Property

    Public Property idPlanesPorEdad() As Int32
        Get
            Return _idPlanesPorEdad
        End Get
        Set(ByVal value As Int32)
            _idPlanesPorEdad = value
        End Set
    End Property

    Public Property idPlan() As Int64
        Get
            Return _idPlan
        End Get
        Set(ByVal value As Int64)
            _idPlan = value
        End Set
    End Property

    Public Property edadDesde() As String
        Get
            Return _edadDesde
        End Get
        Set(ByVal value As String)
            _edadDesde = value
        End Set
    End Property

    Public Property edadHasta() As String
        Get
            Return _edadHasta
        End Get
        Set(ByVal value As String)
            _edadHasta = value
        End Set
    End Property
End Class
