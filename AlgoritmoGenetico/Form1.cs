using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmoGenetico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int Poblacion = Convert.ToInt32(tbPoblacion.Text);
            double sumatoria = 0;
           
            lbX.Items.Clear();
            lbIndividuos.Items.Clear();
            lbFx.Items.Clear();
            lbFnorm.Items.Clear();
            lbAcumulado.Items.Clear();
            lbPadres.Items.Clear();
            lbHijos.Items.Clear();
            if ((Poblacion % 2) == 0)
            {
                for (int i = 0; i < Poblacion; i++)
                {
                    string binario="";
                    for (int j=0;j<8;j++)//Generar numero binario aleatorio
                    {
                        int random = r.Next(0,2);
                        binario = binario + Convert.ToString(random);
                    }                      
                    lbIndividuos.Items.Add(binario);
                    int x = Convert.ToInt16(binario,2);//Binario a decimal
                    lbX.Items.Add(x);//Inicializar Población
                    
                    double fx = Math.Sin(Math.PI * x / 256); //Calcular aptitud 
                    lbFx.Items.Add(fx);
                    sumatoria = sumatoria + Convert.ToDouble(fx);
                }
                lbSumatoria.Text = Convert.ToString(sumatoria);
                double acumulado=0;
                for (int i = 0; i < Poblacion; i++)
                {          
                    lbFx.SelectedIndex = i;//calcular fnorm
                    lbFnorm.Items.Add(Convert.ToDouble(lbFx.SelectedItem) / sumatoria);
                    lbFnorm.SelectedIndex = i;
                    acumulado = acumulado + Convert.ToDouble(lbFnorm.SelectedItem);//Calcular acumulado de fnorm
                    lbAcumulado.Items.Add(Convert.ToString(acumulado));
                }
                /*sumatoria = 0;
                for (int i = 0; i < Poblacion; i++)
                {
                    lbFnorm.SelectedIndex = i;
                    sumatoria = sumatoria + Convert.ToDouble(lbFnorm.SelectedItem);
                    lbAcumulado.Items.Add(Convert.ToString(sumatoria));            
                }*/
                lbSumatoriaNorm.Text = Convert.ToString(acumulado);   
                for (int i=0;i<Poblacion;i++) //seleccion por ruleta
                {
                    double random = r.NextDouble();//Numero random entre 0 y 1
                    for(int j=0;j<Poblacion;j++)
                    {
                        lbAcumulado.SelectedIndex = j;
                        if(Convert.ToDouble(lbAcumulado.SelectedItem)>random)
                        {
                            lbIndividuos.SelectedIndex = j;
                            lbPadres.Items.Add(lbIndividuos.SelectedItem);
                            j = Poblacion;
                        }
                    }
                }                
            }
            else
            {
                 MessageBox.Show ("Ingresar numero par en la población", "Algoritmo Genético",MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            ////////////Cruce//////////////////////////////
            String aux1="", aux2="";
            double cruce;
            int pcrt1,pcrt2;

            for(int i=0; i < Poblacion-1; i++)
            {
                cruce = r.NextDouble();
                if (cruce <= Convert.ToDouble(tbPC.Text))
                {
                    do
                    {
                        pcrt1 = r.Next(0, 8);//random de 0 a 7
                        pcrt2 = r.Next(0, 8);
                        //pcrt1 = 5;
                        //pcrt2 = 2;
                    } while (pcrt1==pcrt2);                    
                    //lbPadres.SelectedIndex = i;
                    //aux1 = lbPadres.SelectedItem.ToString();
                    //lbPadres.SelectedIndex = i+1;
                    //aux2 = lbPadres.SelectedItem.ToString();
                    if (pcrt1 < pcrt2)
                    {
                       // MessageBox.Show("Entre", "Algoritmo Genético", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        lbPadres.SelectedIndex = i;
                        //MessageBox.Show(lbPadres.SelectedItem.ToString() + " antes".ToString(), "Algoritmo Genético", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        for (int j = 0; j < lbPadres.SelectedItem.ToString().Length; j++)
                        {
                            if (j >= pcrt1 && j <= pcrt2)
                            {
                                lbPadres.SelectedIndex = i + 1;
                                aux1 += lbPadres.SelectedItem.ToString()[j];
                                lbPadres.SelectedIndex = i;
                                aux2 += lbPadres.SelectedItem.ToString()[j];
                                //aux1.Replace(aux1[j], lbPadres.SelectedItem.ToString()[j]);
                            }
                            else
                            {
                                lbPadres.SelectedIndex = i;
                                aux1 += lbPadres.SelectedItem.ToString()[j];
                                lbPadres.SelectedIndex = i + 1;
                                aux2 += lbPadres.SelectedItem.ToString()[j];
                            }

                        }
                        //MessageBox.Show(aux1 + " despues", "Algoritmo Genético", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        lbHijos.Items.Add(aux1);
                        aux1 = "";
                        lbHijos.Items.Add(aux2);
                        aux2 = "";
                    }
                    else
                    {
                        //MessageBox.Show("Entre", "Algoritmo Genético", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        lbPadres.SelectedIndex = i;
                       // MessageBox.Show(lbPadres.SelectedItem.ToString() + " antes".ToString(), "Algoritmo Genético", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        for (int j = 0; j < lbPadres.SelectedItem.ToString().Length; j++)
                        {
                            if (j <= pcrt2 || j >= pcrt1)
                            {
                                lbPadres.SelectedIndex = i + 1;
                                aux1 += lbPadres.SelectedItem.ToString()[j];
                                lbPadres.SelectedIndex = i;
                                aux2 += lbPadres.SelectedItem.ToString()[j];
                                //aux1.Replace(aux1[j], lbPadres.SelectedItem.ToString()[j]);
                            }
                            else
                            {

                                lbPadres.SelectedIndex = i;
                                aux1 += lbPadres.SelectedItem.ToString()[j];
                                lbPadres.SelectedIndex = i + 1;
                                aux2 += lbPadres.SelectedItem.ToString()[j];
                            }

                        }
                        //  MessageBox.Show(aux1 + " despues", "Algoritmo Genético", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        lbHijos.Items.Add(aux1);
                        aux1 = "";
                        lbHijos.Items.Add(aux2);
                        aux2 = "";
                    }
                    i++;
                }
                else
                {
                    lbPadres.SelectedIndex = i;
                    lbHijos.Items.Add(lbPadres.SelectedItem);
                    i++;
                    lbPadres.SelectedIndex = i;
                    lbHijos.Items.Add(lbPadres.SelectedItem);
                }                
            }

            for (int i = 0; i < Poblacion; i++) //Recorrer el numero de hijos
            {
                string aux = "";
                lbHijos.SelectedIndex = i;//Posicionarse en el item 1
                for (int j = 0; j < lbHijos.SelectedItem.ToString().Length; j++)//Recorrer el numero de elementos de cada hijo
                {
                    double al1 = r.NextDouble();
                    //lbHijos.SelectedIndex = j;
                    if (al1 < Convert.ToDouble(tbPM.Text))//Si el numero aleatorio es menor que la probabilidad de mutacion
                    {
                        if (lbHijos.SelectedItem.ToString()[j] == '0')//si la posicion actual de j en hijo es 0
                        {
                            //aux1+=lbHijos.SelectedIndex.ToString()[j];
                            aux += "1";
                            //aux1.Replace(aux[j], lbHijos.SelectedItem.ToString()[j]);
                            //aux1.Remove(j, 1).Insert(j, aux);
                            //lbHijos.SelectedIndex = i++;
                            
                        }
                        else
                        {
                            //aux1 += lbHijos.SelectedIndex.ToString()[j];
                            aux += "0";
                            //aux1.Replace(aux[j], lbHijos.SelectedItem.ToString()[j]);
                            //aux1.Remove(j, 1).Insert(j, aux);
                            //lbHijos.SelectedIndex = i++;
                        }
                    }
                    else
                    {
                        aux += lbHijos.SelectedItem.ToString()[j];

                    }
                }
                lbMutacion.Items.Add(aux);
                aux = "";
                //aux1 = "";
            }
        }
    }
}
