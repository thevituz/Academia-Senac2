using MySqlConnector;
using System;
using System.Data;

namespace projeto_academia.Model
{
    public class Pagamentos
    {
        public int Id { get; set; }
        public int IdAluno { get; set; }
        public DateTime DataPagamento { get; set; }
        public decimal Valor { get; set; }
        public string Metodo { get; set; } = string.Empty;
        public bool StatusPagamento { get; set; } // true = em dia, false = pendente

        // Lista pagamentos em dia
        public DataTable ListarPagamentosEmDia()
        {
            string comando = @"
        SELECT p.id_pagamento, a.id_aluno, a.nome, p.valor, p.data_pagamento, p.metodo
        FROM pagamentos p
        INNER JOIN aluno a ON p.id_aluno = a.id_aluno";
       
            Banco conexaoBD = new Banco();
            MySqlConnection? con = conexaoBD.ObterConexao();
            DataTable tabela = new DataTable();
            if (con == null) return tabela;

            using (MySqlCommand cmd = new MySqlCommand(comando, con))
            {
                cmd.Prepare();
                tabela.Load(cmd.ExecuteReader());
            }

            conexaoBD.Desconectar(con);
            return tabela;
        }

        // Lista pagamentos pendentes
        public DataTable ListarPagamentosPendentes()
        {
            string comando = @"
        SELECT p.id_pagamento, a.id_aluno, a.nome, p.valor, p.data_pagamento, p.metodo
        FROM pagamentos p
        INNER JOIN aluno a ON p.id_aluno = a.id_aluno";
       

            Banco conexaoBD = new Banco();
            MySqlConnection? con = conexaoBD.ObterConexao();
            DataTable tabela = new DataTable();
            if (con == null) return tabela;

            using (MySqlCommand cmd = new MySqlCommand(comando, con))
            {
                cmd.Prepare();
                tabela.Load(cmd.ExecuteReader());
            }

            conexaoBD.Desconectar(con);
            return tabela;
        }
    }   
}
