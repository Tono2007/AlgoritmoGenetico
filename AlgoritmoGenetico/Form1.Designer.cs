namespace AlgoritmoGenetico
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbIndividuos = new System.Windows.Forms.ListBox();
            this.tbPoblacion = new System.Windows.Forms.TextBox();
            this.tbPC = new System.Windows.Forms.TextBox();
            this.tbPM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbX = new System.Windows.Forms.ListBox();
            this.lbFx = new System.Windows.Forms.ListBox();
            this.lbFnorm = new System.Windows.Forms.ListBox();
            this.lbAcumulado = new System.Windows.Forms.ListBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbSumatoria = new System.Windows.Forms.Label();
            this.lbSumatoriaNorm = new System.Windows.Forms.Label();
            this.lbPadres = new System.Windows.Forms.ListBox();
            this.lbHijos = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lbMutacion = new System.Windows.Forms.ListBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tbVueltas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbIndividuos
            // 
            this.lbIndividuos.FormattingEnabled = true;
            this.lbIndividuos.Location = new System.Drawing.Point(24, 150);
            this.lbIndividuos.Name = "lbIndividuos";
            this.lbIndividuos.Size = new System.Drawing.Size(91, 147);
            this.lbIndividuos.TabIndex = 0;
            // 
            // tbPoblacion
            // 
            this.tbPoblacion.Location = new System.Drawing.Point(24, 76);
            this.tbPoblacion.Name = "tbPoblacion";
            this.tbPoblacion.Size = new System.Drawing.Size(100, 20);
            this.tbPoblacion.TabIndex = 1;
            // 
            // tbPC
            // 
            this.tbPC.Location = new System.Drawing.Point(160, 76);
            this.tbPC.Name = "tbPC";
            this.tbPC.Size = new System.Drawing.Size(100, 20);
            this.tbPC.TabIndex = 2;
            // 
            // tbPM
            // 
            this.tbPM.Location = new System.Drawing.Point(295, 76);
            this.tbPM.Name = "tbPM";
            this.tbPM.Size = new System.Drawing.Size(100, 20);
            this.tbPM.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Algoritmo Genético";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Población (Número par)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Probabilidad de cruce\r\n(0.65 a 0.80)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Probabilidad de mutación\r\n(0.001 a 0.01)";
            // 
            // lbX
            // 
            this.lbX.FormattingEnabled = true;
            this.lbX.Location = new System.Drawing.Point(121, 150);
            this.lbX.Name = "lbX";
            this.lbX.Size = new System.Drawing.Size(91, 147);
            this.lbX.TabIndex = 9;
            // 
            // lbFx
            // 
            this.lbFx.FormattingEnabled = true;
            this.lbFx.Location = new System.Drawing.Point(218, 150);
            this.lbFx.Name = "lbFx";
            this.lbFx.Size = new System.Drawing.Size(91, 147);
            this.lbFx.TabIndex = 10;
            // 
            // lbFnorm
            // 
            this.lbFnorm.FormattingEnabled = true;
            this.lbFnorm.Location = new System.Drawing.Point(315, 150);
            this.lbFnorm.Name = "lbFnorm";
            this.lbFnorm.Size = new System.Drawing.Size(91, 147);
            this.lbFnorm.TabIndex = 11;
            // 
            // lbAcumulado
            // 
            this.lbAcumulado.FormattingEnabled = true;
            this.lbAcumulado.Location = new System.Drawing.Point(412, 150);
            this.lbAcumulado.Name = "lbAcumulado";
            this.lbAcumulado.Size = new System.Drawing.Size(90, 147);
            this.lbAcumulado.TabIndex = 12;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Location = new System.Drawing.Point(642, 56);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 32);
            this.btnIniciar.TabIndex = 14;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(592, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "Maximizar f(x)=sin(π x/256)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(652, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "0<x<255";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(330, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "f norm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(255, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 18);
            this.label8.TabIndex = 18;
            this.label8.Text = "f(x)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(157, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 18);
            this.label9.TabIndex = 19;
            this.label9.Text = "x";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(29, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 18);
            this.label10.TabIndex = 20;
            this.label10.Text = "Individuos";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(398, 129);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 18);
            this.label11.TabIndex = 21;
            this.label11.Text = "Acumulado norm";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(218, 300);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 18);
            this.label12.TabIndex = 22;
            this.label12.Text = "Σf(x):";
            // 
            // lbSumatoria
            // 
            this.lbSumatoria.AutoSize = true;
            this.lbSumatoria.Location = new System.Drawing.Point(255, 304);
            this.lbSumatoria.Name = "lbSumatoria";
            this.lbSumatoria.Size = new System.Drawing.Size(54, 13);
            this.lbSumatoria.TabIndex = 23;
            this.lbSumatoria.Text = "Sumatoria";
            // 
            // lbSumatoriaNorm
            // 
            this.lbSumatoriaNorm.AutoSize = true;
            this.lbSumatoriaNorm.Location = new System.Drawing.Point(333, 300);
            this.lbSumatoriaNorm.Name = "lbSumatoriaNorm";
            this.lbSumatoriaNorm.Size = new System.Drawing.Size(13, 13);
            this.lbSumatoriaNorm.TabIndex = 24;
            this.lbSumatoriaNorm.Text = "1";
            // 
            // lbPadres
            // 
            this.lbPadres.FormattingEnabled = true;
            this.lbPadres.Location = new System.Drawing.Point(508, 150);
            this.lbPadres.Name = "lbPadres";
            this.lbPadres.Size = new System.Drawing.Size(92, 147);
            this.lbPadres.TabIndex = 25;
            // 
            // lbHijos
            // 
            this.lbHijos.FormattingEnabled = true;
            this.lbHijos.Location = new System.Drawing.Point(606, 150);
            this.lbHijos.Name = "lbHijos";
            this.lbHijos.Size = new System.Drawing.Size(85, 147);
            this.lbHijos.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(525, 129);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 18);
            this.label13.TabIndex = 27;
            this.label13.Text = "Padres";
            // 
            // lbMutacion
            // 
            this.lbMutacion.FormattingEnabled = true;
            this.lbMutacion.Location = new System.Drawing.Point(697, 150);
            this.lbMutacion.Name = "lbMutacion";
            this.lbMutacion.Size = new System.Drawing.Size(84, 147);
            this.lbMutacion.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(623, 129);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 18);
            this.label14.TabIndex = 29;
            this.label14.Text = "Hijos";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(694, 129);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 18);
            this.label15.TabIndex = 30;
            this.label15.Text = "Mutación";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(442, 50);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 13);
            this.label16.TabIndex = 31;
            this.label16.Text = "No. de Vueltas";
            // 
            // tbVueltas
            // 
            this.tbVueltas.Location = new System.Drawing.Point(433, 76);
            this.tbVueltas.Name = "tbVueltas";
            this.tbVueltas.Size = new System.Drawing.Size(100, 20);
            this.tbVueltas.TabIndex = 32;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 325);
            this.Controls.Add(this.tbVueltas);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lbMutacion);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lbHijos);
            this.Controls.Add(this.lbPadres);
            this.Controls.Add(this.lbSumatoriaNorm);
            this.Controls.Add(this.lbSumatoria);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.lbAcumulado);
            this.Controls.Add(this.lbFnorm);
            this.Controls.Add(this.lbFx);
            this.Controls.Add(this.lbX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPM);
            this.Controls.Add(this.tbPC);
            this.Controls.Add(this.tbPoblacion);
            this.Controls.Add(this.lbIndividuos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbIndividuos;
        private System.Windows.Forms.TextBox tbPoblacion;
        private System.Windows.Forms.TextBox tbPC;
        private System.Windows.Forms.TextBox tbPM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbX;
        private System.Windows.Forms.ListBox lbFx;
        private System.Windows.Forms.ListBox lbFnorm;
        private System.Windows.Forms.ListBox lbAcumulado;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbSumatoria;
        private System.Windows.Forms.Label lbSumatoriaNorm;
        private System.Windows.Forms.ListBox lbPadres;
        private System.Windows.Forms.ListBox lbHijos;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox lbMutacion;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbVueltas;
    }
}

