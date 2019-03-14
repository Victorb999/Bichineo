Imports System.Data.SqlClient
Imports PetShop.Entities

Public Class AgendaDAO
    Inherits ConexaoDAO

    Public Function RetornaTodos() As List(Of Agenda)
        Dim oComm As New SqlCommand

        Try
            Dim listaAgenda As List(Of Agenda)

            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "SELECT Codigo, Servico, Animal, HorarioInicio, HorarioFim, Data, Status, Obs FROM Agenda"
            oComm.Connection.Open()

            Dim oDR As SqlDataReader = oComm.ExecuteReader()

            listaAgenda = PreencherLista(oDR)

            oDR.Close()
            oComm.Connection.Close()

            Return listaAgenda

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível obter eventos da Agenda", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Function

    Private Function PreencherLista(ByVal reader As SqlDataReader) As List(Of Agenda)
        Try
			
            Dim listaAgenda As New List(Of Agenda)
			
            While (reader.Read)
				
                Dim c As New Agenda
                c.Codigo = reader.GetInt32(0)
                c.Servico = reader.GetInt32(1)
				c.Animal = reader.GetInt32(2)
                c.HorarioInicio = reader.GetDateTime(3)
                c.HorarioFim = reader.GetDateTime(4)
                c.Data = reader.GetDateTime(5)
                c.Status = reader.GetByte(6)
                c.Obs = reader.GetString(7)

                listaAgenda.Add(c)

            End While

            Return listaAgenda

        Catch ex As Exception
		
        End Try
    End Function

    Public Function agendaporCodigo(ByVal Codigo As Integer) As List(Of Agenda)
        Dim oComm As New SqlCommand

        Try
            Dim listaAgenda As List(Of Agenda)

            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "SELECT Codigo, Servico, Animal, Convert(varchar,HorarioInicio,108) as HorarioInicio, Convert(varchar,Horariofim,108) as HorarioFim, Data, Status, Obs FROM Agenda WHERE Codigo = @Codigo"
            oComm.Parameters.Add("@Codigo", SqlDbType.Int).Value = Codigo
            oComm.Connection.Open()

            Dim oDR As SqlDataReader = oComm.ExecuteReader()

            listaAgenda = PreencherLista(oDR)

            oDR.Close()
            oComm.Connection.Close()

            Return listaAgenda

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível obter agenda", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Function

    Public Function agendapordata(ByVal Data As Date) As List(Of Agenda)
        Dim oComm As New SqlCommand

        Try
            Dim listaAgenda As List(Of Agenda)

            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "SELECT Codigo, Servico, Animal, HorarioInicio, HorarioFim, Data, Status, Obs FROM Agenda WHERE Data = @Data"
            oComm.Parameters.Add("@Data", SqlDbType.Date).Value = Data
            oComm.Connection.Open()

            Dim oDR As SqlDataReader = oComm.ExecuteReader()

            listaAgenda = PreencherLista(oDR)

            oDR.Close()
            oComm.Connection.Close()

            Return listaAgenda

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível obter agenda", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Function

    Public Function agendaporAnimal(ByVal Codigoanimal As Integer) As List(Of Agenda)
        Dim oComm As New SqlCommand

        Try
            Dim listaAgenda As List(Of Agenda)

            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "SELECT Codigo, Servico, Animal, HorarioInicio, HorarioFim, Data, Status, Obs FROM Agenda WHERE animal = @Animal"
            oComm.Parameters.Add("@Animal", SqlDbType.Int).Value = Codigoanimal
            oComm.Connection.Open()

            Dim oDR As SqlDataReader = oComm.ExecuteReader()

            listaAgenda = PreencherLista(oDR)

            oDR.Close()
            oComm.Connection.Close()

            Return listaAgenda

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível obter agenda", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Function

    Public Function agendaporServico(ByVal Codigoservico As Integer) As List(Of Agenda)
        Dim oComm As New SqlCommand

        Try
            Dim listaAgenda As List(Of Agenda)

            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "SELECT Codigo, Servico, Animal, HorarioInicio, HorarioFim, Data, Status, Obs FROM Agenda WHERE Servico = @Servico"
            oComm.Parameters.Add("@Servico", SqlDbType.Int).Value = Codigoservico
            oComm.Connection.Open()

            Dim oDR As SqlDataReader = oComm.ExecuteReader()

            listaAgenda = PreencherLista(oDR)

            oDR.Close()
            oComm.Connection.Close()

            Return listaAgenda

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível obter agenda", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Function

    Public Sub excluiAgenda(ByVal listaAgenda As List(Of Agenda))
        Dim oComm As New SqlCommand
		
        Try
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "DELETE FROM Agenda WHERE Codigo = @Codigo"
            oComm.Parameters.Add("@Codigo", SqlDbType.Int)
            oComm.Connection.Open()
			
            For Each c As Agenda In listaAgenda
                oComm.Parameters("@Codigo").Value = c.Codigo
                oComm.ExecuteNonQuery()
            Next
			
            oComm.Connection.Close()
			
        Catch ex As Exception
            Throw New ApplicationException("Não foi possível deletar agenda", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Sub
	
    Public Sub excluiAgenda(ByVal Codigo As Integer)
        Dim oComm As New SqlCommand
		
        Try
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "DELETE FROM Agenda WHERE Codigo = @Codigo"
            oComm.Parameters.Add("@Codigo", SqlDbType.Int).Value = Codigo
			
            oComm.Connection.Open()
            oComm.ExecuteNonQuery()
            oComm.Connection.Close()
			
        Catch ex As Exception
            Throw New ApplicationException("Não foi possível deletar agenda", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Sub
	
    Public Sub insereAgenda(ByVal listaAgenda As List(Of Agenda))
        Dim oComm As New SqlCommand
		
        Try
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "INSERT INTO Agenda (Servico, Animal, HorarioInicio, HorarioFim, Data, Status, Obs) VALUES " &
            "(@Servico, @Animal, @HorarioInicio, @HorarioFim, @Data, @Status, @Obs)"

            oComm.Parameters.Add("@Servico", SqlDbType.Int)
            oComm.Parameters.Add("@Animal", SqlDbType.Int)
            oComm.Parameters.Add("@HorarioInicio", SqlDbType.DateTime)
            oComm.Parameters.Add("@HorarioFim", SqlDbType.DateTime)
            oComm.Parameters.Add("@Data", SqlDbType.DateTime)
            oComm.Parameters.Add("@Status", SqlDbType.Char)
            oComm.Parameters.Add("@Obs", SqlDbType.Text)

            oComm.Connection.Open()
			
            For Each c As Agenda In listaAgenda
                oComm.Parameters("@Servico").Value = c.Servico
                oComm.Parameters("@Animal").Value = c.Animal
                oComm.Parameters("@HorarioInicio").Value = c.HorarioInicio
                oComm.Parameters("@HorarioFim").Value = c.HorarioFim
                oComm.Parameters("@Data").Value = c.Data
                oComm.Parameters("@Status").Value = c.Status
                oComm.Parameters("@Obs").Value = c.Obs

                oComm.ExecuteNonQuery()
            Next
			
            oComm.Connection.Close()

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível inserir animais", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Sub

    Public Function insereAgenda(ByVal Agenda As Agenda) As Integer
        Dim oComm As New SqlCommand

        Try
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "INSERT INTO Agenda (Servico, Animal, HorarioInicio, HorarioFim, Data, Status, Obs) OUTPUT INSERTED.Codigo VALUES " &
            "(@Servico, @Animal, @HorarioInicio, @HorarioFim, @Data, @Status, @Obs)"

            oComm.Parameters.Add("@Servico", SqlDbType.Int)
            oComm.Parameters.Add("@Animal", SqlDbType.Int)
            oComm.Parameters.Add("@HorarioInicio", SqlDbType.DateTime)
            oComm.Parameters.Add("@HorarioFim", SqlDbType.DateTime)
            oComm.Parameters.Add("@Data", SqlDbType.DateTime)
            oComm.Parameters.Add("@Status", SqlDbType.Char)
            oComm.Parameters.Add("@Obs", SqlDbType.Text)

            oComm.Connection.Open()

            oComm.Parameters("@Servico").Value = Agenda.Servico
            oComm.Parameters("@Animal").Value = Agenda.Animal
            oComm.Parameters("@HorarioInicio").Value = Agenda.HorarioInicio
            oComm.Parameters("@HorarioFim").Value = Agenda.HorarioFim
            oComm.Parameters("@Data").Value = Agenda.Data
            oComm.Parameters("@Status").Value = Agenda.Status
            oComm.Parameters("@Obs").Value = Agenda.Obs

            'oComm.ExecuteNonQuery()
            insereAgenda = oComm.ExecuteScalar()

            oComm.Connection.Close()

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível inserir o agenda", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Function

    Public Sub updateAgenda(ByVal listaAgenda As List(Of Agenda))
        Dim oComm As New SqlCommand

        Try
            oComm.Connection = MyBase.obterConexao
            oComm.CommandText = "UPDATE Agenda SET Servico = @Servico, Animal = @Animal, HorarioInicio = @HorarioInicio, HorarioFim = @HorarioFim, Data = @Data, Status = @Status , Obs = @Obs" &
                " WHERE Codigo = @Codigo"

            oComm.Parameters.Add("@Codigo", SqlDbType.Int)
            oComm.Parameters.Add("@Servico", SqlDbType.Int)
            oComm.Parameters.Add("@Animal", SqlDbType.Int)
            oComm.Parameters.Add("@HorarioInicio", SqlDbType.DateTime)
            oComm.Parameters.Add("@HorarioFim", SqlDbType.DateTime)
            oComm.Parameters.Add("@Data", SqlDbType.DateTime)
            oComm.Parameters.Add("@Status", SqlDbType.Char)
            oComm.Parameters.Add("@Obs", SqlDbType.Text)

            oComm.Connection.Open()

            For Each c As Agenda In listaAgenda
                oComm.Parameters("@Codigo").Value = c.Servico
                oComm.Parameters("@Servico").Value = c.Servico
                oComm.Parameters("@Animal").Value = c.Animal
                oComm.Parameters("@HorarioInicio").Value = c.HorarioInicio
                oComm.Parameters("@HorarioFim").Value = c.HorarioFim
                oComm.Parameters("@Data").Value = c.Data
                oComm.Parameters("@Status").Value = c.Status
                oComm.Parameters("@Obs").Value = c.Obs

                oComm.ExecuteNonQuery()
            Next

            oComm.Connection.Close()

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível atualizar eventos de Agenda", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Sub

    Public Sub updateAgendaStatus(ByVal listaAgenda As List(Of Agenda))
        Dim oComm As New SqlCommand

        Try
            oComm.Connection = MyBase.obterConexao
            oComm.CommandText = "UPDATE Agenda SET Status = @Status " &
                " WHERE Codigo = @Codigo"

            oComm.Parameters.Add("@Codigo", SqlDbType.Int)
            oComm.Parameters.Add("@Status", SqlDbType.Char)


            oComm.Connection.Open()

            For Each c As Agenda In listaAgenda
                oComm.Parameters("@Codigo").Value = c.Codigo
                oComm.Parameters("@Status").Value = c.Status

                oComm.ExecuteNonQuery()
            Next

            oComm.Connection.Close()

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível atualizar eventos de Agenda", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Sub

End Class
