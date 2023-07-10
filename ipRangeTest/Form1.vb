Imports System.Threading
Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'start ip range
        Timer1.Start()
    End Sub
    Sub cjhg()
        Dim bbb As String = Me.TextBox1.Text 'starting range
        Dim ghb() As String = Split(bbb, ".")
        Dim kl = CInt(ghb(0))
        Dim kl2 = CInt(ghb(1))
        Dim kl3 = CInt(ghb(2))
        Dim kl4 = CInt(ghb(3))
        Dim bbb2 As String = Me.TextBox2.Text 'ending range
        Dim ghb2() As String = Split(bbb2, ".")
        Dim kll = CInt(ghb2(0))
        Dim kll2 = CInt(ghb2(1))
        Dim kll3 = CInt(ghb2(2))
        Dim kll4 = CInt(ghb2(3))
        ' ListBox1.Items.Add("First: " & kl)
        ' ListBox1.Items.Add("Second: " & kl2)
        ' ListBox1.Items.Add("Third: " & kl3)
        ' ListBox1.Items.Add("Fourth: " & kl4)
        ' ListBox1.Items.Add(Environment.NewLine)
        ' ListBox1.Items.Add("First: " & kll)
        ' ListBox1.Items.Add("Second: " & kll2)
        ' ListBox1.Items.Add("Third: " & kll3)
        ' ListBox1.Items.Add("Fourth: " & kll4)
        ' ListBox1.Items.Add(Environment.NewLine)
        For x1 As Integer = kl To kll
            For x2 As Integer = kl2 To kll2
                For x3 As Integer = kl3 To kll3
                    For x4 As Integer = kl4 To kll4
                        If kl = kll AndAlso kl2 = kll2 AndAlso kl3 = kll3 AndAlso kl4 = kll4 Then
                            'Exit Sub
                        End If
                        bnd = Nothing
                        bnd = x1 & "." & x2 & "." & x3 & "." & x4 & Environment.NewLine
                        countt += 1
                        lp = countt
                        Me.Invoke(New MethodInvoker(AddressOf addlio))
                    Next
                Next
            Next
        Next
    End Sub
    Dim kf As New ListBox
    Dim lp As Integer
    Dim bnd As String
    Dim countt As Integer = 0
    Sub addlio()
        'If Not bb.Text = String.Empty AndAlso Not ListBox1.Items.Contains(bb) Then
        Me.TextBox4.AppendText(bnd)
        Me.Label2.Text = lp
        ' End If
    End Sub
    Private Sub method_2()
        Dim index As Integer = 0
        Do While (index < 1) ''change number to length of iprange
            ' Dim str As String = Me.rtbIPRanges.Lines(index).Trim
            Dim str2 As String = Me.TextBox1.Text
            Dim str3 As String = Me.TextBox2.Text
            Dim strArray() As String = Split(str2, ".")
            Dim strArray2() As String = Split(str3, ".")
           Do While True
                If (Integer.Parse(strArray(0)) > Integer.Parse(strArray2(0))) Then
                    index += 1
                    Exit Do
                End If
                Do While True
                    If (Integer.Parse(strArray(1)) > Integer.Parse(strArray2(1))) Then
                        strArray(0) = (Integer.Parse(strArray(0)) + 1).ToString
                        strArray(1) = "0"
                        strArray(2) = "0"
                        strArray(3) = "0"
                        Exit Do
                    End If
                    Do While True
                        'Dim info As SSH_Info
                        Dim strArray3 As String()
                        If (Integer.Parse(strArray(2)) > Integer.Parse(strArray2(2))) Then
                            strArray(1) = (Integer.Parse(strArray(1)) + 1).ToString
                            strArray(2) = "0"
                            strArray(3) = "0"
                            Exit Do
                        End If
                        If (((strArray(0) = strArray2(0)) AndAlso (strArray(1) = strArray2(1))) AndAlso (strArray(2) = strArray2(2))) Then
                            Do While (Integer.Parse(strArray(3)) <= Integer.Parse(strArray2(3)))
                                strArray3 = New String() {strArray(0), ".", strArray(1), ".", strArray(2), ".", strArray(3)}
                              If String.Concat(strArray3) >= str3 Then
                                    Exit Sub
                                End If
                                bnd = String.Concat(strArray3) & Environment.NewLine
                                countt += 1
                                lp = countt
                                Me.Invoke(New MethodInvoker(AddressOf addlio))
                                strArray(3) = (Integer.Parse(strArray(3)) + 1).ToString
                            Loop
                        Else
                            Dim i As Integer = 0
                            Do While (i <= &HFF)
                                strArray3 = New String() {strArray(0), ".", strArray(1), ".", strArray(2), ".", i.ToString}
                               If String.Concat(strArray3) >= str3 Then
                                    Exit Sub
                                End If
                                bnd = String.Concat(strArray3) & Environment.NewLine
                                countt += 1
                                lp = countt
                                Me.Invoke(New MethodInvoker(AddressOf addlio))
                                i += 1
                            Loop
                        End If
                        strArray(2) = (Integer.Parse(strArray(2)) + 1).ToString
                        strArray(3) = "0"
                    Loop
                Loop
            Loop
        Loop
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim bbb As String = Me.TextBox1.Text 'starting range
        Dim ghb() As String = Split(bbb, ".")
        Dim kl = CInt(ghb(0))
        Dim kl2 = CInt(ghb(1))
        Dim kl3 = CInt(ghb(2))
        Dim kl4 = CInt(ghb(3))
        Dim bbb2 As String = Me.TextBox2.Text 'ending range
        Dim ghb2() As String = Split(bbb2, ".")
        Dim kll = CInt(ghb2(0))
        Dim kll2 = CInt(ghb2(1))
        Dim kll3 = CInt(ghb2(2))
        Dim kll4 = CInt(ghb2(3))
        ' ListBox1.Items.Add("First: " & kl)
        ' ListBox1.Items.Add("Second: " & kl2)
        ' ListBox1.Items.Add("Third: " & kl3)
        ' ListBox1.Items.Add("Fourth: " & kl4)
        ' ListBox1.Items.Add(Environment.NewLine)
        ' ListBox1.Items.Add("First: " & kll)
        ' ListBox1.Items.Add("Second: " & kll2)
        ' ListBox1.Items.Add("Third: " & kll3)
        ' ListBox1.Items.Add("Fourth: " & kll4)
        ' ListBox1.Items.Add(Environment.NewLine)
        For x1 As Integer = kl To kll
            For x2 As Integer = kl2 To kll2
                For x3 As Integer = kl3 To kll3
                    For x4 As Integer = kl4 To kll4
                        If kl = kll AndAlso kl2 = kll2 AndAlso kl3 = kll3 AndAlso kl4 = kll4 Then
                            Timer1.Stop()
                            Exit Sub
                        End If
                        ListBox1.Items.Add(x1 & "." & x2 & "." & x3 & "." & x4)
                        ListBox1.Refresh()
                        Label2.Text = ListBox1.Items.Count
                        Label2.Refresh()
                    Next
                Next
            Next
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'stop ip range
        Timer1.Stop()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim startip As String = Nothing
        Dim stopip As String = Nothing
        Dim bnh As String = Me.TextBox3.Text
        Dim sptyo() As String = Split(bnh, "-")
        startip = (sptyo(0))
        stopip = (sptyo(1))
        Me.TextBox1.Text = startip
        Me.TextBox2.Text = stopip
    End Sub

    Dim klb As Thread
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        klb = New Thread(New ThreadStart(AddressOf method_2)) 'cjhg
        klb.IsBackground = True
        klb.Start()
    End Sub

   Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If klb.IsAlive Then
            klb.Suspend()
        End If
    End Sub
End Class
