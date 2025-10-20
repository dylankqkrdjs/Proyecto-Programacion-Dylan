namespace ProyectoFokus
{
    partial class FokusPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Encuesta = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbProductividad = new System.Windows.Forms.RadioButton();
            this.rdbAprender = new System.Windows.Forms.RadioButton();
            this.rdbEjercicio = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.PanelTareas = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAgregarTarea = new System.Windows.Forms.Button();
            this.TareaTimer = new System.Windows.Forms.Timer(this.components);
            this.btnIniciarPausar = new System.Windows.Forms.Button();
            this.lblCronometro = new System.Windows.Forms.Label();
            this.TiempoActual = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CargarTareas = new System.Windows.Forms.Button();
            this.Encuesta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.PanelTareas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(229, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 40);
            this.label1.TabIndex = 17;
            this.label1.Text = "Fokus";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(97, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(486, 37);
            this.label2.TabIndex = 18;
            this.label2.Text = "Antes para empezar a generar tus habitos, fokus necesita saber tus gustos o habit" +
    "os que quieras reforzar !";
            // 
            // Encuesta
            // 
            this.Encuesta.Controls.Add(this.pictureBox2);
            this.Encuesta.Controls.Add(this.label6);
            this.Encuesta.Controls.Add(this.label5);
            this.Encuesta.Controls.Add(this.label3);
            this.Encuesta.Controls.Add(this.rdbProductividad);
            this.Encuesta.Controls.Add(this.rdbAprender);
            this.Encuesta.Controls.Add(this.rdbEjercicio);
            this.Encuesta.Location = new System.Drawing.Point(94, 174);
            this.Encuesta.Margin = new System.Windows.Forms.Padding(2);
            this.Encuesta.Name = "Encuesta";
            this.Encuesta.Padding = new System.Windows.Forms.Padding(2);
            this.Encuesta.Size = new System.Drawing.Size(459, 154);
            this.Encuesta.TabIndex = 19;
            this.Encuesta.TabStop = false;
            this.Encuesta.Text = "groupBox1";
            this.Encuesta.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(319, 108);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(110, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(4, 112);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 37);
            this.label6.TabIndex = 22;
            this.label6.Text = "¿ Queres mejorar tu productividad diaria ?";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(2, 67);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 37);
            this.label5.TabIndex = 21;
            this.label5.Text = "¿ Te interesa aprender algo nuevo ?";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(4, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 37);
            this.label3.TabIndex = 20;
            this.label3.Text = "¿ Te gustaria hacer ejercicio ?";
            // 
            // rdbProductividad
            // 
            this.rdbProductividad.AutoSize = true;
            this.rdbProductividad.Location = new System.Drawing.Point(214, 124);
            this.rdbProductividad.Margin = new System.Windows.Forms.Padding(2);
            this.rdbProductividad.Name = "rdbProductividad";
            this.rdbProductividad.Size = new System.Drawing.Size(85, 17);
            this.rdbProductividad.TabIndex = 2;
            this.rdbProductividad.TabStop = true;
            this.rdbProductividad.Text = "radioButton3";
            this.rdbProductividad.UseVisualStyleBackColor = true;
            this.rdbProductividad.CheckedChanged += new System.EventHandler(this.Encuesta_CheckedChanged);
            // 
            // rdbAprender
            // 
            this.rdbAprender.AutoSize = true;
            this.rdbAprender.Location = new System.Drawing.Point(214, 70);
            this.rdbAprender.Margin = new System.Windows.Forms.Padding(2);
            this.rdbAprender.Name = "rdbAprender";
            this.rdbAprender.Size = new System.Drawing.Size(85, 17);
            this.rdbAprender.TabIndex = 1;
            this.rdbAprender.TabStop = true;
            this.rdbAprender.Text = "radioButton2";
            this.rdbAprender.UseVisualStyleBackColor = true;
            this.rdbAprender.CheckedChanged += new System.EventHandler(this.rdbAprender_CheckedChanged);
            // 
            // rdbEjercicio
            // 
            this.rdbEjercicio.AutoSize = true;
            this.rdbEjercicio.Location = new System.Drawing.Point(214, 17);
            this.rdbEjercicio.Margin = new System.Windows.Forms.Padding(2);
            this.rdbEjercicio.Name = "rdbEjercicio";
            this.rdbEjercicio.Size = new System.Drawing.Size(85, 17);
            this.rdbEjercicio.TabIndex = 0;
            this.rdbEjercicio.TabStop = true;
            this.rdbEjercicio.Text = "radioButton1";
            this.rdbEjercicio.UseVisualStyleBackColor = true;
            this.rdbEjercicio.CheckedChanged += new System.EventHandler(this.rdbEjercicio_CheckedChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(14, 135);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(595, 28);
            this.label4.TabIndex = 21;
            this.label4.Text = "Elija la opcion que mas quiera mejorar , no se preocupe nosotros hacemos el resto" +
    " ";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFinalizar.Location = new System.Drawing.Point(234, 357);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(121, 45);
            this.btnFinalizar.TabIndex = 22;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // PanelTareas
            // 
            this.PanelTareas.AutoScroll = true;
            this.PanelTareas.Controls.Add(this.btnAgregarTarea);
            this.PanelTareas.Location = new System.Drawing.Point(11, 11);
            this.PanelTareas.Margin = new System.Windows.Forms.Padding(2);
            this.PanelTareas.Name = "PanelTareas";
            this.PanelTareas.Size = new System.Drawing.Size(424, 815);
            this.PanelTareas.TabIndex = 23;
            this.PanelTareas.Visible = false;
            this.PanelTareas.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelTareas_Paint);
            // 
            // btnAgregarTarea
            // 
            this.btnAgregarTarea.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregarTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarTarea.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAgregarTarea.Location = new System.Drawing.Point(2, 2);
            this.btnAgregarTarea.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarTarea.Name = "btnAgregarTarea";
            this.btnAgregarTarea.Size = new System.Drawing.Size(422, 37);
            this.btnAgregarTarea.TabIndex = 0;
            this.btnAgregarTarea.Text = "Agregar tarea";
            this.btnAgregarTarea.UseVisualStyleBackColor = false;
            this.btnAgregarTarea.Visible = false;
            this.btnAgregarTarea.Click += new System.EventHandler(this.btnAgregarTarea_Click);
            // 
            // TareaTimer
            // 
            this.TareaTimer.Interval = 1000;
            this.TareaTimer.Tick += new System.EventHandler(this.TareaTimer_Tick);
            // 
            // btnIniciarPausar
            // 
            this.btnIniciarPausar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIniciarPausar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnIniciarPausar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarPausar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarPausar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnIniciarPausar.Location = new System.Drawing.Point(557, 174);
            this.btnIniciarPausar.Margin = new System.Windows.Forms.Padding(2);
            this.btnIniciarPausar.Name = "btnIniciarPausar";
            this.btnIniciarPausar.Size = new System.Drawing.Size(86, 69);
            this.btnIniciarPausar.TabIndex = 24;
            this.btnIniciarPausar.Text = "Iniciar";
            this.btnIniciarPausar.UseVisualStyleBackColor = false;
            this.btnIniciarPausar.Visible = false;
            this.btnIniciarPausar.Click += new System.EventHandler(this.btnIniciarPausar_Click);
            // 
            // lblCronometro
            // 
            this.lblCronometro.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCronometro.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblCronometro.Location = new System.Drawing.Point(439, 129);
            this.lblCronometro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCronometro.Name = "lblCronometro";
            this.lblCronometro.Size = new System.Drawing.Size(317, 34);
            this.lblCronometro.TabIndex = 25;
            this.lblCronometro.Text = "00:00";
            this.lblCronometro.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblCronometro.Visible = false;
            this.lblCronometro.Click += new System.EventHandler(this.lblCronometro_Click);
            // 
            // TiempoActual
            // 
            this.TiempoActual.Tick += new System.EventHandler(this.TiempoActual_Tick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(835, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 38);
            this.button2.TabIndex = 33;
            this.button2.Text = "<--";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoFokus.Properties.Resources.Robosss;
            this.pictureBox1.Location = new System.Drawing.Point(413, 63);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(462, 266);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // CargarTareas
            // 
            this.CargarTareas.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CargarTareas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CargarTareas.ForeColor = System.Drawing.SystemColors.Control;
            this.CargarTareas.Location = new System.Drawing.Point(467, 13);
            this.CargarTareas.Margin = new System.Windows.Forms.Padding(2);
            this.CargarTareas.Name = "CargarTareas";
            this.CargarTareas.Size = new System.Drawing.Size(298, 37);
            this.CargarTareas.TabIndex = 1;
            this.CargarTareas.Text = "Cargar tareas";
            this.CargarTareas.UseVisualStyleBackColor = false;
            this.CargarTareas.Visible = false;
            this.CargarTareas.Click += new System.EventHandler(this.CargarTareas_Click);
            // 
            // FokusPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(907, 837);
            this.Controls.Add(this.CargarTareas);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblCronometro);
            this.Controls.Add(this.btnIniciarPausar);
            this.Controls.Add(this.PanelTareas);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Encuesta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FokusPrincipal";
            this.Text = "Fokus";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.Encuesta.ResumeLayout(false);
            this.Encuesta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.PanelTareas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox Encuesta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbProductividad;
        private System.Windows.Forms.RadioButton rdbAprender;
        private System.Windows.Forms.RadioButton rdbEjercicio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.FlowLayoutPanel PanelTareas;
        private System.Windows.Forms.Timer TareaTimer;
        private System.Windows.Forms.Button btnAgregarTarea;
        private System.Windows.Forms.Button btnIniciarPausar;
        private System.Windows.Forms.Label lblCronometro;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer TiempoActual;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button CargarTareas;
    }
}