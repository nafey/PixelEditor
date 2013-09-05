Module DisplayManager


    Public lydImage As LayeredImageGroup

    Public Property bmpDisplay As Bitmap

    Public Property bmpSeparator As Bitmap
    Public Property bmpText As Bitmap
    Public Property bmpSelection As Bitmap

    Public Property Height As Integer
    Public Property Width As Integer

    Public Property ZoomScale As Integer

    Public Sub Initialize(ByVal Main As Bitmap, ByVal ZoomScale As Integer, ByVal Width As Integer, ByVal Height As Integer)
        lydImage = New LayeredImageGroup(Width, Height)
        lydImage.Add(PicData.bmpMain)
    End Sub


End Module
