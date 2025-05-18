
Public Class Pegawai

    Public mnip, mnama, malamat, mstatus, mjabatan, mgapok As String

    Public Property nip() As String
        Get
            Return mnip
        End Get
        Set(ByVal value As String)
            mnip = value
        End Set
    End Property


    Public Property nama() As String
        Get
            Return mnama
        End Get
        Set(ByVal value As String)
            mnama = value
        End Set
    End Property

    Public Property alamat() As String
        Get
            Return malamat
        End Get
        Set(ByVal value As String)
            malamat = value
        End Set
    End Property

    Public Property jabatan() As String
        Get
            Return mjabatan
        End Get
        Set(ByVal value As String)
            mjabatan = value
        End Set
    End Property

    Public Property status() As String
        Get
            Return mstatus
        End Get
        Set(ByVal value As String)
            mstatus = value
        End Set
    End Property

    Public Property gapok() As String
        Get
            Return mgapok
        End Get
        Set(ByVal value As String)
            mgapok = value
        End Set
    End Property
End Class
