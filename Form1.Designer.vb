<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tc = New System.Windows.Forms.TextBox()
        Me.tn = New System.Windows.Forms.TextBox()
        Me.tx = New System.Windows.Forms.TextBox()
        Me.tv = New System.Windows.Forms.TextBox()
        Me.parejas = New System.Windows.Forms.Button()
        Me.pg = New System.Windows.Forms.Button()
        Me.sg = New System.Windows.Forms.Button()
        Me.graficar = New System.Windows.Forms.Button()
        Me.limpiar = New System.Windows.Forms.Button()
        Me.salir = New System.Windows.Forms.Button()
        Me.salida = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.graf = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ibb = New System.Windows.Forms.TextBox()
        CType(Me.salida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.graf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Dame cifra significativa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Dame el numero de parejas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Dame el numero a interpolar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 341)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Valor Interpolado"
        '
        'tc
        '
        Me.tc.Location = New System.Drawing.Point(178, 15)
        Me.tc.Name = "tc"
        Me.tc.Size = New System.Drawing.Size(117, 20)
        Me.tc.TabIndex = 4
        '
        'tn
        '
        Me.tn.Location = New System.Drawing.Point(178, 42)
        Me.tn.Name = "tn"
        Me.tn.Size = New System.Drawing.Size(117, 20)
        Me.tn.TabIndex = 5
        '
        'tx
        '
        Me.tx.Location = New System.Drawing.Point(178, 72)
        Me.tx.Name = "tx"
        Me.tx.Size = New System.Drawing.Size(117, 20)
        Me.tx.TabIndex = 6
        '
        'tv
        '
        Me.tv.Location = New System.Drawing.Point(128, 338)
        Me.tv.Name = "tv"
        Me.tv.Size = New System.Drawing.Size(117, 20)
        Me.tv.TabIndex = 7
        '
        'parejas
        '
        Me.parejas.Location = New System.Drawing.Point(361, 20)
        Me.parejas.Name = "parejas"
        Me.parejas.Size = New System.Drawing.Size(120, 20)
        Me.parejas.TabIndex = 8
        Me.parejas.Text = "Introducir Parejas"
        Me.parejas.UseVisualStyleBackColor = True
        '
        'pg
        '
        Me.pg.Location = New System.Drawing.Point(361, 49)
        Me.pg.Name = "pg"
        Me.pg.Size = New System.Drawing.Size(120, 20)
        Me.pg.TabIndex = 9
        Me.pg.Text = "Primer Grado"
        Me.pg.UseVisualStyleBackColor = True
        '
        'sg
        '
        Me.sg.Location = New System.Drawing.Point(361, 75)
        Me.sg.Name = "sg"
        Me.sg.Size = New System.Drawing.Size(120, 20)
        Me.sg.TabIndex = 10
        Me.sg.Text = "Segundo Grado"
        Me.sg.UseVisualStyleBackColor = True
        '
        'graficar
        '
        Me.graficar.Location = New System.Drawing.Point(361, 105)
        Me.graficar.Name = "graficar"
        Me.graficar.Size = New System.Drawing.Size(120, 20)
        Me.graficar.TabIndex = 11
        Me.graficar.Text = "Graficar"
        Me.graficar.UseVisualStyleBackColor = True
        '
        'limpiar
        '
        Me.limpiar.Location = New System.Drawing.Point(361, 131)
        Me.limpiar.Name = "limpiar"
        Me.limpiar.Size = New System.Drawing.Size(120, 20)
        Me.limpiar.TabIndex = 12
        Me.limpiar.Text = "Limpiar"
        Me.limpiar.UseVisualStyleBackColor = True
        '
        'salir
        '
        Me.salir.Location = New System.Drawing.Point(361, 157)
        Me.salir.Name = "salir"
        Me.salir.Size = New System.Drawing.Size(120, 20)
        Me.salir.TabIndex = 13
        Me.salir.Text = "Salir"
        Me.salir.UseVisualStyleBackColor = True
        '
        'salida
        '
        Me.salida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.salida.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.salida.Location = New System.Drawing.Point(6, 107)
        Me.salida.Name = "salida"
        Me.salida.Size = New System.Drawing.Size(349, 147)
        Me.salida.TabIndex = 15
        '
        'Column1
        '
        Me.Column1.HeaderText = "Indice"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "x(i)"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "y(i)"
        Me.Column3.Name = "Column3"
        '
        'graf
        '
        ChartArea2.Name = "ChartArea1"
        Me.graf.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.graf.Legends.Add(Legend2)
        Me.graf.Location = New System.Drawing.Point(508, 18)
        Me.graf.Name = "graf"
        Series3.ChartArea = "ChartArea1"
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Series4.ChartArea = "ChartArea1"
        Series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point
        Series4.Legend = "Legend1"
        Series4.Name = "Series2"
        Me.graf.Series.Add(Series3)
        Me.graf.Series.Add(Series4)
        Me.graf.Size = New System.Drawing.Size(286, 264)
        Me.graf.TabIndex = 16
        Me.graf.Text = "Chart1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 265)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Ib"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'ibb
        '
        Me.ibb.Location = New System.Drawing.Point(57, 258)
        Me.ibb.Name = "ibb"
        Me.ibb.Size = New System.Drawing.Size(124, 20)
        Me.ibb.TabIndex = 20
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ibb)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.graf)
        Me.Controls.Add(Me.salida)
        Me.Controls.Add(Me.salir)
        Me.Controls.Add(Me.limpiar)
        Me.Controls.Add(Me.graficar)
        Me.Controls.Add(Me.sg)
        Me.Controls.Add(Me.pg)
        Me.Controls.Add(Me.parejas)
        Me.Controls.Add(Me.tv)
        Me.Controls.Add(Me.tx)
        Me.Controls.Add(Me.tn)
        Me.Controls.Add(Me.tc)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.salida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.graf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tc As TextBox
    Friend WithEvents tn As TextBox
    Friend WithEvents tx As TextBox
    Friend WithEvents tv As TextBox
    Friend WithEvents parejas As Button
    Friend WithEvents pg As Button
    Friend WithEvents sg As Button
    Friend WithEvents graficar As Button
    Friend WithEvents limpiar As Button
    Friend WithEvents salir As Button
    Friend WithEvents salida As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents graf As DataVisualization.Charting.Chart
    Friend WithEvents Label5 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ibb As TextBox
End Class
