using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SorteioAleatorio
{
    public partial class Form1 : Form
    {
        private static List<string> lstParticipants;
        private static List<string> lstWinners;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BtnAddParticipante.Enabled = true;
            BtnLimparParticipantes.Enabled = false;
            BtnLimparGanhadores.Enabled = false;
            BtnSortearGanhador.Enabled = false;
            lstParticipants = new List<string>();
            lstWinners = new List<string>();
        }

        private void BtnAddParticipante_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtAddParticipante.Text.Trim()))
            {
                if (!this.ExistsParticipant(TxtAddParticipante.Text.Trim()))
                {
                    lstParticipants.Add(TxtAddParticipante.Text.Trim());
                    listBoxParticipantes.Items.Add(TxtAddParticipante.Text.Trim());
                    BtnLimparParticipantes.Enabled = true;
                    BtnSortearGanhador.Enabled = true;
                    TxtAddParticipante.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("O participante já está na lista");
                }
            }
            else
            {
                MessageBox.Show("Favor informar o nome do particpante!");
            }
        }

        private void BtnLimparParticipantes_Click(object sender, EventArgs e)
        {
            this.CleanParticipants();
        }

        private void CleanParticipants()
        {
            listBoxParticipantes.Items.Clear();
            TxtAddParticipante.Text = string.Empty;
            lstParticipants.Clear();
            BtnLimparParticipantes.Enabled = false;
        }

        private void CleanWinners()
        {
            ListBoxGanhadores.Items.Clear();
            lstWinners.Clear();
            this.BtnLimparGanhadores.Enabled = false;
        }

        private bool ExistsParticipant(string participante)
        {
            if (lstParticipants.IndexOf(participante.Trim()) > -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool ExistsWinner(string participante)
        {
            if (lstWinners.IndexOf(participante.Trim()) > -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void BtnLimparGanhadores_Click(object sender, EventArgs e)
        {
            this.CleanWinners();
        }

        private void Sort()
        {
            try
            {
                if (this.ValidateSort())
                {
                    bool isAdded = false;
                    do
                    {
                        Random randNum = new Random();
                        var ret = randNum.Next(0, lstParticipants.Count());
                        if (!this.ExistsWinner(lstParticipants[ret]))
                        {
                            isAdded = true;
                            lstWinners.Add(lstParticipants[ret]);
                            this.ListBoxGanhadores.Items.Add(lstParticipants[ret]);
                        }
                    } while (!isAdded);
                    this.BtnLimparGanhadores.Enabled = true;
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um erro ao evetivar o sorteio: \n" + ex.Message);
            }
        }

        private bool SortWinner(int numberOfParticipant)
        {
            if (!this.ExistsWinner(lstParticipants[numberOfParticipant]))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void BtnSortearGanhador_Click(object sender, EventArgs e)
        {
            this.Sort();
        }

        private bool ValidateSort()
        {
            bool isValid = true;

            if (lstParticipants.Count() < 1)
            {
                MessageBox.Show("Favor adicionar participantes ao sorteio");
                isValid = false;
            }

            if (lstParticipants.Count() > 0 && lstParticipants.Count() == lstWinners.Count())
            {
                MessageBox.Show("Não existem mais participantes a serem sorteados");
                isValid = false;
            }

            return isValid;
        }
    }
}
