namespace SteamMarketHelper
{
    partial class MainWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.dataGridViewItems = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewLinkColumn();
            this.PrecoMedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EncomendaAlta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UltimaVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelFundo = new System.Windows.Forms.Panel();
            this.buttonOportunidade = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonExcluirItem = new System.Windows.Forms.Button();
            this.buttonNovoItem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).BeginInit();
            this.panelFundo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewItems
            // 
            this.dataGridViewItems.AllowUserToAddRows = false;
            this.dataGridViewItems.AllowUserToDeleteRows = false;
            this.dataGridViewItems.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dataGridViewItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewItems.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.PrecoMedio,
            this.EncomendaAlta,
            this.UltimaVenda,
            this.DataVenda});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewItems.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewItems.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewItems.Location = new System.Drawing.Point(0, 48);
            this.dataGridViewItems.MultiSelect = false;
            this.dataGridViewItems.Name = "dataGridViewItems";
            this.dataGridViewItems.ReadOnly = true;
            this.dataGridViewItems.RowHeadersVisible = false;
            this.dataGridViewItems.Size = new System.Drawing.Size(648, 284);
            this.dataGridViewItems.TabIndex = 0;
            this.dataGridViewItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewItems_CellContentClick);
            // 
            // Nome
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.Nome.DefaultCellStyle = dataGridViewCellStyle3;
            this.Nome.FillWeight = 172.144F;
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Nome.Width = 216;
            // 
            // PrecoMedio
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.PrecoMedio.DefaultCellStyle = dataGridViewCellStyle4;
            this.PrecoMedio.FillWeight = 62.59047F;
            this.PrecoMedio.HeaderText = "Preço Médio";
            this.PrecoMedio.Name = "PrecoMedio";
            this.PrecoMedio.ReadOnly = true;
            this.PrecoMedio.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PrecoMedio.Width = 90;
            // 
            // EncomendaAlta
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.EncomendaAlta.DefaultCellStyle = dataGridViewCellStyle5;
            this.EncomendaAlta.FillWeight = 105.2827F;
            this.EncomendaAlta.HeaderText = "Encomenda mais Alta";
            this.EncomendaAlta.Name = "EncomendaAlta";
            this.EncomendaAlta.ReadOnly = true;
            this.EncomendaAlta.Width = 135;
            // 
            // UltimaVenda
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.UltimaVenda.DefaultCellStyle = dataGridViewCellStyle6;
            this.UltimaVenda.FillWeight = 76.55838F;
            this.UltimaVenda.HeaderText = "Última Venda";
            this.UltimaVenda.Name = "UltimaVenda";
            this.UltimaVenda.ReadOnly = true;
            this.UltimaVenda.ToolTipText = "Considera apenas a última venda nos últimos 7 dias";
            this.UltimaVenda.Width = 97;
            // 
            // DataVenda
            // 
            this.DataVenda.FillWeight = 83.42449F;
            this.DataVenda.HeaderText = "Data Venda";
            this.DataVenda.Name = "DataVenda";
            this.DataVenda.ReadOnly = true;
            this.DataVenda.Width = 107;
            // 
            // panelFundo
            // 
            this.panelFundo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFundo.Controls.Add(this.buttonOportunidade);
            this.panelFundo.Controls.Add(this.buttonRefresh);
            this.panelFundo.Controls.Add(this.buttonExcluirItem);
            this.panelFundo.Controls.Add(this.buttonNovoItem);
            this.panelFundo.Controls.Add(this.dataGridViewItems);
            this.panelFundo.Location = new System.Drawing.Point(12, 0);
            this.panelFundo.Name = "panelFundo";
            this.panelFundo.Size = new System.Drawing.Size(648, 332);
            this.panelFundo.TabIndex = 1;
            // 
            // buttonOportunidade
            // 
            this.buttonOportunidade.BackColor = System.Drawing.Color.Transparent;
            this.buttonOportunidade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOportunidade.FlatAppearance.BorderSize = 0;
            this.buttonOportunidade.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonOportunidade.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonOportunidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOportunidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOportunidade.Image = ((System.Drawing.Image)(resources.GetObject("buttonOportunidade.Image")));
            this.buttonOportunidade.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOportunidade.Location = new System.Drawing.Point(369, 10);
            this.buttonOportunidade.Name = "buttonOportunidade";
            this.buttonOportunidade.Size = new System.Drawing.Size(180, 32);
            this.buttonOportunidade.TabIndex = 4;
            this.buttonOportunidade.Text = "Encontrar oportunidade...";
            this.buttonOportunidade.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonOportunidade.UseVisualStyleBackColor = false;
            this.buttonOportunidade.Click += new System.EventHandler(this.buttonOportunidade_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.Transparent;
            this.buttonRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRefresh.FlatAppearance.BorderSize = 0;
            this.buttonRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.Image = ((System.Drawing.Image)(resources.GetObject("buttonRefresh.Image")));
            this.buttonRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRefresh.Location = new System.Drawing.Point(237, 10);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(126, 32);
            this.buttonRefresh.TabIndex = 3;
            this.buttonRefresh.Text = "Atualizar tabela";
            this.buttonRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonExcluirItem
            // 
            this.buttonExcluirItem.BackColor = System.Drawing.Color.Transparent;
            this.buttonExcluirItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExcluirItem.FlatAppearance.BorderSize = 0;
            this.buttonExcluirItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonExcluirItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonExcluirItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExcluirItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcluirItem.Image = ((System.Drawing.Image)(resources.GetObject("buttonExcluirItem.Image")));
            this.buttonExcluirItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExcluirItem.Location = new System.Drawing.Point(116, 10);
            this.buttonExcluirItem.Name = "buttonExcluirItem";
            this.buttonExcluirItem.Size = new System.Drawing.Size(115, 32);
            this.buttonExcluirItem.TabIndex = 2;
            this.buttonExcluirItem.Text = "Excluir Item...";
            this.buttonExcluirItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonExcluirItem.UseVisualStyleBackColor = false;
            this.buttonExcluirItem.Click += new System.EventHandler(this.buttonExcluirItem_Click);
            // 
            // buttonNovoItem
            // 
            this.buttonNovoItem.BackColor = System.Drawing.Color.Transparent;
            this.buttonNovoItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNovoItem.FlatAppearance.BorderSize = 0;
            this.buttonNovoItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonNovoItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonNovoItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNovoItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNovoItem.Image = ((System.Drawing.Image)(resources.GetObject("buttonNovoItem.Image")));
            this.buttonNovoItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNovoItem.Location = new System.Drawing.Point(3, 10);
            this.buttonNovoItem.Name = "buttonNovoItem";
            this.buttonNovoItem.Size = new System.Drawing.Size(107, 32);
            this.buttonNovoItem.TabIndex = 1;
            this.buttonNovoItem.Text = "Novo Item...";
            this.buttonNovoItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonNovoItem.UseVisualStyleBackColor = false;
            this.buttonNovoItem.Click += new System.EventHandler(this.buttonNovoItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(673, 343);
            this.Controls.Add(this.panelFundo);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Steam Market Helper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).EndInit();
            this.panelFundo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewItems;
        private System.Windows.Forms.Panel panelFundo;
        private System.Windows.Forms.Button buttonNovoItem;
        private System.Windows.Forms.Button buttonExcluirItem;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonOportunidade;
        private System.Windows.Forms.DataGridViewLinkColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoMedio;
        private System.Windows.Forms.DataGridViewTextBoxColumn EncomendaAlta;
        private System.Windows.Forms.DataGridViewTextBoxColumn UltimaVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataVenda;
    }
}

