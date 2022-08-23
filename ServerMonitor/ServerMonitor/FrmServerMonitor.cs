using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ServerMonitor
{
    public partial class FrmServerMonitor : Form
    {
        //int contador = 0;
        public FrmServerMonitor()
        {
            InitializeComponent();
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            IList<Maquina> maquinaLista = new List<Maquina>();
            DriveInfo[] allDrives = DriveInfo.GetDrives();


            foreach (DriveInfo d in allDrives)
            {

                Maquina maquina = new Maquina();
                maquina.Drive = String.Format("{0} ", d.Name);
                maquina.Tipo = String.Format("{0} ", d.DriveType);


                if (d.IsReady == true)
                {
                    maquina.Volume = String.Format("{0} ", d.VolumeLabel).ToString();
                    maquina.Formato = String.Format("{0} ", d.DriveFormat).ToString();
                    maquina.Espaco_usado = String.Format("{0,15} GB", (((d.TotalSize - d.TotalFreeSpace) / 1024) / 1024) / 1024);
                    maquina.Espaco_livre = String.Format("{0,15} GB", ((d.TotalFreeSpace / 1024) / 1024) / 1024);
                    maquina.Capacidade = String.Format("{0,15} GB", ((d.TotalSize / 1024) / 1024) / 1024);

                }
                maquinaLista.Add(maquina);

            }


            dgMapeamentos.DataSource = maquinaLista;
            dgMapeamentos.Refresh();
            lblTotal.Text = dgMapeamentos.Rows.Count.ToString();
            //lblAnalisar.Text = contador.ToString();





        }

        private void dgMapeamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            int linha = dgMapeamentos.CurrentRow.Index;


            if (dgMapeamentos["Tipo", linha].Value.ToString().Trim() == "CDRom")
            {
                LimpaTela();
                return;
            }
            if (dgMapeamentos["Espaco_usado", linha].Value.ToString().Contains("-"))
            {
                LimpaTela();
                MessageBox.Show("Valor Negativo - A capacidade possivelmente é cota individual por usuário.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            else
            {

                lblDrive.Text = dgMapeamentos["Drive", linha].Value.ToString().Trim();
                lblTipo.Text = dgMapeamentos["Tipo", linha].Value.ToString().Trim();
                lblEspacoUsado.Text = dgMapeamentos["Espaco_usado", linha].Value.ToString().Trim();
                lblEspacoLivre.Text = dgMapeamentos["Espaco_livre", linha].Value.ToString().Trim();
                lblCapacidade.Text = dgMapeamentos["Capacidade", linha].Value.ToString().Trim();

                //verificar formato para alterar imagem
                if (lblTipo.Text == "Network")
                {
                    pictureBox1.Image = Properties.Resources.rede;
                }
                else if (lblTipo.Text == "Fixed")
                {
                    pictureBox1.Image = Properties.Resources.hd;
                }
                else if (lblTipo.Text == "Removable")
                {
                    pictureBox1.Image = Properties.Resources.removivel;
                }

                //alterar barra de progresso
                PgEspaco.Visible = true;
                PgEspaco.Maximum = Convert.ToInt32((lblCapacidade.Text.Trim()).Substring(0, (lblCapacidade.Text.ToString().TrimStart().TrimEnd()).Length - 3));
                PgEspaco.Value = Convert.ToInt32((lblEspacoUsado.Text.Trim()).Substring(0, (lblEspacoUsado.Text.ToString().TrimStart().TrimEnd()).Length - 3));
                lblUso.Visible = true;
                lblPorcentagem.Visible = true;
                lblPorcentagem.Text = ((PgEspaco.Value * 100) / PgEspaco.Maximum).ToString() + " %";


            }
        }


        public void LimpaTela()
        {
            lblDrive.Text = "";
            lblTipo.Text = "";
            lblVolume.Text = "";
            lblFormato.Text = "";
            lblEspacoUsado.Text = "";
            lblEspacoLivre.Text = "";
            lblCapacidade.Text = "";
            PgEspaco.Visible = false;
            lblUso.Visible = false;
            lblPorcentagem.Visible = false;
            pictureBox1.Image = Properties.Resources._default;
        }


        private void FrmServerMonitor_Load(object sender, EventArgs e)
        {

            dgMapeamentos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            lblTotal.Text = dgMapeamentos.Rows.Count.ToString();
        }

        private void dgMapeamentos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (e.Value != null && e.ColumnIndex == 5)
            {
                int espacoLivre = Convert.ToInt32((e.Value.ToString().Trim()).Substring(0, (e.Value.ToString().TrimStart().TrimEnd()).Length - 3));

                if (espacoLivre <= 10)
                {
                   // contador = contador + 1;
                    int linha = e.RowIndex;
                    e.CellStyle.ForeColor = Color.Red;
                    dgMapeamentos.Rows[linha].Cells[5].Style.ForeColor = Color.Red;

                }


            }



        }

    }


}




