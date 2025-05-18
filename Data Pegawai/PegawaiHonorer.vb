Public Class PegawaiHonorer
    Inherits Pegawai
    Public mtunjangantransport As Integer


    Public Property tunjangantransport() As String
        Get
            Return mtunjangantransport
        End Get
        Set(ByVal value As String)
            mtunjangantransport = value
        End Set
    End Property


    Public Function hitungtunjanganrumah(ByVal mgapok As Integer)
        Return mgapok * 0.05
    End Function

    Public Function hitunggajihonorer(ByVal mgapok As Integer, ByVal mtunjangantetap As Integer)
        Return mgapok + mtunjangantetap
    End Function
End Class
