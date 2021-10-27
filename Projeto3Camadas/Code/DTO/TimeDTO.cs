using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto3Camadas.Code.DTO
{
    class TimeDTO
    {
        //Propriedades privadas
        private int _id;
        private string _nome;
        private string _presidente;
        private string _data_fundacao;
        private string _historia;

        //Métodos de encapsulamento (Ctrl+R+E)
        public int Id { get => _id; set => _id = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Presidente { get => _presidente; set => _presidente = value; }
        public string Data_fundacao { get => _data_fundacao; set => _data_fundacao = value; }
        public string Historia { get => _historia; set => _historia = value; }
    }
}
