Imports Dato
Imports Entidad

Public Class clsRestriccionBI

    Dim daRestriccion As New clsRestriccionDA
    Public Function BuscarRestriccionPorIdPlan(ByVal _idPlan As Int64) As List(Of eRestriccion)
        Return daRestriccion.BuscarRestriccionPorIdPlan(_idPlan)
    End Function

    Public Function BuscarRestriccionPlanPorCampaña(ByVal _crm As Int64) As List(Of eRestriccion)
        Return daRestriccion.BuscarRestriccionPlanPorCampaña(_crm)
    End Function

End Class
