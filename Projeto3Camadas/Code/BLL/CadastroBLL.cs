using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using Projeto3Camadas.Code.DTO;
using Projeto3Camadas.Code.DAL;

namespace Projeto3Camadas.Code.BLL
{
    class CadastroBLL
    {
        AcessoBancoDados conexao = new AcessoBancoDados();
        string tabela = "usuario";

        public bool RealizarLogin(CadastroDTO login)
        {
            string sql = $"select * from {tabela} where email = '{login.Email}' and senha = '{login.Senha}';";
            DataTable dt = conexao.ExecutarConsulta(sql);

            if(dt.Rows.Count > 0)
            {
                return true;
            }else
            {
                return false;
            }
        }
    }
}
