﻿namespace SistemasVentas.VISTA.Usuario_administrador.Clientes
{
    partial class BuscarEditarClienteAdministrador
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 36);
            label1.Name = "label1";
            label1.Size = new Size(236, 20);
            label1.TabIndex = 0;
            label1.Text = "Busque el cliente que desea editar";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 114);
            label2.Name = "label2";
            label2.Size = new Size(167, 20);
            label2.TabIndex = 1;
            label2.Text = "Ingrese el CI del cliente ";
            label2.Click += this.label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(185, 114);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(50, 193);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += this.button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(231, 193);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 4;
            button2.Text = "Confirmar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += this.button2_Click;
            // 
            // BuscarEditarClienteAdministrador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 326);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "BuscarEditarClienteAdministrador";
            Text = "EditarClienteAdministrador";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
    }
}