using projeto_academia.Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace projeto_academia
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Show();
            this.Hide();
        }

        private void CarregarDados()
        {
            try
            {
                var pagModel = new Pagamentos();

                DataTable emDia = pagModel.ListarPagamentosEmDia();
                if (this.Controls.ContainsKey("dgvPagamentosEmDia"))
                    dgvPagamentosEmDia.DataSource = emDia;

                DataTable pendentes = pagModel.ListarPagamentosPendentes();
                if (this.Controls.ContainsKey("dgvPagamentosPendentes"))
                    dgvPagamentosPendentes.DataSource = pendentes;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os dados: " + ex.Message);
            }
        }
    }
}
