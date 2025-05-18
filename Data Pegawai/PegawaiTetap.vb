Public Class PegawaiTetap
    Inherits Pegawai
    Public mtunjangantetap As Integer

    Public Property tunjangantetap() As String
        Get
            Return mtunjangantetap
        End Get
        Set(ByVal value As String)
            mtunjangantetap = value
        End Set
    End Property
    Public Function hitungtunjanganrumah(ByVal mgapok As Integer)
        Return mgapok * 0.05
    End Function

    Public Function hitunggajitetap(ByVal mgapok As Integer, ByVal mtunjangantetap As Integer)
        Return mgapok + mtunjangantetap
    End Function
End Class
