<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Companies
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.inputId = New System.Windows.Forms.TextBox()
        Me.btnGetById = New System.Windows.Forms.Button()
        Me.dataList = New System.Windows.Forms.DataGridView()
        Me.btnPesquisar = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.inputNome = New System.Windows.Forms.TextBox()
        Me.inputCnpj = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dataList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Id"
        '
        'inputId
        '
        Me.inputId.Location = New System.Drawing.Point(32, 38)
        Me.inputId.Name = "inputId"
        Me.inputId.Size = New System.Drawing.Size(73, 20)
        Me.inputId.TabIndex = 27
        '
        'btnGetById
        '
        Me.btnGetById.Location = New System.Drawing.Point(275, 78)
        Me.btnGetById.Name = "btnGetById"
        Me.btnGetById.Size = New System.Drawing.Size(114, 23)
        Me.btnGetById.TabIndex = 26
        Me.btnGetById.Text = "Consulta por Id"
        Me.btnGetById.UseVisualStyleBackColor = True
        '
        'dataList
        '
        Me.dataList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataList.Location = New System.Drawing.Point(32, 123)
        Me.dataList.Name = "dataList"
        Me.dataList.Size = New System.Drawing.Size(739, 306)
        Me.dataList.TabIndex = 24
        '
        'btnPesquisar
        '
        Me.btnPesquisar.Location = New System.Drawing.Point(509, 36)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(75, 23)
        Me.btnPesquisar.TabIndex = 23
        Me.btnPesquisar.Text = "Pesquisar"
        Me.btnPesquisar.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(113, 78)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 22
        Me.btnEdit.Text = "Editar"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(194, 78)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 21
        Me.btnDelete.Text = "Excluir"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(32, 78)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 20
        Me.btnAdd.Text = "Adicionar"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'inputNome
        '
        Me.inputNome.Location = New System.Drawing.Point(115, 38)
        Me.inputNome.Name = "inputNome"
        Me.inputNome.Size = New System.Drawing.Size(213, 20)
        Me.inputNome.TabIndex = 19
        '
        'inputCnpj
        '
        Me.inputCnpj.Location = New System.Drawing.Point(342, 38)
        Me.inputCnpj.Name = "inputCnpj"
        Me.inputCnpj.Size = New System.Drawing.Size(133, 20)
        Me.inputCnpj.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(339, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "CNPJ"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(112, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Nome"
        '
        'Companies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.inputId)
        Me.Controls.Add(Me.btnGetById)
        Me.Controls.Add(Me.dataList)
        Me.Controls.Add(Me.btnPesquisar)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.inputNome)
        Me.Controls.Add(Me.inputCnpj)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Companies"
        Me.Text = "Companies"
        CType(Me.dataList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents inputId As TextBox
    Friend WithEvents btnGetById As Button
    Friend WithEvents dataList As DataGridView
    Friend WithEvents btnPesquisar As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents inputNome As TextBox
    Friend WithEvents inputCnpj As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
