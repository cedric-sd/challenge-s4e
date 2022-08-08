<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Associates
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.inputCpf = New System.Windows.Forms.TextBox()
        Me.inputNome = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnPesquisar = New System.Windows.Forms.Button()
        Me.dataList = New System.Windows.Forms.DataGridView()
        Me.inputData = New System.Windows.Forms.DateTimePicker()
        Me.btnGetById = New System.Windows.Forms.Button()
        Me.inputId = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.dataList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(109, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(336, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "CPF"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(481, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Data de nascimento"
        '
        'inputCpf
        '
        Me.inputCpf.Location = New System.Drawing.Point(339, 42)
        Me.inputCpf.Name = "inputCpf"
        Me.inputCpf.Size = New System.Drawing.Size(133, 20)
        Me.inputCpf.TabIndex = 3
        '
        'inputNome
        '
        Me.inputNome.Location = New System.Drawing.Point(112, 42)
        Me.inputNome.Name = "inputNome"
        Me.inputNome.Size = New System.Drawing.Size(213, 20)
        Me.inputNome.TabIndex = 5
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(29, 82)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "Adicionar"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(191, 82)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 7
        Me.btnDelete.Text = "Excluir"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(110, 82)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 8
        Me.btnEdit.Text = "Editar"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnPesquisar
        '
        Me.btnPesquisar.Location = New System.Drawing.Point(694, 40)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(75, 23)
        Me.btnPesquisar.TabIndex = 9
        Me.btnPesquisar.Text = "Pesquisar"
        Me.btnPesquisar.UseVisualStyleBackColor = True
        '
        'dataList
        '
        Me.dataList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataList.Location = New System.Drawing.Point(29, 127)
        Me.dataList.Name = "dataList"
        Me.dataList.Size = New System.Drawing.Size(739, 306)
        Me.dataList.TabIndex = 10
        '
        'inputData
        '
        Me.inputData.Location = New System.Drawing.Point(484, 42)
        Me.inputData.Name = "inputData"
        Me.inputData.Size = New System.Drawing.Size(185, 20)
        Me.inputData.TabIndex = 11
        '
        'btnGetById
        '
        Me.btnGetById.Location = New System.Drawing.Point(272, 82)
        Me.btnGetById.Name = "btnGetById"
        Me.btnGetById.Size = New System.Drawing.Size(114, 23)
        Me.btnGetById.TabIndex = 12
        Me.btnGetById.Text = "Consulta por Id"
        Me.btnGetById.UseVisualStyleBackColor = True
        '
        'inputId
        '
        Me.inputId.Location = New System.Drawing.Point(29, 42)
        Me.inputId.Name = "inputId"
        Me.inputId.Size = New System.Drawing.Size(73, 20)
        Me.inputId.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Id"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.inputId)
        Me.Controls.Add(Me.btnGetById)
        Me.Controls.Add(Me.inputData)
        Me.Controls.Add(Me.dataList)
        Me.Controls.Add(Me.btnPesquisar)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.inputNome)
        Me.Controls.Add(Me.inputCpf)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Associados"
        CType(Me.dataList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents inputCpf As TextBox
    Friend WithEvents inputNome As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnPesquisar As Button
    Friend WithEvents dataList As DataGridView
    Friend WithEvents inputData As DateTimePicker
    Friend WithEvents btnGetById As Button
    Friend WithEvents inputId As TextBox
    Friend WithEvents Label4 As Label
End Class
