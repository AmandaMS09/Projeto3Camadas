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

        }

        public void Excluir(TimeDTO dto)
        {

        }

        public void Listar()
        {

        }
    }
}
