namespace test
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
            this.btnocultar = new System.Windows.Forms.Button();
            this.btnmostrar = new System.Windows.Forms.Button();
            this.txtimagen = new System.Windows.Forms.TextBox();
            this.pbimagen5 = new System.Windows.Forms.PictureBox();
            this.pbimagen4 = new System.Windows.Forms.PictureBox();
            this.pbimagen3 = new System.Windows.Forms.PictureBox();
            this.pbimagen1 = new System.Windows.Forms.PictureBox();
            this.pbimagen2 = new System.Windows.Forms.PictureBox();
            this.mostrartodos = new System.Windows.Forms.Button();
            this.ocultartodo = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbimagen5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbimagen4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbimagen3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbimagen1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbimagen2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnocultar
            // 
            this.btnocultar.Location = new System.Drawing.Point(208, 418);
            this.btnocultar.Name = "btnocultar";
            this.btnocultar.Size = new System.Drawing.Size(75, 23);
            this.btnocultar.TabIndex = 6;
            this.btnocultar.Text = "Ocultar";
            this.btnocultar.UseVisualStyleBackColor = true;
            this.btnocultar.Click += new System.EventHandler(this.btnocultar_Click);
            // 
            // btnmostrar
            // 
            this.btnmostrar.Location = new System.Drawing.Point(208, 379);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Size = new System.Drawing.Size(75, 23);
            this.btnmostrar.TabIndex = 7;
            this.btnmostrar.Text = "Mostrar";
            this.btnmostrar.UseVisualStyleBackColor = true;
            this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click);
            // 
            // txtimagen
            // 
            this.txtimagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtimagen.Location = new System.Drawing.Point(289, 379);
            this.txtimagen.Name = "txtimagen";
            this.txtimagen.Size = new System.Drawing.Size(178, 62);
            this.txtimagen.TabIndex = 0;
            // 
            // pbimagen5
            // 
            this.pbimagen5.Image = global::test.Properties.Resources._587187927b7f6103e35c6cd5;
            this.pbimagen5.Location = new System.Drawing.Point(49, 183);
            this.pbimagen5.Name = "pbimagen5";
            this.pbimagen5.Size = new System.Drawing.Size(234, 147);
            this.pbimagen5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbimagen5.TabIndex = 13;
            this.pbimagen5.TabStop = false;
            this.pbimagen5.DoubleClick += new System.EventHandler(this.pbimagen5_DoubleClick);
            // 
            // pbimagen4
            // 
            this.pbimagen4.Image = global::test.Properties.Resources._58429977a6515b1e0ad75ade;
            this.pbimagen4.Location = new System.Drawing.Point(440, 22);
            this.pbimagen4.Name = "pbimagen4";
            this.pbimagen4.Size = new System.Drawing.Size(185, 144);
            this.pbimagen4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbimagen4.TabIndex = 12;
            this.pbimagen4.TabStop = false;
            this.pbimagen4.DoubleClick += new System.EventHandler(this.pbimagen4_DoubleClick);
            // 
            // pbimagen3
            // 
            this.pbimagen3.Image = global::test.Properties.Resources._584298bca6515b1e0ad75adc;
            this.pbimagen3.Location = new System.Drawing.Point(134, 22);
            this.pbimagen3.Name = "pbimagen3";
            this.pbimagen3.Size = new System.Drawing.Size(211, 144);
            this.pbimagen3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbimagen3.TabIndex = 11;
            this.pbimagen3.TabStop = false;
            this.pbimagen3.DoubleClick += new System.EventHandler(this.pbimagen3_DoubleClick);
            // 
            // pbimagen1
            // 
            this.pbimagen1.Image = global::test.Properties.Resources._580b57fcd9996e24bc43c1dc;
            this.pbimagen1.Location = new System.Drawing.Point(505, 183);
            this.pbimagen1.Name = "pbimagen1";
            this.pbimagen1.Size = new System.Drawing.Size(203, 147);
            this.pbimagen1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbimagen1.TabIndex = 10;
            this.pbimagen1.TabStop = false;
            this.pbimagen1.Click += new System.EventHandler(this.pbimagen1_Click);
            // 
            // pbimagen2
            // 
            this.pbimagen2.Image = global::test.Properties.Resources._58737bd3f3a71010b5e8ef37;
            this.pbimagen2.Location = new System.Drawing.Point(300, 183);
            this.pbimagen2.Name = "pbimagen2";
            this.pbimagen2.Size = new System.Drawing.Size(189, 147);
            this.pbimagen2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbimagen2.TabIndex = 9;
            this.pbimagen2.TabStop = false;
            this.pbimagen2.DoubleClick += new System.EventHandler(this.pbimagen2_DoubleClick);
            // 
            // mostrartodos
            // 
            this.mostrartodos.Location = new System.Drawing.Point(473, 379);
            this.mostrartodos.Name = "mostrartodos";
            this.mostrartodos.Size = new System.Drawing.Size(98, 26);
            this.mostrartodos.TabIndex = 14;
            this.mostrartodos.Text = "Mostrar todos";
            this.mostrartodos.UseVisualStyleBackColor = true;
            this.mostrartodos.Click += new System.EventHandler(this.mostrartodos_Click);
            // 
            // ocultartodo
            // 
            this.ocultartodo.Location = new System.Drawing.Point(473, 418);
            this.ocultartodo.Name = "ocultartodo";
            this.ocultartodo.Size = new System.Drawing.Size(98, 23);
            this.ocultartodo.TabIndex = 15;
            this.ocultartodo.Text = "Ocultar todos";
            this.ocultartodo.UseVisualStyleBackColor = true;
            this.ocultartodo.Click += new System.EventHandler(this.ocultartodo_Click);
            // 
            // info
            // 
            this.info.Location = new System.Drawing.Point(698, 379);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(88, 23);
            this.info.TabIndex = 16;
            this.info.Text = "Instrucciones.";
            this.info.UseVisualStyleBackColor = true;
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 443);
            this.Controls.Add(this.info);
            this.Controls.Add(this.ocultartodo);
            this.Controls.Add(this.mostrartodos);
            this.Controls.Add(this.pbimagen5);
            this.Controls.Add(this.pbimagen4);
            this.Controls.Add(this.pbimagen3);
            this.Controls.Add(this.pbimagen1);
            this.Controls.Add(this.pbimagen2);
            this.Controls.Add(this.txtimagen);
            this.Controls.Add(this.btnmostrar);
            this.Controls.Add(this.btnocultar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbimagen5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbimagen4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbimagen3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbimagen1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbimagen2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnocultar;
        private System.Windows.Forms.Button btnmostrar;
        private System.Windows.Forms.TextBox txtimagen;
        private System.Windows.Forms.PictureBox pbimagen2;
        private System.Windows.Forms.PictureBox pbimagen1;
        private System.Windows.Forms.PictureBox pbimagen3;
        private System.Windows.Forms.PictureBox pbimagen4;
        private System.Windows.Forms.PictureBox pbimagen5;
        private System.Windows.Forms.Button mostrartodos;
        private System.Windows.Forms.Button ocultartodo;
        private System.Windows.Forms.Button info;
    }
}

