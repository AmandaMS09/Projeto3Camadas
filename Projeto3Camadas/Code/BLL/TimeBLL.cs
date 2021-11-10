using System.Data;

using Projeto3Camadas.Code.DTO;
using Projeto3Camadas.Code.DAL;

namespace Projeto3Camadas.Code.BLL
{
    class TimeBLL
    {
        AcessoBancoDados conexao = new AcessoBancoDados();
        string tabela = "time";

        public void Inserir(TimeDTO dto)
        {
            string inserir = $"insert into {tabela} values(null,'{dto.Nome}','{dto.Presidente}','{dto.Data_fundacao}','{dto.Historia}')";
            conexao.ExecutarComando(inserir);
        }

        public void Editar(TimeDTO dto)
        {
            string alterar = $"update {tabela} set nome = '{dto.Nome}', presidente = '{dto.Presidente}', data_fundacao = '{dto.Data_fundacao}', historia = '{dto.Historia}' where id = '{dto.Id}';";
            conexao.ExecutarComando(alterar);
        }

        public void Excluir(TimeDTO dto)
        {
            string excluir = $"delete from {tabela} where id = '{dto.Id}';";
            conexao.ExecutarComando(excluir);
        }

        public DataTable Listar()
        {
            string sql = $"select * from {tabela} order by id;";
            return conexao.ExecutarConsulta(sql);
        }
    }
}
