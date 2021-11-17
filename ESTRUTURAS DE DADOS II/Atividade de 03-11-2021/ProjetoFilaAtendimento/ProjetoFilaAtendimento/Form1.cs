using projFilaAtendimento.controller;
using projFilaAtendimento.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFilaAtendimento {
    public partial class FormAtendimento : Form {
        private Guiches listaGuiches;
        private Guiche guiche;
        private int numGuiche;
        private int numChamaGuiche;

        private Senhas listaSenhas;

        public FormAtendimento() {
            InitializeComponent();
            numGuiche = 0;
            listaSenhas = new Senhas();
            listaGuiches = new Guiches();
            guiche = new Guiche();
        }

        private void Btn_Gerar_Click(object sender, EventArgs e) {
            // Gerar Senha
            listaSenhas.gerar();
        }

        private void Btn_ListarSenhas_Click(object sender, EventArgs e) {
            // Listar Senhas
            ListBoxSenhas.Items.Clear();

            if (listaSenhas.FilaSenhas.Count >= 1) {
                ListBoxSenhas.Items.Add("--------------------------------------------------------------");
                ListBoxSenhas.Items.Add("  Senha\t| \tGerado");
                ListBoxSenhas.Items.Add("--------------------------------------------------------------");
                foreach (Senha s in listaSenhas.FilaSenhas) {
                    ListBoxSenhas.Items.Add(s.dadosParciais());
                }
            }
            else ListBoxSenhas.Items.Add("Lista de Senhas Vazia");
        }

        private void Btn_Adicionar_Click(object sender, EventArgs e) {
            // Adicionar Guichê
            numGuiche = numGuiche + 1;
            listaGuiches.adicionar(new Guiche(numGuiche));

            labelQuantidadeGuiches.Text = numGuiche.ToString();
        }

        private void Btn_Chamar_Click(object sender, EventArgs e) {
            // Chamar Senha para tal Guichê
            numChamaGuiche = int.Parse(textBoxGuiche.Text);
            Guiche gAchou = listaGuiches.ListaGuiches.Find(ga => ga.Id == numChamaGuiche);

            if (gAchou != null) gAchou.chamar(listaSenhas.FilaSenhas);
            else MessageBox.Show("Este Guiche não existe!");
        }

        private void Btn_ListarAtendimentos_Click(object sender, EventArgs e) {
            // Listar Atendimentos
            ListBoxAtendimentos.Items.Clear();

            if (listaGuiches.ListaGuiches[int.Parse(textBoxGuiche.Text) - 1].Atendimentos.Count >= 1) {
                ListBoxAtendimentos.Items.Add("--------------------------------------------------------------------------------------------------------------");
                ListBoxAtendimentos.Items.Add("  Senha\t|   \tGerado\t\t| \tAtendimento ");
                ListBoxAtendimentos.Items.Add("--------------------------------------------------------------------------------------------------------------");

                foreach (Senha s in listaGuiches.ListaGuiches[int.Parse(textBoxGuiche.Text) - 1].Atendimentos) {
                    ListBoxAtendimentos.Items.Add(s.dadosCompletos());
                }

            }
            else {
                ListBoxAtendimentos.Items.Add("Lista de Atendimentos Vazia");
            }
        }

        private void FormAtendimento_Load(object sender, EventArgs e) {

        }
    }
}
