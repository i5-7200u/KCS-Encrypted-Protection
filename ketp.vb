Public Class ketp
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = acikanahtar()
        TextBox2.Text = gizlianahtar(TextBox1.Text, Label1.Text)
    End Sub
    'for döngülerini kendinize göre ayarlayin ve fobulus keyi(isteğe bağli) de öyle ayarlayin. yoksa gizli anahtariniz hemen hackerin eline geçer.
    'Adjust the for loops according to you and adjust the fobulus key(is optional) as well. Otherwise, your secret key will fall into the hands of the hacker immediately.
    Public Function sifrele(ByVal acikkey As String, ByVal sifrelenecekbayt As Byte())
        If TextBox9.Text = Nothing Then
            Try
                Dim hıohaha As New System.Security.Cryptography.RijndaelManaged
                Dim hıohahaes As New System.Security.Cryptography.AesCryptoServiceProvider
                hıohaha.KeySize = 256
                hıohaha.BlockSize = 256
                hıohahaes.KeySize = 256
                hıohahaes.BlockSize = 128
                hıohaha.Mode = System.Security.Cryptography.CipherMode.ECB
                hıohahaes.Mode = System.Security.Cryptography.CipherMode.ECB
                hıohaha.Padding = Security.Cryptography.PaddingMode.PKCS7
                hıohahaes.Padding = Security.Cryptography.PaddingMode.PKCS7
                Dim wqho As New System.Security.Cryptography.SHA256CryptoServiceProvider
                Dim w As New System.Security.Cryptography.MD5CryptoServiceProvider
                Dim a2q = System.Text.Encoding.UTF8.GetBytes(acikkey)
                Dim aq18 = w.ComputeHash(a2q)
                hıohahaes.Key = aq18
                Dim sifrele1 As System.Security.Cryptography.ICryptoTransform = hıohahaes.CreateEncryptor
                Dim ahoh = sifrele1.TransformFinalBlock(sifrelenecekbayt, 0, sifrelenecekbayt.Length)
                Dim q12 As String = ""
                Dim q As String = ""
                Dim hhw As Integer = 0
                q = sha512(acikkey)
                For hhw = hhw To 0
                    q12 = sha512(q)
                    q = q12
                Next
                Dim ewwew = ripemd160(q12)
                Dim aq123 = System.Text.Encoding.UTF8.GetBytes(ewwew)
                Dim aq81 = wqho.ComputeHash(aq123)
                hıohaha.Key = aq81
                Dim sifrele2 As System.Security.Cryptography.ICryptoTransform = hıohaha.CreateEncryptor
                Dim ahoh2 = sifrele2.TransformFinalBlock(ahoh, 0, ahoh.Length)
                Return ahoh2
            Catch Ex As Exception
                MsgBox("Bir hata oluştu! Hata = " & Ex.Message, MsgBoxStyle.Critical, "KEP Algorithm")
            End Try
        Else
            Try
                Dim hıohaha As New System.Security.Cryptography.RijndaelManaged
                Dim hıohahaes As New System.Security.Cryptography.AesCryptoServiceProvider
                hıohaha.KeySize = 256
                hıohaha.BlockSize = 256
                hıohahaes.KeySize = 256
                hıohahaes.BlockSize = 128
                hıohaha.Mode = System.Security.Cryptography.CipherMode.ECB
                hıohahaes.Mode = System.Security.Cryptography.CipherMode.ECB
                hıohaha.Padding = Security.Cryptography.PaddingMode.PKCS7
                hıohahaes.Padding = Security.Cryptography.PaddingMode.PKCS7
                Dim wqho As New System.Security.Cryptography.SHA256CryptoServiceProvider
                Dim w As New System.Security.Cryptography.MD5CryptoServiceProvider
                Dim a2q = System.Text.Encoding.UTF8.GetBytes(acikkey)
                Dim aq18 = w.ComputeHash(a2q)
                hıohahaes.Key = aq18
                Dim sifrele1 As System.Security.Cryptography.ICryptoTransform = hıohahaes.CreateEncryptor
                Dim ahoh = sifrele1.TransformFinalBlock(sifrelenecekbayt, 0, sifrelenecekbayt.Length)
                Dim q12 As String = ""
                Dim q As String = ""
                Dim hhw As Integer = 0
                q = sha512(acikkey)
                For hhw = hhw To 0
                    q12 = sha512(q)
                    q = q12
                Next
                q12 = q12 & TextBox9.Text
                Dim ewwew = ripemd160(q12)
                Dim aq123 = System.Text.Encoding.UTF8.GetBytes(ewwew)
                Dim aq81 = wqho.ComputeHash(aq123)
                hıohaha.Key = aq81
                Dim sifrele2 As System.Security.Cryptography.ICryptoTransform = hıohaha.CreateEncryptor
                Dim ahoh2 = sifrele2.TransformFinalBlock(ahoh, 0, ahoh.Length)
                Return ahoh2
            Catch Ex As Exception
                MsgBox("Bir hata oluştu! Hata = " & Ex.Message, MsgBoxStyle.Critical, "KEP Algorithm")
            End Try
        End If
    End Function
    Public Function coz(ByVal acikkey As String, ByVal gizlikey As String, ByVal cozulecekbayt As Byte())
        Try
            Dim hıohaha As New System.Security.Cryptography.RijndaelManaged
            Dim hıohahaes As New System.Security.Cryptography.AesCryptoServiceProvider
            hıohaha.KeySize = 256
            hıohaha.BlockSize = 256
            hıohahaes.KeySize = 256
            hıohahaes.BlockSize = 128
            hıohaha.Mode = System.Security.Cryptography.CipherMode.ECB
            hıohahaes.Mode = System.Security.Cryptography.CipherMode.ECB
            hıohaha.Padding = Security.Cryptography.PaddingMode.PKCS7
            hıohahaes.Padding = Security.Cryptography.PaddingMode.PKCS7
            Dim wqho As New System.Security.Cryptography.SHA256CryptoServiceProvider
            Dim w As New System.Security.Cryptography.MD5CryptoServiceProvider
            Dim a3q = System.Text.Encoding.UTF8.GetBytes(gizlikey)
            Dim k13 = wqho.ComputeHash(a3q)
            hıohaha.Key = k13
            Dim sifrele2 As System.Security.Cryptography.ICryptoTransform = hıohaha.CreateDecryptor
            Dim aho2 = sifrele2.TransformFinalBlock(cozulecekbayt, 0, cozulecekbayt.Length)
            Dim a2q = System.Text.Encoding.UTF8.GetBytes(acikkey)
            Dim aq18 = w.ComputeHash(a2q)
            hıohahaes.Key = aq18
            Dim sifrele1 As System.Security.Cryptography.ICryptoTransform = hıohahaes.CreateDecryptor
            Dim ahoh = sifrele1.TransformFinalBlock(aho2, 0, aho2.Length)
            Return ahoh
        Catch Ex As Exception
            MsgBox("Bir hata oluştu! Hata = " & Ex.Message, MsgBoxStyle.Critical, "KEP Algorithm")
        End Try
    End Function
    Public Function acikanahtar()
        Dim hhw As Integer = 0
        Dim veri1 As Integer
        Dim veri2 As Char
        Dim veri3 As Integer
        Dim rastgele As Random = New Random()
        Dim whq As String = ""
        Dim q12 As String = ""

        For hhw = hhw To 200
            veri1 = rastgele.Next(65, 80)
            veri3 = rastgele.Next(1, 100)
            veri2 = Convert.ToChar(veri1)
            whq += veri2 & veri3
        Next
        Return whq.ToLower

    End Function
    Public Function gizlianahtar(ByVal anwe As String, ByVal q As String)
        If TextBox8.Text = Nothing Then
            Dim q12 As String = ""
            Dim hhw As Integer = 0
            q = sha512(anwe)
            For hhw = hhw To 0
                q12 = sha512(q)
                q = q12
            Next
            Return ripemd160(q12)
        Else
            Dim q12 As String = ""
            Dim hhw As Integer = 0
            q = sha512(anwe)
            For hhw = hhw To 0
                q12 = sha512(q)
                q = q12
            Next
            q12 = q12 & TextBox8.Text
            Return ripemd160(q12)
        End If

    End Function
    Public Function sha512(ByVal anan As String) As String
        Dim sha221 As New Security.Cryptography.SHA512CryptoServiceProvider
        Dim baytyz() As Byte = System.Text.Encoding.ASCII.GetBytes(anan)
        baytyz = sha221.ComputeHash(baytyz)
        Dim hohaha As String = Nothing
        For Each byt As Byte In baytyz
            hohaha &= byt.ToString("x2")
        Next
        Return hohaha
    End Function
    Public Function ripemd160(ByVal anan As String) As String
        Dim sha221 As New Security.Cryptography.RIPEMD160Managed
        Dim baytyz() As Byte = System.Text.Encoding.ASCII.GetBytes(anan)
        baytyz = sha221.ComputeHash(baytyz)
        Dim hohaha As String = Nothing
        For Each byt As Byte In baytyz
            hohaha &= byt.ToString("x2")
        Next
        Return hohaha
    End Function

    Private Sub ketp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim qwe = System.Text.Encoding.UTF8.GetBytes(TextBox4.Text)
            Dim wqe = sifrele(TextBox3.Text, qwe)
            TextBox4.Text = Convert.ToBase64String(wqe)
        Catch ex As Exception
            MsgBox("Bir hata oluştu! Hata = " & ex.Message, MsgBoxStyle.Critical, "KEP Algorithm")
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Panel1.Visible = False
        TextBox1.Text = Nothing
        TextBox2.Text = Nothing
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Dim wqe = Convert.FromBase64String(TextBox5.Text)
            Dim weq = coz(TextBox6.Text, TextBox7.Text, wqe)
            TextBox5.Text = System.Text.Encoding.UTF8.GetString(weq)
        Catch ex As Exception
            MsgBox("Bir hata oluştu! Hata = " & ex.Message, MsgBoxStyle.Critical, "KEP Algorithm")
        End Try
    End Sub

    Private Sub TextBox8_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox8.KeyPress
        Label5.Text = Convert.ToInt32(e.KeyChar)
        If Label5.Text = 32 Then
            e.Handled = True
        Else

        End If
    End Sub

    Private Sub TextBox9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox9.KeyPress
        Label7.Text = Convert.ToInt32(e.KeyChar)
        If Label7.Text = 32 Then
            e.Handled = True
        Else

        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Panel1.Visible = True
    End Sub
End Class
