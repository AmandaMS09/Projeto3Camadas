using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Projeto3Camadas.Code.BLL;
using Projeto3Camadas.Code.DTO;

namespace Projeto3Camadas
{
    public partial class FrmCadastro : Form
    {
        CadastroBLL bll = new CadastroBLL();
        CadastroDTO dto = new CadastroDTO();

        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            dto.Email = txt_email.Text;
            dto.Senha = txt_senha.Text;

            if(bll.RealizarLogin(dto) == true)
            {
                Ui.FrmTime frm_time = new Ui.FrmTime();
                frm_time.ShowDialog();
            }else
            {
                MessageBox.Show("Verifique email e senha inseridos!", "Erro");
            }
        }
    }
}
