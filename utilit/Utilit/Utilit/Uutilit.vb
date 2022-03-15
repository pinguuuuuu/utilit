Public Class Uutilit

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim p As New Process

        p.StartInfo.FileName = "cmd.exe"
        p.StartInfo.Arguments = "/c charmap"
        p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        p.Start()

    End Sub

    Private Sub Uutilit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Dim c As New Process

        c.StartInfo.FileName = "cmd.exe"
        c.StartInfo.Arguments = "/c calc"
        c.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        c.Start()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim d As New Process

        d.StartInfo.FileName = "cmd.exe"
        d.StartInfo.Arguments = "/c MAGNIFY"
        d.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        d.Start()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim f As New Process

        f.StartInfo.FileName = "cmd.exe"
        f.StartInfo.Arguments = "/c OSK"
        f.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        f.Start()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click


        Dim y As New Process

        y.StartInfo.FileName = "cmd.exe"
        y.StartInfo.Arguments = "/c COMPMGMT.MSC"
        y.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        y.Start()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim i As New Process

        i.StartInfo.FileName = "cmd.exe"
        i.StartInfo.Arguments = "/c control"
        i.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        i.Start()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim i As New Process

        i.StartInfo.FileName = "cmd.exe"
        i.StartInfo.Arguments = "/c DEVMGMT.MSC "
        i.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        i.Start()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Dim i As New Process

        i.StartInfo.FileName = "cmd.exe"
        i.StartInfo.Arguments = "/c MMSYS.CPL  "
        i.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        i.Start()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Dim i As New Process

        i.StartInfo.FileName = "cmd.exe"
        i.StartInfo.Arguments = "/c  MSINFO32 "
        i.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        i.Start()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Dim i As New Process

        i.StartInfo.FileName = "cmd.exe"
        i.StartInfo.Arguments = "/c  TASKMGR"
        i.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        i.Start()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Dim i As New Process

        i.StartInfo.FileName = "cmd.exe"
        i.StartInfo.Arguments = "/c  WINVER"
        i.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        i.Start()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Dim i As New Process

        i.StartInfo.FileName = "cmd.exe"
        i.StartInfo.Arguments = "/c  DESK.CPL"
        i.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        i.Start()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Dim i As New Process

        i.StartInfo.FileName = "cmd.exe"
        i.StartInfo.Arguments = "/c  CONTROL ADMINTOOLS"
        i.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        i.Start()
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        Dim i As New Process

        i.StartInfo.FileName = "cmd.exe"
        i.StartInfo.Arguments = "/c  CONTROL INTERNATIONAL"
        i.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        i.Start()
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Dim i As New Process

        i.StartInfo.FileName = "cmd.exe"
        i.StartInfo.Arguments = "/c  CONTROL FOLDERS"
        i.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        i.Start()
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        Dim i As New Process

        i.StartInfo.FileName = "cmd.exe"
        i.StartInfo.Arguments = "/c  CONTROL MOUSE & CONTROL KEYBOARD"
        i.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        i.Start()
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        Dim i As New Process

        i.StartInfo.FileName = "cmd.exe"
        i.StartInfo.Arguments = "/c  CONTROL PRINTERS"
        i.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        i.Start()
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        Dim i As New Process

        i.StartInfo.FileName = "cmd.exe"
        i.StartInfo.Arguments = "/c  CONTROl USERPASSWORDS"
        i.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        i.Start()
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        Dim i As New Process

        i.StartInfo.FileName = "cmd.exe"
        i.StartInfo.Arguments = "/c EVENTVWR"
        i.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        i.Start()
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        Dim i As New Process

        i.StartInfo.FileName = "cmd.exe"
        i.StartInfo.Arguments = "/c  JOY.CPL"
        i.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        i.Start()
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        Dim i As New Process

        i.StartInfo.FileName = "cmd.exe"
        i.StartInfo.Arguments = "/c  PERFMON"
        i.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        i.Start()
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        Dim i As New Process

        i.StartInfo.FileName = "cmd.exe"
        i.StartInfo.Arguments = "/c  SERVICES.MSC"
        i.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        i.Start()
    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        Dim i As New Process

        i.StartInfo.FileName = "cmd.exe"
        i.StartInfo.Arguments = "/c FSQUIRT"
        i.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        i.Start()
    End Sub

    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim i As New Process

        i.StartInfo.FileName = "cmd.exe"
        i.StartInfo.Arguments = "/c  MSCTSC"
        i.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        i.Start()
    End Sub
End Class
