Public Class Cliente

    Private clienteCodigo As Integer
    Public Property Codigo() As Integer
        Get
            Return clienteCodigo
        End Get
        Set(ByVal value As Integer)
            clienteCodigo = value
        End Set
    End Property

    Private clienteNome As String
    Public Property Nome() As String
        Get
            Return clienteNome
        End Get
        Set(ByVal value As String)
            clienteNome = value
        End Set
    End Property

    Private clienteCPF As String
    Public Property CPF() As String
        Get
            Return clienteCPF
        End Get
        Set(ByVal value As String)
            clienteCPF = value
        End Set
    End Property

    Private clienteSexo As String
    Public Property Sexo() As String
        Get
            Return clienteSexo
        End Get
        Set(ByVal value As String)
            clienteSexo = value
        End Set
    End Property

    Private clienteDtNascimento As DateTime
    Public Property DtNascimento() As DateTime
        Get
            Return clienteDtNascimento
        End Get
        Set(ByVal value As DateTime)
            clienteDtNascimento = value
        End Set
    End Property

    Private clienteDtCadastro As DateTime
    Public Property DtCadastro() As DateTime
        Get
            Return clienteDtCadastro
        End Get
        Set(ByVal value As DateTime)
            clienteDtCadastro = value
        End Set
    End Property

    Private clienteTelefone As String
    Public Property Telefone() As String
        Get
            Return clienteTelefone
        End Get
        Set(ByVal value As String)
            clienteTelefone = value
        End Set
    End Property

    Private clienteTelefone2 As String
    Public Property Telefone2() As String
        Get
            Return clienteTelefone2
        End Get
        Set(ByVal value As String)
            clienteTelefone2 = value
        End Set
    End Property

    Private clienteTelefone3 As String
    Public Property Telefone3() As String
        Get
            Return clienteTelefone3
        End Get
        Set(ByVal value As String)
            clienteTelefone3 = value
        End Set
    End Property

    Private clienteEmail As String
    Public Property Email() As String
        Get
            Return clienteEmail
        End Get
        Set(ByVal value As String)
            clienteEmail = value
        End Set
    End Property

    Private clienteCEP As String
    Public Property CEP() As String
        Get
            Return clienteCEP
        End Get
        Set(ByVal value As String)
            clienteCEP = value
        End Set
    End Property

    Private clienteEndereco As String
    Public Property Endereco() As String
        Get
            Return clienteEndereco
        End Get
        Set(ByVal value As String)
            clienteEndereco = value
        End Set
    End Property

    Private clienteBairro As String
    Public Property Bairro() As String
        Get
            Return clienteBairro
        End Get
        Set(ByVal value As String)
            clienteBairro = value
        End Set
    End Property

    Private clienteCidade As String
    Public Property Cidade() As String
        Get
            Return clienteCidade
        End Get
        Set(ByVal value As String)
            clienteCidade = value
        End Set
    End Property

    Private clienteUF As String
    Public Property UF() As String
        Get
            Return clienteUF
        End Get
        Set(ByVal value As String)
            clienteUF = value
        End Set
    End Property

    Private listaAnimal As List(Of Animal)
    Public Property Animal() As List(Of Animal)
        Get
            Return listaAnimal
        End Get
        Set(ByVal value As List(Of Animal))
            listaAnimal = value
        End Set
    End Property

End Class
