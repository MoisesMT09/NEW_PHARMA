namespace Views
{
    partial class FormRegistarVenda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistarVenda));
            pnDados = new Panel();
            dgvProdutos = new DataGridView();
            txtValorTotal = new TextBox();
            label1 = new Label();
            dtpData = new DateTimePicker();
            label5 = new Label();
            label2 = new Label();
            cmbClientes = new ComboBox();
            dClienteBindingSource1 = new BindingSource(components);
            negFuncionarioBindingSource = new BindingSource(components);
            modeloProdutoBindingSource = new BindingSource(components);
            negClienteBindingSource = new BindingSource(components);
            modeloClienteBindingSource = new BindingSource(components);
            label6 = new Label();
            pnBotao = new Panel();
            btnCancelar = new Button();
            btnSalvar = new Button();
            btnInserir = new Button();
            dClienteBindingSource = new BindingSource(components);
            pbVoltar = new PictureBox();
            pictureBox1 = new PictureBox();
            btndvg_Selecionar = new DataGridViewCheckBoxColumn();
            btnQuantidade = new DataGridViewComboBoxColumn();
            pnDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dClienteBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)negFuncionarioBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)modeloProdutoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)negClienteBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)modeloClienteBindingSource).BeginInit();
            pnBotao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dClienteBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbVoltar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnDados
            // 
            pnDados.BorderStyle = BorderStyle.FixedSingle;
            pnDados.Controls.Add(dgvProdutos);
            pnDados.Controls.Add(txtValorTotal);
            pnDados.Controls.Add(label1);
            pnDados.Controls.Add(dtpData);
            pnDados.Controls.Add(label5);
            pnDados.Controls.Add(label2);
            pnDados.Controls.Add(cmbClientes);
            pnDados.Location = new Point(12, 122);
            pnDados.Name = "pnDados";
            pnDados.Size = new Size(776, 559);
            pnDados.TabIndex = 0;
            // 
            // dgvProdutos
            // 
            dgvProdutos.AllowUserToOrderColumns = true;
            dgvProdutos.BackgroundColor = SystemColors.Menu;
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Columns.AddRange(new DataGridViewColumn[] { btndvg_Selecionar, btnQuantidade });
            dgvProdutos.GridColor = SystemColors.Window;
            dgvProdutos.Location = new Point(15, 82);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.RowHeadersWidth = 62;
            dgvProdutos.Size = new Size(744, 392);
            dgvProdutos.TabIndex = 32;
            // 
            // txtValorTotal
            // 
            txtValorTotal.Font = new Font("Century Schoolbook", 8F, FontStyle.Bold);
            txtValorTotal.Location = new Point(15, 499);
            txtValorTotal.Name = "txtValorTotal";
            txtValorTotal.Size = new Size(390, 27);
            txtValorTotal.TabIndex = 31;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 8F, FontStyle.Bold);
            label1.Location = new Point(490, 11);
            label1.Name = "label1";
            label1.Size = new Size(155, 19);
            label1.TabIndex = 30;
            label1.Text = "DATA DE VENDA";
            // 
            // dtpData
            // 
            dtpData.CalendarFont = new Font("Century Schoolbook", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpData.CalendarTrailingForeColor = SystemColors.Menu;
            dtpData.Font = new Font("Century Schoolbook", 9F);
            dtpData.Location = new Point(474, 33);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(285, 29);
            dtpData.TabIndex = 29;
            dtpData.ValueChanged += dtpData_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Schoolbook", 8F, FontStyle.Bold);
            label5.Location = new Point(15, 477);
            label5.Name = "label5";
            label5.Size = new Size(140, 19);
            label5.TabIndex = 20;
            label5.Text = "VALOR_TOTAL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Schoolbook", 8F, FontStyle.Bold);
            label2.Location = new Point(15, 39);
            label2.Name = "label2";
            label2.Size = new Size(89, 19);
            label2.TabIndex = 13;
            label2.Text = "CLIENTE";
            // 
            // cmbClientes
            // 
            cmbClientes.BackColor = SystemColors.Menu;
            cmbClientes.DataSource = dClienteBindingSource1;
            cmbClientes.Font = new Font("Century Schoolbook", 10F);
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(110, 33);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(350, 31);
            cmbClientes.TabIndex = 6;
            cmbClientes.SelectedIndexChanged += cmbClientes_SelectedIndexChanged;
            // 
            // dClienteBindingSource1
            // 
            dClienteBindingSource1.DataSource = typeof(Dados.DCliente);
            // 
            // modeloProdutoBindingSource
            // 
            modeloProdutoBindingSource.DataSource = typeof(ModeloProduto);
            // 
            // negClienteBindingSource
            // 
            negClienteBindingSource.DataSource = typeof(Negocio.NegCliente);
            // 
            // modeloClienteBindingSource
            // 
            modeloClienteBindingSource.DataSource = typeof(Modelo.ModeloCliente);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold | FontStyle.Underline);
            label6.Location = new Point(280, 16);
            label6.Name = "label6";
            label6.Size = new Size(254, 30);
            label6.TabIndex = 21;
            label6.Text = "REGISTAR VENDA";
            // 
            // pnBotao
            // 
            pnBotao.BorderStyle = BorderStyle.FixedSingle;
            pnBotao.Controls.Add(btnCancelar);
            pnBotao.Controls.Add(btnSalvar);
            pnBotao.Location = new Point(12, 698);
            pnBotao.Name = "pnBotao";
            pnBotao.Size = new Size(776, 90);
            pnBotao.TabIndex = 46;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold);
            btnCancelar.Location = new Point(15, 28);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(285, 40);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Lime;
            btnSalvar.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold);
            btnSalvar.Location = new Point(474, 28);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(285, 40);
            btnSalvar.TabIndex = 9;
            btnSalvar.Text = "SALVAR";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnInserir
            // 
            btnInserir.BackColor = Color.DodgerBlue;
            btnInserir.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold);
            btnInserir.Location = new Point(12, 81);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(250, 35);
            btnInserir.TabIndex = 7;
            btnInserir.Text = "INSERIR\r\n";
            btnInserir.UseVisualStyleBackColor = false;
            btnInserir.Click += btnInserir_Click;
            // 
            // dClienteBindingSource
            // 
            dClienteBindingSource.DataSource = typeof(Dados.DCliente);
            // 
            // pbVoltar
            // 
            pbVoltar.Image = (Image)resources.GetObject("pbVoltar.Image");
            pbVoltar.Location = new Point(12, 16);
            pbVoltar.Name = "pbVoltar";
            pbVoltar.Size = new Size(39, 35);
            pbVoltar.TabIndex = 47;
            pbVoltar.TabStop = false;
            pbVoltar.Click += pbVoltar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(709, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(79, 79);
            pictureBox1.TabIndex = 48;
            pictureBox1.TabStop = false;
            // 
            // btndvg_Selecionar
            // 
            btndvg_Selecionar.HeaderText = "Selecionar";
            btndvg_Selecionar.MinimumWidth = 8;
            btndvg_Selecionar.Name = "btndvg_Selecionar";
            btndvg_Selecionar.Width = 150;
            // 
            // btnQuantidade
            // 
            btnQuantidade.HeaderText = "Quantidade";
            btnQuantidade.MinimumWidth = 8;
            btnQuantidade.Name = "btnQuantidade";
            btnQuantidade.Resizable = DataGridViewTriState.True;
            btnQuantidade.SortMode = DataGridViewColumnSortMode.Automatic;
            btnQuantidade.Width = 150;
            // 
            // FormRegistarVenda
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSpringGreen;
            ClientSize = new Size(800, 800);
            Controls.Add(pictureBox1);
            Controls.Add(pbVoltar);
            Controls.Add(pnBotao);
            Controls.Add(btnInserir);
            Controls.Add(label6);
            Controls.Add(pnDados);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormRegistarVenda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRegistarVenda";
            Load += FormRegistarVenda_Load;
            pnDados.ResumeLayout(false);
            pnDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dClienteBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)negFuncionarioBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)modeloProdutoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)negClienteBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)modeloClienteBindingSource).EndInit();
            pnBotao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dClienteBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbVoltar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnDados;
        private ComboBox cmbClientes;
        private Label label2;
        private Label label5;
        private Label label6;
        private Panel pnBotao;
        private Button btnCancelar;
        private Button btnSalvar;
        private Button btnInserir;
        private DateTimePicker dtpData;
        private Label label1;
        private TextBox txtValorTotal;
        private DataGridView dgvProdutos;
        private BindingSource modeloProdutoBindingSource;
        private BindingSource dClienteBindingSource;
        private BindingSource modeloClienteBindingSource;
        private BindingSource negClienteBindingSource;
        private BindingSource dClienteBindingSource1;
        private BindingSource negFuncionarioBindingSource;
        private PictureBox pbVoltar;
        private PictureBox pictureBox1;
        private DataGridViewCheckBoxColumn btndvg_Selecionar;
        private DataGridViewComboBoxColumn btnQuantidade;
    }
}