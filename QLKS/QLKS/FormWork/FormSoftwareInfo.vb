Public Class FormSoftwareInfo
    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        System.Diagnostics.Process.Start(e.Link.LinkData.ToString())
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        System.Diagnostics.Process.Start(e.Link.LinkData.ToString())
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        System.Diagnostics.Process.Start(e.Link.LinkData.ToString())
    End Sub

    Private Sub FormSoftwareInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LinkLabel2.Links.Add(0, LinkLabel2.Text.Length, "https://www.iconfinder.com")
        LinkLabel3.Links.Add(0, LinkLabel3.Text.Length, "http://jsfiddle.net/vh3bcg8m/8/embedded/result/")

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class