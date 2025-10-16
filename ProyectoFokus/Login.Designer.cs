namespace ProyectoFokus
{
    partial class Login
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ContraUsu = new System.Windows.Forms.TextBox();
            this.GmailUsu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IniciarSesion = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Registro = new System.Windows.Forms.Button();
            this.VerContra = new System.Windows.Forms.CheckBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(118, 133);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Contraseña:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(118, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mail:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ContraUsu
            // 
            this.ContraUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContraUsu.Location = new System.Drawing.Point(352, 133);
            this.ContraUsu.Margin = new System.Windows.Forms.Padding(2);
            this.ContraUsu.Name = "ContraUsu";
            this.ContraUsu.Size = new System.Drawing.Size(151, 29);
            this.ContraUsu.TabIndex = 11;
            this.ContraUsu.TextChanged += new System.EventHandler(this.EdadUsu_TextChanged);
            // 
            // GmailUsu
            // 
            this.GmailUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GmailUsu.Location = new System.Drawing.Point(352, 93);
            this.GmailUsu.Margin = new System.Windows.Forms.Padding(2);
            this.GmailUsu.Name = "GmailUsu";
            this.GmailUsu.Size = new System.Drawing.Size(151, 29);
            this.GmailUsu.TabIndex = 10;
            this.GmailUsu.TextChanged += new System.EventHandler(this.NombreUsu_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(260, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 46);
            this.label1.TabIndex = 16;
            this.label1.Text = "Login";
            // 
            // IniciarSesion
            // 
            this.IniciarSesion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.IniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IniciarSesion.Font = new System.Drawing.Font("Microsoft New Tai Lue", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IniciarSesion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.IniciarSesion.Location = new System.Drawing.Point(226, 189);
            this.IniciarSesion.Name = "IniciarSesion";
            this.IniciarSesion.Size = new System.Drawing.Size(167, 45);
            this.IniciarSesion.TabIndex = 17;
            this.IniciarSesion.Text = "Iniciar sesión";
            this.IniciarSesion.UseVisualStyleBackColor = false;
            this.IniciarSesion.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(1, 490);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "¿Aún no te has regristrado? -->";
            // 
            // Registro
            // 
            this.Registro.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Registro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Registro.Font = new System.Drawing.Font("Microsoft New Tai Lue", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Registro.Location = new System.Drawing.Point(248, 466);
            this.Registro.Name = "Registro";
            this.Registro.Size = new System.Drawing.Size(125, 45);
            this.Registro.TabIndex = 19;
            this.Registro.Text = "Registro";
            this.Registro.UseVisualStyleBackColor = false;
            this.Registro.Click += new System.EventHandler(this.Registro_Click);
            // 
            // VerContra
            // 
            this.VerContra.AutoSize = true;
            this.VerContra.Location = new System.Drawing.Point(518, 144);
            this.VerContra.Margin = new System.Windows.Forms.Padding(2);
            this.VerContra.Name = "VerContra";
            this.VerContra.Size = new System.Drawing.Size(15, 14);
            this.VerContra.TabIndex = 23;
            this.VerContra.UseVisualStyleBackColor = true;
            this.VerContra.CheckedChanged += new System.EventHandler(this.VerContra_CheckedChanged);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::ProyectoFokus.Properties.Resources.OJO;
            this.pictureBox6.Location = new System.Drawing.Point(540, 133);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(44, 34);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 24;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::ProyectoFokus.Properties.Resources.LogoFokus;
            this.pictureBox5.Location = new System.Drawing.Point(540, 2);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(75, 55);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 22;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(40, 408);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(75, 41);
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoFokus.Properties.Resources.Robot__Copia___1_;
            this.pictureBox1.Location = new System.Drawing.Point(25, 240);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(508, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ProyectoFokus.Properties.Resources.usuario;
            this.pictureBox3.Location = new System.Drawing.Point(77, 77);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(44, 34);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProyectoFokus.Properties.Resources.candado;
            this.pictureBox2.Location = new System.Drawing.Point(77, 124);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(615, 530);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.VerContra);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Registro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IniciarSesion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ContraUsu);
            this.Controls.Add(this.GmailUsu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Opacity = 0.9D;
            this.Text = "Fokus";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ContraUsu;
        private System.Windows.Forms.TextBox GmailUsu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button IniciarSesion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Registro;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.CheckBox VerContra;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}