namespace projeto_academia
{
    partial class Form5
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblEmDia;
        private System.Windows.Forms.Label lblPendentes;
        private System.Windows.Forms.DataGridView dgvPagamentosEmDia;
        private System.Windows.Forms.DataGridView dgvPagamentosPendentes;
        private System.Windows.Forms.Button btnVoltar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblEmDia = new Label();
            lblPendentes = new Label();
            dgvPagamentosEmDia = new DataGridView();
            dgvPagamentosPendentes = new DataGridView();
            btnVoltar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPagamentosEmDia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPagamentosPendentes).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.Location = new Point(260, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(235, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Relatório de Pagamentos";
            // 
            // lblEmDia
            // 
            lblEmDia.AutoSize = true;
            lblEmDia.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEmDia.Location = new Point(120, 70);
            lblEmDia.Name = "lblEmDia";
            lblEmDia.Size = new Size(143, 19);
            lblEmDia.TabIndex = 1;
            lblEmDia.Text = "Pagamentos em Dia";
            // 
            // lblPendentes
            // 
            lblPendentes.AutoSize = true;
            lblPendentes.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPendentes.Location = new Point(480, 70);
            lblPendentes.Name = "lblPendentes";
            lblPendentes.Size = new Size(165, 19);
            lblPendentes.TabIndex = 2;
            lblPendentes.Text = "Pagamentos Pendentes";
            // 
            // dgvPagamentosEmDia
            // 
            dgvPagamentosEmDia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPagamentosEmDia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPagamentosEmDia.Location = new Point(40, 100);
            dgvPagamentosEmDia.MultiSelect = false;
            dgvPagamentosEmDia.Name = "dgvPagamentosEmDia";
            dgvPagamentosEmDia.ReadOnly = true;
            dgvPagamentosEmDia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPagamentosEmDia.Size = new Size(340, 300);
            dgvPagamentosEmDia.TabIndex = 3;
            // 
            // dgvPagamentosPendentes
            // 
            dgvPagamentosPendentes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPagamentosPendentes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPagamentosPendentes.Location = new Point(420, 100);
            dgvPagamentosPendentes.MultiSelect = false;
            dgvPagamentosPendentes.Name = "dgvPagamentosPendentes";
            dgvPagamentosPendentes.ReadOnly = true;
            dgvPagamentosPendentes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPagamentosPendentes.Size = new Size(340, 300);
            dgvPagamentosPendentes.TabIndex = 4;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(350, 420);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(100, 36);
            btnVoltar.TabIndex = 5;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // Form5
            // 
            BackgroundImage = Properties.Resources._5153829;
            ClientSize = new Size(800, 480);
            Controls.Add(lblTitulo);
            Controls.Add(lblEmDia);
            Controls.Add(lblPendentes);
            Controls.Add(dgvPagamentosEmDia);
            Controls.Add(dgvPagamentosPendentes);
            Controls.Add(btnVoltar);
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Relatório de Pagamentos";
            Load += Form5_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPagamentosEmDia).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPagamentosPendentes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
