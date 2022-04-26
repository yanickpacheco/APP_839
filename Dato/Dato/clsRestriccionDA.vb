Imports System.Data.SqlClient
Imports Entidad

Public Class clsRestriccionDA
    Dim con As New clsConexion 'SE CREA OBJETO DE CLSCONEXION PARA PODER CONECTARNOS A BASE DE DATOS
    Dim tipoConexion As Integer = 1 'VARIABLE QUE ALMACENARA LA BASE A LA CUAL CONSULTAR
    Dim dt As New DataTable

    '*************METODO OARA BUSCAR LAS RESTRICCIONES POR ID DE PLAN*************************
    Public Function BuscarRestriccionPorIdPlan(ByVal _idPlan As Int64) As List(Of eRestriccion)
        Dim listaRestricciones As New List(Of eRestriccion)
        Dim cmd As New SqlCommand
        tipoConexion = 1
        cmd.CommandType = CommandType.StoredProcedure

        cmd.CommandText = "[Config].[pa_BuscarRestrccionPorIdPlan]"
        cmd.Parameters.AddWithValue("@idPlan", _idPlan)

        dt = con.TraeDatos(cmd, tipoConexion)

        For x As Int16 = 0 To dt.Rows.Count - 1
            Dim row As New eRestriccion
            row.idPlanesPorEdad = IIf(IsDBNull(dt.Rows(x)("idPlanesPorEdad")), Nothing, dt.Rows(x)("idPlanesPorEdad"))
            row.idPlan = IIf(IsDBNull(dt.Rows(x)("idPlan")), Nothing, dt.Rows(x)("idPlan"))
            row.edadDesde = IIf(IsDBNull(dt.Rows(x)("edadDesde")), Nothing, dt.Rows(x)("edadDesde"))
            row.edadHasta = IIf(IsDBNull(dt.Rows(x)("edadHasta")), Nothing, dt.Rows(x)("edadHasta"))

            listaRestricciones.Add(row)
        Next

        Return listaRestricciones

    End Function

    Public Function BuscarRestriccionPlanPorCampaña(ByVal _crm As Int64) As List(Of eRestriccion)
        Dim listaRestricciones As New List(Of eRestriccion)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        cmd.CommandType = CommandType.StoredProcedure

        cmd.CommandText = "[Config].[pa_ListaRestriccionPlan]"
        cmd.Parameters.AddWithValue("@crm", _crm)

        dt = con.TraeDatos(cmd, 1)

        For x As Int16 = 0 To dt.Rows.Count - 1
            Dim row As New eRestriccion
            row.idPlanesPorEdad = IIf(IsDBNull(dt.Rows(x)("idPlanesPorEdad")), Nothing, dt.Rows(x)("idPlanesPorEdad"))
            row.idPlan = IIf(IsDBNull(dt.Rows(x)("idPlan")), Nothing, dt.Rows(x)("idPlan"))
            row.edadDesde = IIf(IsDBNull(dt.Rows(x)("edadDesde")), Nothing, dt.Rows(x)("edadDesde"))
            row.edadHasta = IIf(IsDBNull(dt.Rows(x)("edadHasta")), Nothing, dt.Rows(x)("edadHasta"))
            row.idTipoPersona = IIf(IsDBNull(dt.Rows(x)("idTipoPersona")), Nothing, dt.Rows(x)("idTipoPersona"))
            row.idPlanPadre = IIf(IsDBNull(dt.Rows(x)("idPlanPadre")), Nothing, dt.Rows(x)("idPlanPadre"))

            listaRestricciones.Add(row)
        Next

        Return listaRestricciones

    End Function
End Class
