Imports System.Drawing.Text

Public Class Form1
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub PerCent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clear.Click
        TextBox1.Text = ("0")
        Label1.Text = ""
        Label2.Text = ""
        Label3.Text = ""
    End Sub

    Private Sub Dot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dot.Click
        TextBox1.AppendText(".")
    End Sub

    Private Sub N0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N0.Click
        TextBox1.AppendText("0")
    End Sub

    Private Sub N1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N1.Click
        TextBox1.AppendText("1")
        If TextBox1.Text = "01" Then
            TextBox1.Text = "1"
        End If
    End Sub

    Private Sub N2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N2.Click
        TextBox1.AppendText("2")
        If TextBox1.Text = "02" Then
            TextBox1.Text = "2"
        End If
    End Sub

    Private Sub N3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N3.Click
        TextBox1.AppendText("3")
        If TextBox1.Text = "03" Then
            TextBox1.Text = "3"
        End If
    End Sub

    Private Sub N4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N4.Click
        TextBox1.AppendText("4")
        If TextBox1.Text = "04" Then
            TextBox1.Text = "4"
        End If
    End Sub

    Private Sub N5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N5.Click
        TextBox1.AppendText("5")
        If TextBox1.Text = "05" Then
            TextBox1.Text = "5"
        End If
    End Sub

    Private Sub N6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N6.Click
        TextBox1.AppendText("6")
        If TextBox1.Text = "06" Then
            TextBox1.Text = "6"
        End If
    End Sub

    Private Sub N7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N7.Click
        TextBox1.AppendText("7")
        If TextBox1.Text = "07" Then
            TextBox1.Text = "7"
        End If
    End Sub

    Private Sub N8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N8.Click
        TextBox1.AppendText("8")
        If TextBox1.Text = "08" Then
            TextBox1.Text = "8"
        End If
    End Sub

    Private Sub N9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N9.Click
        TextBox1.AppendText("9")
        If TextBox1.Text = "09" Then
            TextBox1.Text = "9"
        End If
    End Sub

    Private Sub Cls_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cls.MouseHover
        Cls.BackgroundImage = My.Resources.closehover
    End Sub

    Private Sub Cls_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cls.MouseLeave
        Cls.BackgroundImage = My.Resources.close
    End Sub

    Private Sub Cls_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cls.Click
        End
    End Sub

    Private Sub Min_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Min.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Min_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Min.MouseHover
        Min.BackgroundImage = My.Resources.minimizehover
    End Sub

    Private Sub Min_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Min.MouseLeave
        Min.BackgroundImage = My.Resources.minimize
    End Sub

    Private Sub Plus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Plus.Click
        Label1.Text = TextBox1.Text
        Label2.Text = "+"
        TextBox1.Clear()
    End Sub

    Private Sub I_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles I.Click
        Label1.Text = TextBox1.Text
        Label2.Text = "-"
        TextBox1.Clear()
    End Sub

    Private Sub X_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles X.Click
        Label1.Text = TextBox1.Text
        Label2.Text = "*"
        TextBox1.Clear()
    End Sub

    Private Sub Equals_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Equals.Click
        Label3.Text = TextBox1.Text
        Dim sign As Char
        sign = Label2.Text
        Dim n1 As Double
        n1 = Convert.ToDouble(Label1.Text)
        Dim n2 As Double
        n2 = Convert.ToDouble(Label3.Text)
        Dim n3 As Double

        Select Case (sign)
            Case "+"
                n3 = n1 + n2
            Case "-"
                n3 = n1 - n2
            Case "*"
                n3 = n1 * n2
        End Select
        TextBox1.Text = Convert.ToString(n3)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If TextBox1.Text = "" Then
            TextBox1.Text = "0"
        End If
    End Sub

    Private Sub Panel1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Panel1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Panel1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseUp
        drag = False
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim font As PrivateFontCollection = New PrivateFontCollection
        font.AddFontFile("data/Karla.ttf")
        TextBox1.Font = New Font(font.Families(0), 48)
        N1.Font = New Font(font.Families(0), 30)
        N2.Font = New Font(font.Families(0), 30)
        N3.Font = New Font(font.Families(0), 30)
        N4.Font = New Font(font.Families(0), 30)
        N5.Font = New Font(font.Families(0), 30)
        N6.Font = New Font(font.Families(0), 30)
        N7.Font = New Font(font.Families(0), 30)
        N8.Font = New Font(font.Families(0), 30)
        N9.Font = New Font(font.Families(0), 30)
        N0.Font = New Font(font.Families(0), 30)
        Dot.Font = New Font(font.Families(0), 30)
        Clear.Font = New Font(font.Families(0), 30)
        X.Font = New Font(font.Families(0), 30)
        I.Font = New Font(font.Families(0), 30)
        Plus.Font = New Font(font.Families(0), 30)
        Equals.Font = New Font(font.Families(0), 30)
    End Sub
End Class
