Imports System.IO
Public Class FrmListArch
    Private folderDialog As New FolderBrowserDialog
    Private folderRaiz As String
    Private listaDirectorios As New List(Of String)
    Private actual As Integer
    Private fuentePequeña As Font = New Font("Verdana", 15, FontStyle.Bold)
    Private fuenteGrande As Font = New Font("Verdana", 30, FontStyle.Bold)
    Private listaTextos As New List(Of String) From {"", "", ""}

    '
    'Centrar El Formulario Al Redimensionarse
    '
    Private Sub FrmListArch_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Centrar()
    End Sub

    '
    'Centrar El Formulario
    '
    Private Sub Centrar()
        Dim tamaño As Rectangle = My.Computer.Screen.Bounds
        Dim posicionX As Integer = (tamaño.Width - Me.Width) \ 2
        Dim posicionY As Integer = (tamaño.Height - Me.Height) \ 2
        Me.Location = New Point(posicionX, posicionY)
        Me.Refresh()
    End Sub

    '
    'Cerrar El Formulario Al Hacer Click En El contenedor Del Titulo O En El Titulo
    '
    Private Sub TlpMensaje_Click(sender As Object, e As EventArgs) Handles TlpMensaje.Click, LbTitulo.Click
        Me.Close()
    End Sub

    '
    'Mover El Formulario Al Mantener Pulsado Sobre El Titulo O Su Contenedor
    '
    Private Sub TlpMensaje_MouseMove(sender As Object, e As MouseEventArgs) Handles TlpMensaje.MouseMove, LbTitulo.MouseMove
        If e.Button = MouseButtons.Left Then moverForm(Me)
    End Sub

    '
    'Eliminar El Contenido Del Textbox 'Limpiar Extensiones' Y Coger Su Foco
    '
    Private Sub BtExtensiones_Click(sender As Object, e As EventArgs) Handles BtExtensiones.Click
        TbExtensiones.Clear() : TbExtensiones.Focus()
    End Sub

    '
    'Boton Para Seleccionar Una Carpeta Valida, Posteriormente Obtendremos Sus Subcarpetas Y Crearemos El Listado
    '
    Private Sub BtCarpeta_Click(sender As Object, e As EventArgs) Handles BtCarpeta.Click
        If selectFolder() Then listadoFolders() : crearListado()
    End Sub

    '
    'Controlar Si Se Ha Seleccionado Una Carpeta Valida Ajustando El Tamaño Del Textbox 'Seleccione Carpeta' A Su Contenido
    '
    Private Function selectFolder() As Boolean
        Dim devolver As Boolean
        folderRaiz = "Seleccione Carpeta"
        If folderDialog.ShowDialog = DialogResult.OK Then folderRaiz = folderDialog.SelectedPath : devolver = True
        TbCarpeta.Text = folderRaiz
        Refresh()
        Return devolver
    End Function

    '
    'Ajustar El Tamaño del Textbox 'Seleccione Carpeta' A Su Contenido, Al Ser Modificado
    '
    Private Sub TbCarpeta_TextChanged(sender As Object, e As EventArgs) Handles TbCarpeta.TextChanged
        TbCarpeta.Width = TextRenderer.MeasureText(TbCarpeta.Text, TbCarpeta.Font).Width
    End Sub

    '
    'Obtener La Carpeta Y Las Subcarpetas De La Carpeta Seleccionada
    '
    Private Sub listadoFolders()
        listaDirectorios.Clear()
        listaDirectorios.Add(folderRaiz)
        If CheckBoxSubcarpetas.Checked Then subCarpetas(folderRaiz, listaDirectorios)
    End Sub

    '
    'Obtener Las Subcarpetas De La Carpeta Seleccionada
    '
    Private Sub subCarpetas(ByVal origen As String, ByVal listaDirectorios As List(Of String))
        For Each Dire In Directory.GetDirectories(origen)
            If Not Dire.Contains("I:\planos2d\cosmos\celdas\desarrollos_cofabricacion") And
                    Not Dire.Contains("I:\planos2d\cosmos\espe\oitsa3Dnew") And
                    Not Dire.Contains("I:\planos2d\cosmos\espe\oitsa3D") Then
                listaDirectorios.Add(Dire)
            End If
            subCarpetas(Dire, listaDirectorios)
        Next
    End Sub

    '
    'Crear Listado De Los Archivos Que Se Encuentran En La Carpeta Seleccionada Dependiendo De Los Filtros Seleccionados
    '
    Private Sub crearListado()
        Dim listaArchivos As List(Of String)
        Dim listaExtensiones As List(Of String) = getListaExtensiones()
        Dim numFoldersRaiz As Integer = Split(folderRaiz, "\").Count
        Dim numFoldersActual As Integer
        Dim escritor As StreamWriter
        Dim archivo As String = folderRaiz & ultimoGrupo(folderRaiz) & ".txt"
        File.Delete(archivo)
        escritor = File.AppendText(archivo)
        For Each dire In listaDirectorios
            numFoldersActual = Split(dire, "\").Count
            escritor.Write(vbCr)
            tabular(numFoldersRaiz, numFoldersActual, escritor)
            If dire = folderRaiz Then escritor.Write(dire & vbCr) Else escritor.Write(ultimoGrupo(dire) & vbCr)
            listaArchivos = getListaArchivos(listaExtensiones, dire)
            listaTextos(0) = listaDirectorios.IndexOf(dire) + 1 & "/" & listaDirectorios.Count & ": " & ultimoGrupo(dire)
            archivosCarpeta(listaArchivos, numFoldersRaiz, numFoldersActual, escritor)
            PbBarra.Refresh()
        Next
        escritor.Close()
    End Sub

    '
    'Obtener Las Extensiones Aplicadas En El Filtro
    '
    Private Function getListaExtensiones() As List(Of String)
        Dim lista As New List(Of String)
        If RbExtGeneral.Checked Then lista.Add("*.*") Else lista.AddRange(Split(TbExtensiones.Text, ",").ToList)
        Return lista
    End Function

    '
    'Obtener El Ultimo Grupo De La Ruta
    '
    Private Function ultimoGrupo(ByVal ruta As String, Optional ByVal barra As Integer = 0) As String
        Return Mid(ruta, InStrRev(ruta, "\") + barra)
    End Function

    '
    'Insertar Tabulaciones En El Archivo Dependiendo De La Carpeta En La Que Nos Encontremos
    '
    Private Sub tabular(ByVal numFoldersRaiz As Integer, ByVal numFoldersActual As Integer, ByVal escritor As StreamWriter)
        For i = numFoldersRaiz To numFoldersActual - 1
            escritor.Write(vbTab)
        Next
    End Sub

    '
    'Obtener Los Archivos Que Se Encuentran En La Carpeta Pasada Como Parametro, Dependiendo De Los Filtros Aplicados
    '
    Private Function getListaArchivos(ByVal listaExtensiones As List(Of String), ByVal dire As String) As List(Of String)
        Dim lista As New List(Of String)
        For Each ext In listaExtensiones
            For Each arch In Directory.GetFiles(dire, "*." & ext)
                lista.Add(arch)
            Next
        Next
        Return lista
    End Function

    '
    'Insertar En El Archivo Los Archivos Que Se Encuentran En La Lista Pasada Como Parametro Y Actualizar La Barra De Progreso Circular
    '
    Private Sub archivosCarpeta(ByVal listaArchivos As List(Of String), ByVal numFoldersRaiz As Integer, ByVal numFoldersActual As Integer,
                                ByVal escritor As StreamWriter)
        Dim contador As Integer = 0
        Dim maximo As Integer = listaArchivos.Count
        For Each arch In listaArchivos
            tabular(numFoldersRaiz, numFoldersActual, escritor)
            escritor.Write(vbTab & ultimoGrupo(arch, 1) & vbCr)
            contador += 1
            actual = (360 / maximo) * contador
            listaTextos(2) = CInt(actual * 100 / 360) & "%"
            listaTextos(1) = contador & "/" & maximo & ": " & ultimoGrupo(arch, 1)
            updateBarra()
        Next
    End Sub

    '
    'Actualizar La Barra De Progreso Circular
    '
    Private Sub updateBarra()
        Dim anchoTexto As Integer
        For Each texto In listaTextos
            anchoTexto = TextRenderer.MeasureText(texto, fuentePequeña).Width
            If PbBarra.Width < anchoTexto Then PbBarra.Width = anchoTexto : Refresh()
        Next
        PbBarra.Invalidate()
        PbBarra.Refresh()
        Threading.Thread.Sleep(20)
    End Sub

    '
    'Dibujar La Barra De Progreso Circular
    '
    Private Sub PbBarra_Paint(sender As Object, e As PaintEventArgs) Handles PbBarra.Paint
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        dibujarBarra(e, Color.DarkGray, 360)
        dibujarBarra(e, Color.DarkBlue, actual)
        dibujarTexto(e, listaTextos(2), fuenteGrande, 100, 30)
        dibujarTexto(e, listaTextos(0), fuentePequeña, 30, 0)
        dibujarTexto(e, listaTextos(1), fuentePequeña, 30, 130)
    End Sub

    '
    'Dibujar Circulo De La Barra De Progreso Circular
    '
    Private Sub dibujarBarra(ByVal e As PaintEventArgs, ByVal color As Color, ByVal grados As Integer)
        Dim lapiz As Pen = New Pen(color, 10)
        Dim rectangulo As New Rectangle(5, 35, PbBarra.Width - 11, 89)
        e.Graphics.DrawArc(lapiz, rectangulo, 0, grados)
    End Sub

    '
    'Dibujar Texto De La Barra De Progreso Circular
    '
    Private Sub dibujarTexto(ByVal e As PaintEventArgs, ByVal texto As String, ByVal fuente As Font, ByVal alturaZona As Integer, ByVal alturaIni As Integer)
        Dim tSize As Size = TextRenderer.MeasureText(texto, fuente)
        e.Graphics.DrawString(texto, fuente, Brushes.White, ((PbBarra.Width - tSize.Width) / 2), ((alturaZona - tSize.Height) / 2) + alturaIni)
    End Sub

    '
    'Dibujar Borde Del Contenedor Del Titulo
    '
    Private Sub TlpMensaje_Paint(sender As Object, e As PaintEventArgs) Handles TlpMensaje.Paint
        Dim penIni As Pen = New Pen(Color.Crimson, 10)
        e.Graphics.DrawRectangle(penIni, New Rectangle(0, 0, TlpMensaje.Width, TlpMensaje.Height))
    End Sub

    '
    'Dibujar Borde Del Formulario
    '
    Private Sub FrmListArch_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim penIni As Pen = New Pen(Color.Crimson, 10)
        e.Graphics.DrawRectangle(penIni, New Rectangle(0, 0, Width, Height))
    End Sub

    '
    'Dibujar Borde Del Contenedor Principal Y De Sus Filas
    '
    Private Sub TlpPrincipal_CellPaint(sender As Object, e As TableLayoutCellPaintEventArgs) Handles TlpPrincipal.CellPaint
        e.Graphics.DrawLine(New Pen(Color.Crimson, 5), e.CellBounds.Location, New Point(e.CellBounds.Right, e.CellBounds.Top))
        e.Graphics.DrawRectangle(New Pen(Color.Crimson, 10), New Rectangle(0, 0, TlpPrincipal.Width, TlpPrincipal.Height))
    End Sub

    '
    'Dibujar Borde Del GroupBox
    '
    Private Sub GbFiltro_Paint(sender As Object, e As PaintEventArgs) Handles GbFiltro.Paint
        Dim persoGrupoBox As New ClsGroupBox(sender, e, 5, Color.AntiqueWhite, 10)
    End Sub
End Class
