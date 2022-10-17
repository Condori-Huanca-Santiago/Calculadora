Public Class CalcMaiacondori
    Dim operacion As String
    Dim resultado As Nullable(Of Double) = Nothing
    Dim V2 As Nullable(Of Double) = Nothing
    Dim Pressopreador As Boolean


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


    Private Sub siete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles siete.Click
        Rest()
        Numeros1.Text &= "7"
    End Sub

    Private Sub ocho_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ocho.Click
        Rest()
        Numeros1.Text &= "8"
    End Sub

    Private Sub mas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mas.Click
        operacion = "+"
        Buscasiope()
    End Sub

    Private Sub menos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menos.Click

        operacion = "-"
        Buscasiope()
    End Sub

    Private Sub Multi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Multi.Click

        operacion = "×"
        Buscasiope()
    End Sub

    Private Sub Divi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Divi.Click

        operacion = "÷"
        Buscasiope()
    End Sub

    Private Sub nueve_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nueve.Click
        Rest()
        Numeros1.Text &= "9"
    End Sub

    Private Sub cuatro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cuatro.Click
        Rest()
        Numeros1.Text &= "4"
    End Sub

    Private Sub cinco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cinco.Click
        Rest()
        Numeros1.Text &= "5"
    End Sub

    Private Sub seis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles seis.Click
        Rest()
        Numeros1.Text &= "6"
    End Sub

    Private Sub uno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uno.Click
        Rest()
        Numeros1.Text &= "1"
    End Sub

    Private Sub dos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dos.Click
        Rest()
        Numeros1.Text &= "2"
    End Sub

    Private Sub tres_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tres.Click
        Rest()
        Numeros1.Text &= "3"
    End Sub

    Private Sub Cero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cero.Click
        Rest()
        Numeros1.Text &= "0"

    End Sub

    Private Sub Punto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Punto.Click
        If InStr(Numeros1.Text, ".", CompareMethod.Text) = 0 Then
            Numeros1.Text += "."
        End If

    End Sub
    Private Sub Igual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Igual.Click
        Buscasiope()
        operacion = ""
    End Sub
    Public Sub Buscasiope()
        Pressopreador = True
        V2 = Val(Numeros1.Text)
        If resultado IsNot Nothing Then
            Select Case operacion
                Case "+"
                    resultado = resultado + V2
                Case "-"
                    resultado -= V2
                Case "×"
                    resultado *= V2
                Case "÷"
                    resultado /= V2
            End Select
            Numeros1.Text = resultado
        Else
            resultado = V2

        End If
    End Sub
    Public Sub Rest()
        If Pressopreador = True Then
            Numeros1.Text = ""
            Pressopreador = False
        ElseIf Numeros1.Text = "0" Then
            Numeros1.Text = ""
        End If
    End Sub

    Private Sub Borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Borrar.Click
        Numeros1.Text = "0"
        V2 = Nothing
        resultado = Nothing
    End Sub
End Class
