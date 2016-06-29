Public Class frmRelax
    Private Sub frmRelax_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebBrowser1.Navigate("https://www.youtube.com/embed/videoseries?list=PLLkXEmX29hgI8Tsl-ywyrkdBs80npUfRE")
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub
End Class