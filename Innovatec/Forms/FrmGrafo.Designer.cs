namespace Innovatec.Forms
{
    partial class FrmGrafo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbEdificio1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbEdificio2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbDistancia = new System.Windows.Forms.TextBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbOrigen = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbDestino = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.lbListaEdificio = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lbConexiones = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "--Sistema de notas --";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "AGREGAR EDIFICIO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre:";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(75, 82);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(132, 22);
            this.tbNombre.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(229, 78);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 28);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 130);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "CONECTAR EDIFICIO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 169);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Edificio 1:";
            // 
            // tbEdificio1
            // 
            this.tbEdificio1.Location = new System.Drawing.Point(81, 169);
            this.tbEdificio1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbEdificio1.Name = "tbEdificio1";
            this.tbEdificio1.Size = new System.Drawing.Size(132, 22);
            this.tbEdificio1.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(240, 172);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Edificio 2:";
            // 
            // tbEdificio2
            // 
            this.tbEdificio2.Location = new System.Drawing.Point(319, 172);
            this.tbEdificio2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbEdificio2.Name = "tbEdificio2";
            this.tbEdificio2.Size = new System.Drawing.Size(132, 22);
            this.tbEdificio2.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(475, 177);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Distancia:";
            // 
            // tbDistancia
            // 
            this.tbDistancia.Location = new System.Drawing.Point(555, 172);
            this.tbDistancia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbDistancia.Name = "tbDistancia";
            this.tbDistancia.Size = new System.Drawing.Size(132, 22);
            this.tbDistancia.TabIndex = 11;
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(712, 172);
            this.btnConectar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(100, 28);
            this.btnConectar.TabIndex = 12;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 217);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Calcular Ruta  corta";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 263);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Origen:";
            // 
            // tbOrigen
            // 
            this.tbOrigen.Location = new System.Drawing.Point(81, 263);
            this.tbOrigen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbOrigen.Name = "tbOrigen";
            this.tbOrigen.Size = new System.Drawing.Size(132, 22);
            this.tbOrigen.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(240, 272);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "Destino:";
            // 
            // tbDestino
            // 
            this.tbDestino.Location = new System.Drawing.Point(309, 272);
            this.tbDestino.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbDestino.Name = "tbDestino";
            this.tbDestino.Size = new System.Drawing.Size(132, 22);
            this.tbDestino.TabIndex = 17;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(479, 268);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 28);
            this.btnCalcular.TabIndex = 18;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 321);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 16);
            this.label11.TabIndex = 19;
            this.label11.Text = "Lista de Edificios";
            // 
            // lbListaEdificio
            // 
            this.lbListaEdificio.FormattingEnabled = true;
            this.lbListaEdificio.ItemHeight = 16;
            this.lbListaEdificio.Location = new System.Drawing.Point(21, 361);
            this.lbListaEdificio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbListaEdificio.Name = "lbListaEdificio";
            this.lbListaEdificio.Size = new System.Drawing.Size(159, 116);
            this.lbListaEdificio.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(305, 321);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 16);
            this.label12.TabIndex = 21;
            this.label12.Text = "Conexiones Existentes";
            // 
            // lbConexiones
            // 
            this.lbConexiones.FormattingEnabled = true;
            this.lbConexiones.ItemHeight = 16;
            this.lbConexiones.Location = new System.Drawing.Point(309, 361);
            this.lbConexiones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbConexiones.Name = "lbConexiones";
            this.lbConexiones.Size = new System.Drawing.Size(297, 132);
            this.lbConexiones.TabIndex = 22;
            // 
            // FrmGrafo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 636);
            this.Controls.Add(this.lbConexiones);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbListaEdificio);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.tbDestino);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbOrigen);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.tbDistancia);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbEdificio2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbEdificio1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmGrafo";
            this.Text = "Grafo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbEdificio1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbEdificio2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbDistancia;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbOrigen;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbDestino;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox lbListaEdificio;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox lbConexiones;
    }
}