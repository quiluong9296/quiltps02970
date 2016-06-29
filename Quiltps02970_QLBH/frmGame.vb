Public Class frmGame
    Private Sub frmGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebBrowser1.Navigate("http://gameflash.vn/games/blast-billiards.swf")
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub
End Class
