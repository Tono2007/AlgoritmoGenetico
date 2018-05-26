﻿using System;
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
            double sumatoria = 0,acumulado=0;
            lbX.Items.Clear();
            lbIndividuos.Items.Clear();
            lbFx.Items.Clear();
            lbFnorm.Items.Clear();
            lbAcumulado.Items.Clear();
            lbPadres.Items.Clear();
            if ((Poblacion % 2) == 0)
            {
                for (int i = 0; i < Poblacion; i++)
                {               
                    int random = r.Next(1, 254);
                    lbX.Items.Add(random);//Inicializar Población
                    lbIndividuos.Items.Add(Convert.ToString(random, 2));
                    double fx = Math.Sin(Math.PI * random / 256); //Calcular aptitud 
                    lbFx.Items.Add(Decimal.Round(Convert.ToDecimal(fx),3));
                    sumatoria = sumatoria + Convert.ToDouble(Decimal.Round(Convert.ToDecimal(fx),3));
                }
                lbSumatoria.Text = Convert.ToString(sumatoria);
                for (int i = 0; i < Poblacion; i++)
                {
                    lbFx.SelectedIndex = i;//calcular fnorm
                    lbFnorm.Items.Add((Decimal.Round(Convert.ToDecimal(Convert.ToDouble(lbFx.SelectedItem) / sumatoria),3)));
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
                    double random = r.NextDouble();
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
        }
    }
}