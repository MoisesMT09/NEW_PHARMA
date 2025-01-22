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
            pnDados = new Panel();
            dgvProdutos = new DataGridView();
            txtValorTotal = new TextBox();
            label1 = new Label();
            dtpData = new DateTimePicker();
            label5 = new Label();
            label2 = new Label();
            cmbClientes = new ComboBox();
            negFuncionarioBindingSource = new BindingSource(components);
            label6 = new Label();
            pnBotao = new Panel();
            btnCancelar = new Button();
            btnSalvar = new Button();
            btnInserir = new Button();
            pbVoltar = new PictureBox();
            label9 = new Label();
            pictureBox1 = new PictureBox();
            pnDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)negFuncionarioBindingSource).BeginInit();
            pnBotao.SuspendLayout();
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
            pnDados.Location = new Point(8, 99);
            pnDados.Margin = new Padding(2);
            pnDados.Name = "pnDados";
            pnDados.Size = new Size(781, 630);
            pnDados.TabIndex = 0;
            // 
            // dgvProdutos
            // 
            dgvProdutos.AllowUserToOrderColumns = true;
            dgvProdutos.BackgroundColor = SystemColors.Menu;
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.GridColor = SystemColors.Window;
            dgvProdutos.Location = new Point(10, 49);
            dgvProdutos.Margin = new Padding(2);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.RowHeadersWidth = 62;
            dgvProdutos.Size = new Size(758, 530);
            dgvProdutos.TabIndex = 32;
            // 
            // txtValorTotal
            // 
            txtValorTotal.Font = new Font("Century Schoolbook", 8F, FontStyle.Bold);
            txtValorTotal.Location = new Point(10, 597);
            txtValorTotal.Margin = new Padding(2);
            txtValorTotal.Name = "txtValorTotal";
            txtValorTotal.Size = new Size(313, 20);
            txtValorTotal.TabIndex = 31;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 8F, FontStyle.Bold);
            label1.Location = new Point(567, 7);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(105, 14);
            label1.TabIndex = 30;
            label1.Text = "DATA DE VENDA";
            // 
            // dtpData
            // 
            dtpData.CalendarFont = new Font("Century Schoolbook", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpData.CalendarTrailingForeColor = SystemColors.Menu;
            dtpData.Font = new Font("Century Schoolbook", 9F);
            dtpData.Location = new Point(567, 23);
            dtpData.Margin = new Padding(2);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(201, 22);
            dtpData.TabIndex = 29;
            dtpData.ValueChanged += dtpData_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Schoolbook", 8F, FontStyle.Bold);
            label5.Location = new Point(10, 581);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(96, 14);
            label5.TabIndex = 20;
            label5.Text = "VALOR_TOTAL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Schoolbook", 8F, FontStyle.Bold);
            label2.Location = new Point(10, 23);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(61, 14);
            label2.TabIndex = 13;
            label2.Text = "CLIENTE";
            // 
            // cmbClientes
            // 
            cmbClientes.BackColor = SystemColors.Menu;
            cmbClientes.Font = new Font("Century Schoolbook", 10F);
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(77, 20);
            cmbClientes.Margin = new Padding(2);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(246, 24);
            cmbClientes.TabIndex = 6;
            cmbClientes.SelectedIndexChanged += cmbClientes_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Schoolbook", 13F, FontStyle.Bold | FontStyle.Underline);
            label6.Location = new Point(300, 17);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(193, 21);
            label6.TabIndex = 21;
            label6.Text = "REGISTAR VENDA";
            // 
            // pnBotao
            // 
            pnBotao.BorderStyle = BorderStyle.FixedSingle;
            pnBotao.Controls.Add(btnCancelar);
            pnBotao.Controls.Add(btnSalvar);
            pnBotao.Location = new Point(8, 747);
            pnBotao.Margin = new Padding(2);
            pnBotao.Name = "pnBotao";
            pnBotao.Size = new Size(781, 42);
            pnBotao.TabIndex = 46;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold);
            btnCancelar.Location = new Point(10, 8);
            btnCancelar.Margin = new Padding(2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(372, 27);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Lime;
            btnSalvar.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold);
            btnSalvar.Location = new Point(397, 8);
            btnSalvar.Margin = new Padding(2);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(371, 27);
            btnSalvar.TabIndex = 9;
            btnSalvar.Text = "SALVAR";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnInserir
            // 
            btnInserir.BackColor = Color.DodgerBlue;
            btnInserir.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold);
            btnInserir.Location = new Point(8, 70);
            btnInserir.Margin = new Padding(2);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(175, 25);
            btnInserir.TabIndex = 7;
            btnInserir.Text = "INSERIR\r\n";
            btnInserir.UseVisualStyleBackColor = false;
            btnInserir.Click += btnInserir_Click;
            // 
            // pbVoltar
            // 
            pbVoltar.Image = Properties.Resources.back_112351;
            pbVoltar.Location = new Point(8, 10);
            pbVoltar.Margin = new Padding(2);
            pbVoltar.Name = "pbVoltar";
            pbVoltar.Size = new Size(36, 28);
            pbVoltar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbVoltar.TabIndex = 47;
            pbVoltar.TabStop = false;
            pbVoltar.Click += pbVoltar_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Schoolbook", 6F, FontStyle.Bold);
            label9.Location = new Point(719, 75);
            label9.Name = "label9";
            label9.Size = new Size(70, 12);
            label9.TabIndex = 66;
            label9.Text = "NEW_PHARMA";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.medicine_icon_icons_com_66070;
            pictureBox1.Location = new Point(717, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(72, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 65;
            pictureBox1.TabStop = false;
            // 
            // FormRegistarVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSpringGreen;
            ClientSize = new Size(800, 800);
            Controls.Add(label9);
            Controls.Add(pictureBox1);
            Controls.Add(pbVoltar);
            Controls.Add(pnBotao);
            Controls.Add(btnInserir);
            Controls.Add(label6);
            Controls.Add(pnDados);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "FormRegistarVenda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRegistarVenda";
            Load += FormRegistarVenda_Load;
            pnDados.ResumeLayout(false);
            pnDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ((System.ComponentModel.ISupportInitialize)negFuncionarioBindingSource).EndInit();
            pnBotao.ResumeLayout(false);
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
        private BindingSource negFuncionarioBindingSource;
        private PictureBox pbVoltar;
        private Label label9;
        private PictureBox pictureBox1;
    }
}