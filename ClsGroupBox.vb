Public Class ClsGroupBox
    Private grupoBox As GroupBox
    Private e As PaintEventArgs
    Private grosor As Integer
    Private color As Color
    Private radio As Integer
    Private tipoPos As String
    Private pos As Integer
    Private tSize As Size
    Private textRect As Rectangle
    Private bordeRect As Rectangle
    Sub New(ByVal grupoBox As GroupBox, ByVal e As PaintEventArgs, ByVal grosor As Integer, ByVal color As Color, ByVal radio As Integer,
         Optional ByVal tipoPos As String = "l", Optional ByVal pos As Integer = 20)
        Me.grupoBox = grupoBox
        Me.e = e
        Me.grosor = grosor
        Me.color = color
        Me.radio = radio
        Me.tipoPos = tipoPos
        Me.pos = pos
        tSize = TextRenderer.MeasureText(grupoBox.Text, grupoBox.Font)
        textRect = getTextRect()
        bordeRect = getBordeRect(grupoBox, e)
        updateGrupoBox()
    End Sub

    '
    'Obtenemos El Texto Del GroupBox
    '
    Private Function getTextRect() As Rectangle
        textRect = e.ClipRectangle
        textRect.Width = tSize.Width
        textRect.Height = tSize.Height
        textRect.X += 5
        Return textRect
    End Function

    '
    'Obtenemos El Borde Del GroupBox
    '
    Private Function getBordeRect(ByVal grupoBox As GroupBox, ByVal e As PaintEventArgs) As Rectangle
        bordeRect = e.ClipRectangle
        bordeRect.Width -= 1
        bordeRect.Height -= (1.5 + (tSize.Height / 2))
        bordeRect.Y += (tSize.Height / 2)
        Return bordeRect
    End Function

    '
    'Actualizamos La Posicion Y Dimensiones Del Borde Dependiendo Del Grosor Aplicado
    '
    Private Sub updateBordeRect()
        bordeRect.X += (grosor / 2)
        bordeRect.Width -= grosor
        bordeRect.Y += (grosor / 2)
        bordeRect.Height -= grosor
    End Sub

    '
    'Aplicamos El Redondeo Del Borde
    '
    Private Sub roundBordeRect()
        Dim medGrosor As Integer = grosor / 2
        Dim coorXdel As Integer = bordeRect.X - medGrosor
        Dim coorYdel As Integer = bordeRect.Y - medGrosor
        Dim incrementDelX As Integer = bordeRect.Width - (radio - grosor)
        Dim coorXins As Integer = bordeRect.X
        Dim coorYins As Integer = bordeRect.Y
        Dim diam As Integer = radio * 2
        Dim angIni As Integer = 180
        For y = 1 To 2
            For x = 1 To 2
                If x = 2 And y = 1 Then coorXdel += incrementDelX : coorXins += (bordeRect.Width - diam)
                If x = 2 And y = 2 Then coorXdel -= incrementDelX : coorXins -= (bordeRect.Width - diam)
                e.Graphics.FillRectangle(New SolidBrush(grupoBox.BackColor), New Rectangle(coorXdel, coorYdel, radio, radio))
                e.Graphics.DrawArc(New Pen(color, grosor), coorXins, coorYins, diam, diam, angIni, 90)
                angIni += 90
            Next
            If y = 1 Then coorYdel += (bordeRect.Height - (radio - grosor)) : coorYins += (bordeRect.Height - diam)
        Next
    End Sub

    '
    'Obtenemos La Separacion Minima Que Debe haber Enter Uno De los Extremos Verticales Del Borde Y El Texto
    '
    Private Function getLeftControlGroupBox() As Double
        Dim margen As Double
        For Each mycontrol In grupoBox.Controls
            If mycontrol.tag = "Act" Then margen = mycontrol.left + (grosor / 2)
        Next
        If radio > margen Then Return radio Else Return margen
    End Function

    '
    'Obtenemos La Posicion Del Texto Dependiendo De Si Queremos Colocarlo A La Izquierda, A La Derecha, Centrado O De Forma Arbitraria
    '
    Private Function posX() As Double
        If tipoPos.ToLower = "l" Then
            Return bordeRect.X + getLeftControlGroupBox() + 5.5
        ElseIf tipoPos.ToLower = "r" Then
            Return bordeRect.X + bordeRect.Width - getLeftControlGroupBox() - textRect.Width - 5
        ElseIf tipoPos = "c".ToLower Then
            Return ((bordeRect.Width - textRect.Width) / 2) + bordeRect.X
        Else
            Return bordeRect.X + pos
        End If
    End Function

    '
    'Insertamos El Texto
    '
    Private Sub insertarTextoGroupBox()
        textRect.X = posX()
        e.Graphics.FillRectangle(New SolidBrush(grupoBox.BackColor), textRect)
        textRect.X += 3
        e.Graphics.DrawString(grupoBox.Text, grupoBox.Font, New SolidBrush(grupoBox.ForeColor), textRect)
    End Sub

    '
    'Actualizamos El GroupBox
    '
    Private Sub updateGrupoBox()
        e.Graphics.FillRectangle(New SolidBrush(grupoBox.BackColor), textRect)
        e.Graphics.DrawRectangle(New Pen(grupoBox.BackColor, 3), bordeRect)
        updateBordeRect()
        e.Graphics.DrawRectangle(New Pen(color, grosor), bordeRect)
        roundBordeRect()
        insertarTextoGroupBox()
    End Sub
End Class
