namespace SistemasVentas.VISTA
{
    partial class UsuarioLogin
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(136, 236);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            textBox1.Text = "Usuario";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(136, 290);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(129, 27);
            textBox2.TabIndex = 1;
            textBox2.Text = "Contraseña";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(318, 58);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 2;
            label1.Text = "Inicio de Sesión ";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(132, 374);
            label2.Name = "label2";
            label2.Size = new Size(474, 20);
            label2.TabIndex = 3;
            label2.Text = "En caso de perder su contraseña comuniquese con (numero de admin)";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(333, 112);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(102, 75);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // UsuarioLogim
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "UsuarioLogim";
            Text = "UsuarioLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
    }
}