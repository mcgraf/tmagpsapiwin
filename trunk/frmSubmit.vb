Imports tmagpsapiwin.frmMain

Public Class frmSubmitOnline

    Private Sub OpenURL(ByVal URL As String)
        System.Diagnostics.Process.Start(URL)
    End Sub

    Private Sub frmSubmitOnline_Load(ByVal sender As System.Object, _
                                     ByVal e As System.EventArgs) _
            Handles MyBase.Load
        txtLat.Text = frmMain.tLatDec.Text
        txtLong.Text = frmMain.tLonDec.Text

    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, _
                                ByVal e As System.EventArgs) _
            Handles cmdCancel.Click

        Me.Close()

    End Sub

    Private Sub cmdSubmit_Click(ByVal sender As System.Object, _
                                ByVal e As System.EventArgs) _
            Handles cmdSubmit.Click
        OpenURL("http://www.olivetreeroute.gr/live/add2.php?title=" & txtTitle.Text & "&description=" & txtDescription.Text & "&lat=" & txtLat.Text & "&lon=" & txtLong.Text)

    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, _
                              ByVal e As System.EventArgs) _
            Handles cmdSave.Click

        Dim mai As New tmagpsapiwin.frmMain

        mai.WriteXML(txtTitle.Text, txtDescription.Text, txtLat.Text, txtLong.Text)

    End Sub

End Class
