namespace Calculadora
{
    partial class Form1
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
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnUno = new System.Windows.Forms.Button();
            this.btnTres = new System.Windows.Forms.Button();
            this.btnDos = new System.Windows.Forms.Button();
            this.btnCinco = new System.Windows.Forms.Button();
            this.btnSeis = new System.Windows.Forms.Button();
            this.btnCuatro = new System.Windows.Forms.Button();
            this.btnOcho = new System.Windows.Forms.Button();
            this.btnNueve = new System.Windows.Forms.Button();
            this.btnSiete = new System.Windows.Forms.Button();
            this.btnBorrarTodo = new System.Windows.Forms.Button();
            this.btnrr = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnElevarcuadrado = new System.Windows.Forms.Button();
            this.btnRaiz = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnRestar = new System.Windows.Forms.Button();
            this.btnSumar = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnCero = new System.Windows.Forms.Button();
            this.btnPunto = new System.Windows.Forms.Button();
            this.btnSigno = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtResultado
            // 
            this.txtResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtResultado.Location = new System.Drawing.Point(22, 11);
            this.txtResultado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtResultado.MaxLength = 20;
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(357, 53);
            this.txtResultado.TabIndex = 0;
            this.txtResultado.Text = "0";
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnUno
            // 
            this.btnUno.BackColor = System.Drawing.Color.SlateGray;
            this.btnUno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnUno.Location = new System.Drawing.Point(22, 247);
            this.btnUno.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUno.Name = "btnUno";
            this.btnUno.Size = new System.Drawing.Size(52, 45);
            this.btnUno.TabIndex = 1;
            this.btnUno.Text = "1";
            this.btnUno.UseVisualStyleBackColor = false;
            this.btnUno.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnTres
            // 
            this.btnTres.BackColor = System.Drawing.Color.SlateGray;
            this.btnTres.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnTres.Location = new System.Drawing.Point(168, 247);
            this.btnTres.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTres.Name = "btnTres";
            this.btnTres.Size = new System.Drawing.Size(52, 45);
            this.btnTres.TabIndex = 6;
            this.btnTres.Text = "3";
            this.btnTres.UseVisualStyleBackColor = false;
            this.btnTres.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnDos
            // 
            this.btnDos.BackColor = System.Drawing.Color.SlateGray;
            this.btnDos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnDos.Location = new System.Drawing.Point(97, 247);
            this.btnDos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDos.Name = "btnDos";
            this.btnDos.Size = new System.Drawing.Size(52, 45);
            this.btnDos.TabIndex = 7;
            this.btnDos.Text = "2";
            this.btnDos.UseVisualStyleBackColor = false;
            this.btnDos.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnCinco
            // 
            this.btnCinco.BackColor = System.Drawing.Color.SlateGray;
            this.btnCinco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnCinco.Location = new System.Drawing.Point(97, 185);
            this.btnCinco.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.Size = new System.Drawing.Size(52, 45);
            this.btnCinco.TabIndex = 10;
            this.btnCinco.Text = "5";
            this.btnCinco.UseVisualStyleBackColor = false;
            this.btnCinco.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnSeis
            // 
            this.btnSeis.BackColor = System.Drawing.Color.SlateGray;
            this.btnSeis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnSeis.Location = new System.Drawing.Point(168, 185);
            this.btnSeis.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSeis.Name = "btnSeis";
            this.btnSeis.Size = new System.Drawing.Size(52, 45);
            this.btnSeis.TabIndex = 9;
            this.btnSeis.Text = "6";
            this.btnSeis.UseVisualStyleBackColor = false;
            this.btnSeis.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnCuatro
            // 
            this.btnCuatro.BackColor = System.Drawing.Color.SlateGray;
            this.btnCuatro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnCuatro.Location = new System.Drawing.Point(22, 185);
            this.btnCuatro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCuatro.Name = "btnCuatro";
            this.btnCuatro.Size = new System.Drawing.Size(52, 45);
            this.btnCuatro.TabIndex = 8;
            this.btnCuatro.Text = "4";
            this.btnCuatro.UseVisualStyleBackColor = false;
            this.btnCuatro.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnOcho
            // 
            this.btnOcho.BackColor = System.Drawing.Color.SlateGray;
            this.btnOcho.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnOcho.Location = new System.Drawing.Point(97, 124);
            this.btnOcho.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOcho.Name = "btnOcho";
            this.btnOcho.Size = new System.Drawing.Size(52, 45);
            this.btnOcho.TabIndex = 13;
            this.btnOcho.Text = "8";
            this.btnOcho.UseVisualStyleBackColor = false;
            this.btnOcho.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnNueve
            // 
            this.btnNueve.BackColor = System.Drawing.Color.SlateGray;
            this.btnNueve.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnNueve.Location = new System.Drawing.Point(168, 124);
            this.btnNueve.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNueve.Name = "btnNueve";
            this.btnNueve.Size = new System.Drawing.Size(52, 45);
            this.btnNueve.TabIndex = 12;
            this.btnNueve.Text = "9";
            this.btnNueve.UseVisualStyleBackColor = false;
            this.btnNueve.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnSiete
            // 
            this.btnSiete.BackColor = System.Drawing.Color.SlateGray;
            this.btnSiete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnSiete.Location = new System.Drawing.Point(22, 124);
            this.btnSiete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSiete.Name = "btnSiete";
            this.btnSiete.Size = new System.Drawing.Size(52, 45);
            this.btnSiete.TabIndex = 11;
            this.btnSiete.Text = "7";
            this.btnSiete.UseVisualStyleBackColor = false;
            this.btnSiete.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnBorrarTodo
            // 
            this.btnBorrarTodo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBorrarTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnBorrarTodo.Location = new System.Drawing.Point(97, 70);
            this.btnBorrarTodo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBorrarTodo.Name = "btnBorrarTodo";
            this.btnBorrarTodo.Size = new System.Drawing.Size(52, 45);
            this.btnBorrarTodo.TabIndex = 16;
            this.btnBorrarTodo.Text = "C";
            this.btnBorrarTodo.UseVisualStyleBackColor = false;
            this.btnBorrarTodo.Click += new System.EventHandler(this.btnBorrarTodo_Click);
            // 
            // btnrr
            // 
            this.btnrr.BackColor = System.Drawing.Color.DarkRed;
            this.btnrr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnrr.Location = new System.Drawing.Point(168, 70);
            this.btnrr.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnrr.Name = "btnrr";
            this.btnrr.Size = new System.Drawing.Size(52, 45);
            this.btnrr.TabIndex = 15;
            this.btnrr.Text = "<-";
            this.btnrr.UseVisualStyleBackColor = false;
            this.btnrr.Click += new System.EventHandler(this.btnrr_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnBorrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBorrar.Location = new System.Drawing.Point(22, 70);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(52, 45);
            this.btnBorrar.TabIndex = 14;
            this.btnBorrar.Text = "CE";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnElevarcuadrado
            // 
            this.btnElevarcuadrado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnElevarcuadrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnElevarcuadrado.Location = new System.Drawing.Point(327, 70);
            this.btnElevarcuadrado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnElevarcuadrado.Name = "btnElevarcuadrado";
            this.btnElevarcuadrado.Size = new System.Drawing.Size(52, 45);
            this.btnElevarcuadrado.TabIndex = 18;
            this.btnElevarcuadrado.Tag = "²";
            this.btnElevarcuadrado.Text = "x²";
            this.btnElevarcuadrado.UseVisualStyleBackColor = false;
            this.btnElevarcuadrado.Click += new System.EventHandler(this.clickOperador);
            // 
            // btnRaiz
            // 
            this.btnRaiz.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRaiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaiz.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRaiz.Location = new System.Drawing.Point(252, 70);
            this.btnRaiz.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRaiz.Name = "btnRaiz";
            this.btnRaiz.Size = new System.Drawing.Size(52, 45);
            this.btnRaiz.TabIndex = 17;
            this.btnRaiz.Tag = "√";
            this.btnRaiz.Text = "√";
            this.btnRaiz.UseVisualStyleBackColor = false;
            this.btnRaiz.Click += new System.EventHandler(this.clickOperador);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMultiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnMultiplicar.Location = new System.Drawing.Point(327, 124);
            this.btnMultiplicar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(52, 45);
            this.btnMultiplicar.TabIndex = 20;
            this.btnMultiplicar.Tag = "X";
            this.btnMultiplicar.Text = "X";
            this.btnMultiplicar.UseVisualStyleBackColor = false;
            this.btnMultiplicar.Click += new System.EventHandler(this.clickOperador);
            // 
            // btnDividir
            // 
            this.btnDividir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDividir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDividir.Location = new System.Drawing.Point(252, 124);
            this.btnDividir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(52, 45);
            this.btnDividir.TabIndex = 19;
            this.btnDividir.Tag = "∕";
            this.btnDividir.Text = "∕";
            this.btnDividir.UseVisualStyleBackColor = false;
            this.btnDividir.Click += new System.EventHandler(this.clickOperador);
            // 
            // btnRestar
            // 
            this.btnRestar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRestar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnRestar.Location = new System.Drawing.Point(327, 185);
            this.btnRestar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRestar.Name = "btnRestar";
            this.btnRestar.Size = new System.Drawing.Size(52, 45);
            this.btnRestar.TabIndex = 22;
            this.btnRestar.Tag = "-";
            this.btnRestar.Text = "-";
            this.btnRestar.UseVisualStyleBackColor = false;
            this.btnRestar.Click += new System.EventHandler(this.clickOperador);
            // 
            // btnSumar
            // 
            this.btnSumar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSumar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSumar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSumar.Location = new System.Drawing.Point(252, 185);
            this.btnSumar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(52, 45);
            this.btnSumar.TabIndex = 21;
            this.btnSumar.Tag = "+";
            this.btnSumar.Text = "+";
            this.btnSumar.UseVisualStyleBackColor = false;
            this.btnSumar.Click += new System.EventHandler(this.clickOperador);
            // 
            // btnIgual
            // 
            this.btnIgual.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgual.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIgual.Location = new System.Drawing.Point(252, 247);
            this.btnIgual.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(127, 45);
            this.btnIgual.TabIndex = 23;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = false;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnCero
            // 
            this.btnCero.BackColor = System.Drawing.Color.SlateGray;
            this.btnCero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnCero.Location = new System.Drawing.Point(97, 308);
            this.btnCero.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCero.Name = "btnCero";
            this.btnCero.Size = new System.Drawing.Size(52, 45);
            this.btnCero.TabIndex = 26;
            this.btnCero.Text = "0";
            this.btnCero.UseVisualStyleBackColor = false;
            this.btnCero.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnPunto
            // 
            this.btnPunto.BackColor = System.Drawing.Color.SlateGray;
            this.btnPunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnPunto.Location = new System.Drawing.Point(168, 308);
            this.btnPunto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.Size = new System.Drawing.Size(52, 45);
            this.btnPunto.TabIndex = 25;
            this.btnPunto.Text = ".";
            this.btnPunto.UseVisualStyleBackColor = false;
            this.btnPunto.Click += new System.EventHandler(this.btnPunto_Click);
            // 
            // btnSigno
            // 
            this.btnSigno.BackColor = System.Drawing.Color.SlateGray;
            this.btnSigno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSigno.Location = new System.Drawing.Point(22, 308);
            this.btnSigno.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSigno.Name = "btnSigno";
            this.btnSigno.Size = new System.Drawing.Size(52, 45);
            this.btnSigno.TabIndex = 24;
            this.btnSigno.Text = "+/-";
            this.btnSigno.UseVisualStyleBackColor = false;
            this.btnSigno.Click += new System.EventHandler(this.btnSigno_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Jose Bonilla";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "2023-1541";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 366);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCero);
            this.Controls.Add(this.btnPunto);
            this.Controls.Add(this.btnSigno);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnRestar);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnElevarcuadrado);
            this.Controls.Add(this.btnRaiz);
            this.Controls.Add(this.btnBorrarTodo);
            this.Controls.Add(this.btnrr);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnOcho);
            this.Controls.Add(this.btnNueve);
            this.Controls.Add(this.btnSiete);
            this.Controls.Add(this.btnCinco);
            this.Controls.Add(this.btnSeis);
            this.Controls.Add(this.btnCuatro);
            this.Controls.Add(this.btnDos);
            this.Controls.Add(this.btnTres);
            this.Controls.Add(this.btnUno);
            this.Controls.Add(this.txtResultado);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora JOSE";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnUno;
        private System.Windows.Forms.Button btnTres;
        private System.Windows.Forms.Button btnDos;
        private System.Windows.Forms.Button btnCinco;
        private System.Windows.Forms.Button btnSeis;
        private System.Windows.Forms.Button btnCuatro;
        private System.Windows.Forms.Button btnOcho;
        private System.Windows.Forms.Button btnNueve;
        private System.Windows.Forms.Button btnSiete;
        private System.Windows.Forms.Button btnBorrarTodo;
        private System.Windows.Forms.Button btnrr;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnElevarcuadrado;
        private System.Windows.Forms.Button btnRaiz;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnRestar;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnCero;
        private System.Windows.Forms.Button btnPunto;
        private System.Windows.Forms.Button btnSigno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

