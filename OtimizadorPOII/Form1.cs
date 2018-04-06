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

        

        private void calcular_Click(object sender, EventArgs e)
        {

            // cálculo do método de extensão mínima

            if ( extensaominima.Checked ) {

                bool boo;
                bool aux;
                int menorpos;
                int menorval;
                string sol = "";
                int i, p;
                int z = 0;
                int[] caminho = new int[Convert.ToInt32(tablesize.Value)];
                int[,] cp = new int[Convert.ToInt32(tablesize.Value), Convert.ToInt32(tablesize.Value)];

                // zerando os caminhos e tirando uma cópia da matriz original dos valores
                for (i = 0; i < Convert.ToInt32(tablesize.Value); i++)
                {
                    caminho[i] = -1;

                    for (p=0;p< Convert.ToInt32(tablesize.Value); p++)
                    {
                        cp[i,p] = Convert.ToInt32(tabeladados.Rows[i].Cells[p].Value);
                    }
                }
                
                for ( i = 0; i < Convert.ToInt32(tablesize.Value)-1; i++)
                {
                    menorpos = 0;
                    menorval = Convert.ToInt32(tabeladados.Rows[i].Cells[0].Value);

                    boo = true ;

                    while (boo) {

                        // verificando qual o menor valor da linha i
                        for (p = 0 ; p < Convert.ToInt32(tablesize.Value); p++)
                        {
                            
                                if ( Convert.ToInt32(tabeladados.Rows[i].Cells[p].Value) < menorval)
                                {
                                    menorpos = p;
                                    menorval = Convert.ToInt32(tabeladados.Rows[i].Cells[p].Value);

                                }

                        }

                        aux = true; 

                            // caso o caminho inverso seja realizado, ignorar esse valor, tornando ele inviável
                            if ( caminho[menorpos] == i  )
                            {
                                tabeladados.Rows[i].Cells[menorpos].Value = 1000000000;
                                aux = false;
                                menorpos = 0;
                                menorval = 1000000000;
                            }
                                
                        if (aux)
                        {
                            // atribuindo o caminho
                            caminho[i] = menorpos;
                            boo = false;

                        }
                     
                    }

                    
                }

                // escrevendo o percurso no label
                for (i=0; i < Convert.ToInt32(tablesize.Value) - 1; i++)
                {
                    sol = sol + Environment.NewLine + i.ToString() + " -> " + caminho[i];
                }

                ligacao.Text = sol;

                // retornando os valores copiados para nao haver alterações em contas
                for (i = 0; i < Convert.ToInt32(tablesize.Value); i++)
                {
                    for (p = 0; p < Convert.ToInt32(tablesize.Value); p++)
                    {
                        tabeladados.Rows[i].Cells[p].Value = cp[i, p];
                    }
                }


                // somando os valores da tabela para o z*
                for ( i=0; i < Convert.ToInt32(tablesize.Value)-1; i++)
                {

                    z += Convert.ToInt32(tabeladados.Rows[i].Cells[caminho[i]].Value);
                }

                zmelhor.Text = z.ToString();
            }

            if (caixeiroviajante.Checked)
            {
                tabeladados.Rows[2].Cells[1].Value = 1000000000;

            }


        }
    }
}
