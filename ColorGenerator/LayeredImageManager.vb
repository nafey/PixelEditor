Public Class LayeredImageGroup

    Public Property Width As Integer
    Public Property Height As Integer

    Public Property CollatedBitmap As Bitmap
    Private Property bmplst As New List(Of Bitmap)

    Public Sub New(ByVal w As Integer, ByVal h As Integer)
        Me.Width = w
        Me.Height = h
        CollatedBitmap = New Bitmap(w, h)
    End Sub

    Public Sub Add(ByVal bmp As Bitmap)
        If bmp.Height = Me.Height And bmp.Width = Me.Width Then
            bmplst.Add(bmp)
            Collate()
        Else
            MsgBox("Size incorrect")
        End If
    End Sub

    Public Sub RemoveAt(ByVal i As Integer)
        bmplst.RemoveAt(i)
        Collate()
    End Sub

    Default Public Property Item(ByVal i As Integer) As Bitmap
        Get
            Return bmplst(i)
        End Get
        Set(ByVal value As Bitmap)
            bmplst(i) = value
        End Set
    End Property

    Public Sub Collate()
        Dim b As New Bitmap(Width, Height)
        Dim g As Graphics = Graphics.FromImage(b)

        For i As Integer = 0 To bmplst.Count - 1
            g.DrawImage(bmplst(i), New Point(0, 0))
        Next

        CollatedBitmap = b
    End Sub

End Class
