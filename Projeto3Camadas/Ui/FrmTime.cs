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

            //Atualização do GridView
            dgv_listaTimes.DataSource = bll.Listar();

            //Limpando as caixas de texto
            txt_id.Clear();
            txt_nome.Clear();
            txt_presidente.Clear();
            dtp_dataFundacao.ResetText();
            txt_historia.Clear();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            //Atribuindo os valores
            dto.Id = int.Parse(txt_id.Text);
            dto.Nome = txt_nome.Text;
            dto.Presidente = txt_presidente.Text;
            dto.Data_fundacao = dtp_dataFundacao.Value.ToString();
            dto.Historia = txt_historia.Text;

            //Jogando o objeto para ser inserido no banco de dados
            bll.Editar(dto);

            //Mensagem de sucesso
            MessageBox.Show("Alterado com sucesso!", "Times");

            //Atualização do GridView
            dgv_listaTimes.DataSource = bll.Listar();

            //Limpando as caixas de texto
            txt_id.Clear();
            txt_nome.Clear();
            txt_presidente.Clear();
            dtp_dataFundacao.ResetText();
            txt_historia.Clear();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            //Jogando o id do objeto a ser excluído
            dto.Id = int.Parse(txt_id.Text);

            bll.Excluir(dto);

            //Mensagem de sucesso
            MessageBox.Show("Excluído com sucesso!", "Times");

            //Atualização do GridView
            dgv_listaTimes.DataSource = bll.Listar();

            //Limpando as caixas de texto
            txt_id.Clear();
            txt_nome.Clear();
            txt_presidente.Clear();
            dtp_dataFundacao.ResetText();
            txt_historia.Clear();
        }

        private void FrmTime_Load(object sender, EventArgs e)
        {
            dgv_listaTimes.DataSource = bll.Listar();
        }

        private void dgv_listaTimes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dgv_listaTimes.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_nome.Text = dgv_listaTimes.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_presidente.Text = dgv_listaTimes.Rows[e.RowIndex].Cells[2].Value.ToString();
            dtp_dataFundacao.Value = Convert.ToDateTime(dgv_listaTimes.Rows[e.RowIndex].Cells[3].Value);
            txt_historia.Text = dgv_listaTimes.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
    }
}
