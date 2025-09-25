using MySqlConnector;
using System;
using System.Data;

namespace projeto_academia.Model
{
    public class Pagamentos
    {
        public int IdPagamento { get; set; }
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

        public bool CadastrarPagamento()
        {
            string comando = "INSERT INTO pagamentos (id_aluno, valor, data_pagamento, metodo, status_pagamento) " +
                             "VALUES (@id_aluno, @valor, @data_pagamento, @metodo, @status)";

            Banco conexaoBD = new Banco();
            MySqlConnection? con = conexaoBD.ObterConexao();
            if (con == null) return false;

            using (MySqlCommand cmd = new MySqlCommand(comando, con))
            {
                cmd.Parameters.AddWithValue("@id_aluno", IdAluno);
                cmd.Parameters.AddWithValue("@valor", Valor);
                cmd.Parameters.AddWithValue("@data_pagamento", DataPagamento == default ? DateTime.Now : DataPagamento);
                cmd.Parameters.AddWithValue("@metodo", Metodo);
                cmd.Parameters.AddWithValue("@status", StatusPagamento ? 1 : 0);

                cmd.Prepare();
                try
                {
                    int rows = cmd.ExecuteNonQuery();
                    conexaoBD.Desconectar(con);
                    return rows > 0;
                }
                catch
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
            }
        }

        public bool ApagarPagamento()
        {
            string comando = "DELETE FROM pagamentos WHERE id_pagamento = @id";

            Banco conexaoBD = new Banco();
            MySqlConnection? con = conexaoBD.ObterConexao();
            if (con == null) return false;

            using (MySqlCommand cmd = new MySqlCommand(comando, con))
            {
                cmd.Parameters.AddWithValue("@id", IdPagamento);
                cmd.Prepare();
                try
                {
                    int rows = cmd.ExecuteNonQuery();
                    conexaoBD.Desconectar(con);
                    return rows > 0;
                }
                catch
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
            }
        }
    }
}

