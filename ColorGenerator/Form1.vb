Imports System.Math

Public Class Form1

    Private Property lydImage As LayeredImageGroup

    ' The main image is stored here
    Private Property bmpMain As Bitmap

    ' The bitmap storing info. Black means selected.
    Private Property bmpDisplayInfo As Bitmap

    ' Zoom Scale kept constant for ease
    Private Property ZoomScale As Integer = 14

    ' Returns the color match value for two colors
    Private Function ColorMatchValue(ByVal color1 As Color, ByVal color2 As Color) As Integer
        Dim hr, hb, hg, sr, sb, sg As Integer
        hr = color1.R
        hb = color1.B
        hg = color1.G

        sr = color2.R
        sb = color2.B
        sg = color2.G

        Dim val As Integer
        val = Pow(Pow((hr - sr), 2) + Pow((hb - sb), 2) + Pow((hg - sg), 2), 0.5)
        Return val
    End Function

    ' Enlarges an image bit for bit and gives result
    Private Function ScaleBitmap(ByVal Original As Bitmap, ByVal scale As Integer) As Bitmap
        Dim p As Bitmap
        Dim g As Graphics

        Dim c As Brush

        p = New Bitmap(Original.Width * scale, Original.Height * scale)
        g = Graphics.FromImage(p)

        For i As Integer = 0 To Original.Width - 1
            For j As Integer = 0 To Original.Height - 1
                c = New System.Drawing.SolidBrush(bmpMain.GetPixel(i, j))
                g.FillRectangle(c, New Rectangle(i * scale, j * scale, scale, scale))
            Next
        Next

        Return p
    End Function

    ' Saves the color to datagrid view
    Private Sub SaveColorToDGV(ByVal lbl As String, ByVal col As Color)

        Me.dgvColor.Rows.Add()
        Me.dgvColor.Rows.Item(Me.dgvColor.Rows.Count - 1).Cells.Item(0).Value = lbl

        Dim p As New Bitmap(10, 10)
        Dim g As Graphics = Graphics.FromImage(p)
        g.Clear(col)

        Me.dgvColor.Rows.Item(Me.dgvColor.Rows.Count - 1).Cells.Item(1).Value = p

        Me.dgvColor.Rows.Item(Me.dgvColor.Rows.Count - 1).Cells.Item(2).Value = col.R
        Me.dgvColor.Rows.Item(Me.dgvColor.Rows.Count - 1).Cells.Item(3).Value = col.G
        Me.dgvColor.Rows.Item(Me.dgvColor.Rows.Count - 1).Cells.Item(4).Value = col.B

    End Sub

    ' Image Loader routine
    Private Sub LoadFile(ByVal bmp As Bitmap)
        bmpMain = bmp
        PicData.bmpMain = bmp
        Me.bmpDisplayInfo = New Bitmap(bmp.Width, bmp.Height)
        Me.picDisplay.Height = ZoomScale * bmp.Height
        Me.picDisplay.Width = ZoomScale * bmp.Width
        Me.picDisplay.BackgroundImage = ScaleBitmap(bmpMain, ZoomScale)
    End Sub

    ' Loads Images
    Private Sub LoadLabels(ByVal path As String)
        Me.dgvColor.Rows.Clear()

        Dim di As New IO.DirectoryInfo(path)
        Dim diar1 As IO.FileInfo() = di.GetFiles()
        Dim dra As IO.FileInfo

        For Each dra In diar1
            If dra.Extension = ".png" Then
                Dim b As New Bitmap(dra.FullName)
                If b.Width > 390 And b.Height > 390 Then
                    Dim c As Color = Color.FromArgb(b.GetPixel(389, 389).ToArgb)
                    Me.SaveColorToDGV(dra.Name.Substring(0, dra.Name.Length - 4), c)

                End If
            End If
        Next
    End Sub

    ' Subroutines
    Private Sub SelectColor(ByVal col As Color)
        Me.pnlSelCol.BackColor = col
        Me.nudR.Value = col.R
        Me.nudG.Value = col.G
        Me.nudB.Value = col.B

        If Me.dgvColor.RowCount > 0 Then
            Dim val As Integer = 999999
            Dim resLblIndex As Integer
            Dim resCol As Color

            For i As Integer = 0 To Me.dgvColor.RowCount - 1
                Dim testCol As Color = Color.FromArgb(Me.dgvColor.Rows.Item(i).Cells.Item(2).Value,
                                                       Me.dgvColor.Rows.Item(i).Cells.Item(3).Value,
                                                       Me.dgvColor.Rows.Item(i).Cells.Item(4).Value)
                If ColorMatchValue(col, testCol) < val Then
                    val = ColorMatchValue(col, testCol)
                    resLblIndex = i
                    resCol = testCol
                End If
            Next

            Me.Panel1.BackColor = resCol
            Me.Label7.Text = Me.dgvColor.Rows.Item(resLblIndex).Cells.Item(0).Value
            Me.txtNearest.Text = "(" & resCol.R & ", " & resCol.G & ", " & resCol.B & ")"

        End If



    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerate.Click
        If Not ((nudR.Value = 0) Or (nudG.Value.ToString = String.Empty) Or (nudB.Value.ToString = String.Empty)) Then
            Dim c As Color = Color.FromArgb(nudR.Text, nudG.Text, nudB.Text)
            pnlSelCol.BackColor = c
            SelectColor(c)
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If My.Computer.FileSystem.DirectoryExists(Me.txtDir.Text) Then
            My.Settings.SavePath = Me.txtDir.Text
            Dim i As New Bitmap(400, 400)
            Dim g As Graphics = Graphics.FromImage(i)
            Dim b As Brush = New System.Drawing.SolidBrush(pnlSelCol.BackColor)

            g.FillRectangle(b, New Rectangle(0, 0, 400, 400))
            g.DrawString(txtLabel.Text & "(" & nudR.Value & "," & nudG.Value & "," & nudB.Value & ")", New Font("Arial", 35), Brushes.White, New Point(0, 0))
            i.Save(Me.txtDir.Text & "\" & Me.txtLabel.Text & ".png", System.Drawing.Imaging.ImageFormat.Png)

            LoadLabels(My.Settings.SavePath)
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtDir.Text = My.Settings.SavePath
    End Sub

    Private Sub btnOpenImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenImage.Click
        If Me.OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Dim path As String = Me.OpenFileDialog1.FileName
            If path.Substring(path.Length - 4) = ".png" Or path.Substring(path.Length - 4) = ".ico" Or path.Substring(path.Length - 4) = ".jpg" Then
                Dim bmp As New Bitmap(OpenFileDialog1.FileName)
                LoadFile(bmp)
            End If
        End If
    End Sub

    Private Sub btnX_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadCol.Click
        LoadLabels(My.Settings.SavePath)
    End Sub

    Private Sub picDisplay_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picDisplay.MouseDown
        SelectColor(Me.bmpMain.GetPixel(Math.Floor(e.X / ZoomScale), Math.Floor(e.Y / ZoomScale)))

        'If Me.chkMarker.Checked = True Then
        '    If Me.bmpDisplayInfo.GetPixel(Math.Floor(e.X / ZoomScale), Math.Floor(e.Y / ZoomScale)).Name = "ff000000" Then
        '        Dim b As New Bitmap(picDisplay.Image.Width, picDisplay.Image.Height)
        '        Dim g As Graphics = Graphics.FromImage(b)
        '    Else
        '        Me.bmpDisplayInfo.SetPixel(Math.Floor(e.X / ZoomScale), Math.Floor(e.Y / ZoomScale), Color.Black)
        '    End If
        'End If


    End Sub

    Private Sub picDisplay_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picDisplay.MouseMove
        Me.txtMousePos.Text = "(" & CInt(e.X / ZoomScale) & "," & CInt(e.Y / ZoomScale) & ")"
        If Me.chkMarker.Checked = True Then

        End If
    End Sub


    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.lydImage = New LayeredImageGroup(200, 200)
        Dim b As New Bitmap(200, 200)
        Dim g As Graphics = Graphics.FromImage(b)

        g.FillRectangle(Brushes.MintCream, 0, 0, 200, 200)

        Me.lydImage.Add(b)

        b = New Bitmap(200, 200)
        g = Graphics.FromImage(b)

        g.DrawLine(Pens.Black, 0, 0, 200, 200)
        g.DrawLine(Pens.Black, 0, 200, 200, 0)

        Me.lydImage.Add(b)

        b = New Bitmap(200, 200)
        g = Graphics.FromImage(b)

        g.DrawString("Nafey", New Font("Arial", 10), Brushes.BurlyWood, New Point(75, 75))

        Me.lydImage.Add(b)

        Me.picDisplay.Image = Me.lydImage.CollatedBitmap




    End Sub
End Class
