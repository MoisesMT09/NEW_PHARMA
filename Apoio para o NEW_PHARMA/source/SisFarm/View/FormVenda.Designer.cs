namespace View
{
    partial class FormVenda
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbClientes = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbProdutos = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtQuantidade = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvItensVenda = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnFinalizarVenda = new Guna.UI2.WinForms.Guna2Button();
            this.lblTotalVenda = new System.Windows.Forms.Label();
            this.btnAdicionarItem = new Guna.UI2.WinForms.Guna2Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbClientes
            // 
            this.cmbClientes.BackColor = System.Drawing.Color.Transparent;
            this.cmbClientes.BorderRadius = 10;
            this.cmbClientes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClientes.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(138)))));
            this.cmbClientes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(138)))));
            this.cmbClientes.Font = new System.Drawing.Font("Poppins", 9F);
            this.cmbClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbClientes.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(138)))));
            this.cmbClientes.ItemHeight = 30;
            this.cmbClientes.Location = new System.Drawing.Point(65, 146);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(210, 36);
            this.cmbClientes.TabIndex = 3;
            // 
            // cmbProdutos
            // 
            this.cmbProdutos.BackColor = System.Drawing.Color.Transparent;
            this.cmbProdutos.BorderRadius = 10;
            this.cmbProdutos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbProdutos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProdutos.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(138)))));
            this.cmbProdutos.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(138)))));
            this.cmbProdutos.Font = new System.Drawing.Font("Poppins", 9F);
            this.cmbProdutos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbProdutos.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(138)))));
            this.cmbProdutos.ItemHeight = 30;
            this.cmbProdutos.Location = new System.Drawing.Point(304, 146);
            this.cmbProdutos.Name = "cmbProdutos";
            this.cmbProdutos.Size = new System.Drawing.Size(210, 36);
            this.cmbProdutos.TabIndex = 4;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.BorderRadius = 10;
            this.txtQuantidade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantidade.DefaultText = "";
            this.txtQuantidade.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQuantidade.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQuantidade.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantidade.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantidade.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(138)))));
            this.txtQuantidade.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtQuantidade.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(138)))));
            this.txtQuantidade.Location = new System.Drawing.Point(535, 142);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.PasswordChar = '\0';
            this.txtQuantidade.PlaceholderText = "Quantidade";
            this.txtQuantidade.SelectedText = "";
            this.txtQuantidade.Size = new System.Drawing.Size(210, 40);
            this.txtQuantidade.TabIndex = 5;
            // 
            // dgvItensVenda
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvItensVenda.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItensVenda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvItensVenda.ColumnHeadersHeight = 35;
            this.dgvItensVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItensVenda.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvItensVenda.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvItensVenda.Location = new System.Drawing.Point(66, 189);
            this.dgvItensVenda.Name = "dgvItensVenda";
            this.dgvItensVenda.ReadOnly = true;
            this.dgvItensVenda.RowHeadersVisible = false;
            this.dgvItensVenda.RowHeadersWidth = 51;
            this.dgvItensVenda.RowTemplate.Height = 24;
            this.dgvItensVenda.Size = new System.Drawing.Size(885, 327);
            this.dgvItensVenda.TabIndex = 6;
            this.dgvItensVenda.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvItensVenda.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvItensVenda.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvItensVenda.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvItensVenda.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvItensVenda.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvItensVenda.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvItensVenda.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(138)))));
            this.dgvItensVenda.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvItensVenda.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvItensVenda.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvItensVenda.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvItensVenda.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvItensVenda.ThemeStyle.ReadOnly = true;
            this.dgvItensVenda.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvItensVenda.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvItensVenda.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvItensVenda.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvItensVenda.ThemeStyle.RowsStyle.Height = 24;
            this.dgvItensVenda.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.dgvItensVenda.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnFinalizarVenda
            // 
            this.btnFinalizarVenda.BorderRadius = 10;
            this.btnFinalizarVenda.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFinalizarVenda.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFinalizarVenda.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFinalizarVenda.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFinalizarVenda.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(156)))), ((int)(((byte)(138)))));
            this.btnFinalizarVenda.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold);
            this.btnFinalizarVenda.ForeColor = System.Drawing.Color.White;
            this.btnFinalizarVenda.Location = new System.Drawing.Point(772, 522);
            this.btnFinalizarVenda.Name = "btnFinalizarVenda";
            this.btnFinalizarVenda.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnFinalizarVenda.Size = new System.Drawing.Size(170, 37);
            this.btnFinalizarVenda.TabIndex = 7;
            this.btnFinalizarVenda.Text = "Conclui a venda";
            this.btnFinalizarVenda.Click += new System.EventHandler(this.btnFinalizarVenda_Click);
            // 
            // lblTotalVenda
            // 
            this.lblTotalVenda.AutoSize = true;
            this.lblTotalVenda.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalVenda.Font = new System.Drawing.Font("Poppins", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVenda.Location = new System.Drawing.Point(64, 522);
            this.lblTotalVenda.Name = "lblTotalVenda";
            this.lblTotalVenda.Size = new System.Drawing.Size(64, 48);
            this.lblTotalVenda.TabIndex = 8;
            this.lblTotalVenda.Text = "0,0";
            // 
            // btnAdicionarItem
            // 
            this.btnAdicionarItem.BorderRadius = 10;
            this.btnAdicionarItem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdicionarItem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdicionarItem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdicionarItem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdicionarItem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(227)))), ((int)(((byte)(215)))));
            this.btnAdicionarItem.Font = new System.Drawing.Font("Poppins", 8F, System.Drawing.FontStyle.Bold);
            this.btnAdicionarItem.ForeColor = System.Drawing.Color.Black;
            this.btnAdicionarItem.Location = new System.Drawing.Point(819, 142);
            this.btnAdicionarItem.Name = "btnAdicionarItem";
            this.btnAdicionarItem.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAdicionarItem.Size = new System.Drawing.Size(132, 37);
            this.btnAdicionarItem.TabIndex = 10;
            this.btnAdicionarItem.Text = "Adicionar";
            this.btnAdicionarItem.Click += new System.EventHandler(this.btnAdicionarItem_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Poppins SemiBold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(67, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(245, 25);
            this.label9.TabIndex = 11;
            this.label9.Text = "Gerencie os pedidos dos clientes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Poppins", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(64, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 48);
            this.label7.TabIndex = 12;
            this.label7.Text = "Venda";
            // 
            // FormVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 561);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAdicionarItem);
            this.Controls.Add(this.lblTotalVenda);
            this.Controls.Add(this.btnFinalizarVenda);
            this.Controls.Add(this.dgvItensVenda);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.cmbProdutos);
            this.Controls.Add(this.cmbClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVenda";
            this.Text = "Vendas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensVenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cmbClientes;
        private Guna.UI2.WinForms.Guna2ComboBox cmbProdutos;
        private Guna.UI2.WinForms.Guna2TextBox txtQuantidade;
        private Guna.UI2.WinForms.Guna2DataGridView dgvItensVenda;
        private Guna.UI2.WinForms.Guna2Button btnFinalizarVenda;
        private System.Windows.Forms.Label lblTotalVenda;
        private Guna.UI2.WinForms.Guna2Button btnAdicionarItem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
    }
}