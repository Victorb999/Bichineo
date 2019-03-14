Public Class Agenda

    Private agendaCodigo As Integer
    Public Property Codigo() As Integer
        Get
            Return agendaCodigo
        End Get
        Set(ByVal value As Integer)
            agendaCodigo = value
        End Set
    End Property

    Private agendaServico As Integer
    Public Property Servico() As Integer
        Get
            Return agendaServico
        End Get
        Set(ByVal value As Integer)
            agendaServico = value
        End Set
    End Property

    Private agendaAnimal As Integer
    Public Property Animal() As Integer
        Get
            Return agendaAnimal
        End Get
        Set(ByVal value As Integer)
            agendaAnimal = value
        End Set
    End Property

    Private agendaHorarioInicio As DateTime
    Public Property HorarioInicio() As DateTime
        Get
            Return agendaHorarioInicio
        End Get
        Set(ByVal value As DateTime)
            agendaHorarioInicio = value
        End Set
    End Property

	Private agendaHorarioFim As DateTime
    Public Property HorarioFim() As DateTime
        Get
            Return agendaHorarioFim
        End Get
        Set(ByVal value As DateTime)
            agendaHorarioFim = value
        End Set
    End Property
	
	Private agendaData As DateTime
    Public Property Data() As DateTime
        Get
            Return agendaData
        End Get
        Set(ByVal value As DateTime)
            agendaData = value
        End Set
    End Property

    Private agendaStatus As Byte
    Public Property Status() As Byte
        Get
            Return agendaStatus
        End Get
        Set(ByVal value As Byte)
            agendaStatus = value
        End Set
    End Property

    Private agendaObs As String
    Public Property Obs() As String
        Get
            Return agendaObs
        End Get
        Set(ByVal value As String)
            agendaObs = value
        End Set
    End Property

End Class
