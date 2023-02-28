<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        DataGridView1 = New DataGridView()
        Cantidad = New DataGridViewTextBoxColumn()
        Producto = New DataGridViewTextBoxColumn()
        Precio = New DataGridViewTextBoxColumn()
        TxtCantidad = New TextBox()
        TxtProducto = New TextBox()
        TxtPrecio = New TextBox()
        Button1 = New Button()
        Imprimir = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        PictureBox1 = New PictureBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Cantidad, Producto, Precio})
        DataGridView1.Location = New Point(33, 237)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(342, 380)
        DataGridView1.TabIndex = 0
        ' 
        ' Cantidad
        ' 
        Cantidad.HeaderText = "Cantidad"
        Cantidad.Name = "Cantidad"' 
        ' Producto
        ' 
        Producto.HeaderText = "Producto"
        Producto.Name = "Producto"' 
        ' Precio
        ' 
        Precio.HeaderText = "Precio"
        Precio.Name = "Precio"' 
        ' TxtCantidad
        ' 
        TxtCantidad.Location = New Point(33, 191)
        TxtCantidad.Name = "TxtCantidad"
        TxtCantidad.Size = New Size(100, 23)
        TxtCantidad.TabIndex = 1
        ' 
        ' TxtProducto
        ' 
        TxtProducto.Location = New Point(139, 191)
        TxtProducto.Name = "TxtProducto"
        TxtProducto.Size = New Size(100, 23)
        TxtProducto.TabIndex = 2
        ' 
        ' TxtPrecio
        ' 
        TxtPrecio.Location = New Point(255, 191)
        TxtPrecio.Name = "TxtPrecio"
        TxtPrecio.Size = New Size(100, 23)
        TxtPrecio.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(408, 191)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 4
        Button1.Text = "Agregar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Imprimir
        ' 
        Imprimir.Location = New Point(408, 594)
        Imprimir.Name = "Imprimir"
        Imprimir.Size = New Size(75, 23)
        Imprimir.TabIndex = 5
        Imprimir.Text = "Imprimir"
        Imprimir.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(54, 173)
        Label1.Name = "Label1"
        Label1.Size = New Size(55, 15)
        Label1.TabIndex = 6
        Label1.Text = "Cantidad"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(165, 173)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 15)
        Label2.TabIndex = 7
        Label2.Text = "Producto"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(284, 173)
        Label3.Name = "Label3"
        Label3.Size = New Size(40, 15)
        Label3.TabIndex = 8
        Label3.Text = "Precio"' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(13, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(470, 130)
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(512, 629)
        Controls.Add(PictureBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Imprimir)
        Controls.Add(Button1)
        Controls.Add(TxtPrecio)
        Controls.Add(TxtProducto)
        Controls.Add(TxtCantidad)
        Controls.Add(DataGridView1)
        Name = "Form1"
        Text = "Form1"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Producto As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents TxtCantidad As TextBox
    Friend WithEvents TxtProducto As TextBox
    Friend WithEvents TxtPrecio As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Imprimir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
