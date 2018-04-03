using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtimizadorPOII
{
    public partial class Form1 : Form
    {
        // definição de variáveis globais

        int tamanhotabela;  // tamanho da tabela com os valores inseridos pelo usuário

        public Form1()
        {
            InitializeComponent();
        }


        // função executada quando o usuário clica no botão Gerar Tabela

        private void go_Click(object sender, EventArgs e)
        {
            // utilizado para que se removam todas as linhas e colunas caso o usuário deseje inserir outros valores, aumentar ou diminuir a tabela
            for (int p = 0; tabeladados.Columns.Count > p;)
            {
                tabeladados.Columns.RemoveAt(p);
            }


            // adiciona as linhas e colunas na tabela que será preenchida posteriormente
            int i;
            tamanhotabela = (int)tablesize.Value;

            for ( i = 0; i < tamanhotabela; i++)
            {
            DataGridViewTextBoxColumn columntype = new DataGridViewTextBoxColumn
                {
                Width = 80,
                HeaderText = i.ToString()
                };

                tabeladados.Columns.Add(columntype);
                
             }
                 tabeladados.Rows.Add(tamanhotabela);

            for (i = 0; i < tamanhotabela; i++)
            {
                tabeladados.Rows[i].HeaderCell.Value = i.ToString();

                // insere valores na tabela
                tabeladados.Rows[i].Cells[i].Value = 1000000000;
            }

            
        }
    }
}
