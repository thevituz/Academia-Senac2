using System;
using System.Data;
using MySqlConnector;

namespace projeto_academia.Model
{
    public class Pagamento
    {
        public int IdPagamento { get; set; }
        public int IdAluno { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataPagamento { get; set; }
        public string Metodo { get; set; } = string.Empty;

        // Listar pagamentos
        public DataTable ListarPagamentos()
        {
            string comando = "SELECT id_pagamento, id_aluno, valor, data_pagamento, metodo FROM pagamentos";

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

        // Cadastrar pagamento
        public bool CadastrarPagamento()
        {
            string comando = "INSERT INTO pagamentos (id_aluno, valor, metodo) VALUES (@id_aluno, @valor, @metodo)";

            Banco conexaoBD = new Banco();
            MySqlConnection? con = conexaoBD.ObterConexao();
            if (con == null) return false;

            using (MySqlCommand cmd = new MySqlCommand(comando, con))
            {
                cmd.Parameters.AddWithValue("@id_aluno", IdAluno);
                cmd.Parameters.AddWithValue("@valor", Valor);
                cmd.Parameters.AddWithValue("@metodo", Metodo);

                cmd.Prepare();

                try
                {
                    int affected = cmd.ExecuteNonQuery();
                    conexaoBD.Desconectar(con);
                    return affected > 0;
                }
                catch
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
            }
        }

        // Apagar pagamento
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
                    int affected = cmd.ExecuteNonQuery();
                    conexaoBD.Desconectar(con);
                    return affected > 0;
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
