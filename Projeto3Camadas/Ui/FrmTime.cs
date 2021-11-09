using System;
using System.Data;
using System.Windows.Forms;

using Projeto3Camadas.Code.BLL;
using Projeto3Camadas.Code.DTO;

namespace Projeto3Camadas.Ui
{
    public partial class FrmTime : Form
    {
        TimeBLL bll = new TimeBLL();
        TimeDTO dto = new TimeDTO();

        public FrmTime()
        {
            InitializeComponent();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            //Atribuindo os valores
            dto.Nome = txt_nome.Text;
            dto.Presidente = txt_presidente.Text;
            dto.Data_fundacao = dtp_dataFundacao.Value.ToString();
            dto.Historia = txt_historia.Text;

            //Jogando o objeto para ser inserido no banco de dados
            bll.Inserir(dto);

            //Mensagem de sucesso
            MessageBox.Show("Cadastrado com sucesso!", "Times");

            //Limpando as caixas de texto
            txt_nome.Clear();
            txt_presidente.Clear();
            dtp_dataFundacao.ResetText();
            txt_historia.Clear();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {

        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {

        }
    }
}
