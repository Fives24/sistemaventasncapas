namespace SistemasVentas.VISTA.Usuario_administrador
{
    partial class ClientesAdministrador
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(328, 19);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 0;
            label1.Text = "Clientes";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(29, 112);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(28, 27);
            textBox1.TabIndex = 1;
            textBox1.Text = "CI";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(75, 112);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(68, 27);
            textBox2.TabIndex = 2;
            textBox2.Text = "Nombres";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(159, 112);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(68, 27);
            textBox3.TabIndex = 3;
            textBox3.Text = "Apellidos";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(244, 112);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(68, 27);
            textBox4.TabIndex = 4;
            textBox4.Text = "Telefono";
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(328, 112);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(68, 27);
            textBox5.TabIndex = 5;
            textBox5.Text = "Direccion";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(409, 112);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(68, 27);
            textBox6.TabIndex = 6;
            textBox6.Text = "Correo";
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(483, 112);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(68, 27);
            textBox7.TabIndex = 7;
            textBox7.Text = "Historial";
            // 
            // button1
            // 
            button1.Location = new Point(29, 54);
            button1.Name = "button1";
            button1.Size = new Size(87, 33);
            button1.TabIndex = 8;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(186, 54);
            button2.Name = "button2";
            button2.Size = new Size(156, 33);
            button2.TabIndex = 9;
            button2.Text = "Editar información";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(415, 54);
            button3.Name = "button3";
            button3.Size = new Size(106, 33);
            button3.TabIndex = 10;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(617, 54);
            button4.Name = "button4";
            button4.Size = new Size(87, 33);
            button4.TabIndex = 11;
            button4.Text = "Buscar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(617, 110);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 12;
            button5.Text = "Volver";
            button5.UseVisualStyleBackColor = true;
            // 
            // ClientesAdministrador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "ClientesAdministrador";
            Text = "ClientesAdministrador";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}