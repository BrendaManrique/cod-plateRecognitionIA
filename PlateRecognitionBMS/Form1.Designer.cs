namespace PlateRecognitionBMS
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_binariza = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btn_separar = new System.Windows.Forms.Button();
            this.btn_5x7 = new System.Windows.Forms.Button();
            this.btn_reconocer = new System.Windows.Forms.Button();
            this.btn_izq = new System.Windows.Forms.Button();
            this.btn_der = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(396, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_binariza
            // 
            this.btn_binariza.Location = new System.Drawing.Point(319, 34);
            this.btn_binariza.Name = "btn_binariza";
            this.btn_binariza.Size = new System.Drawing.Size(71, 299);
            this.btn_binariza.TabIndex = 1;
            this.btn_binariza.Text = "Binariza";
            this.btn_binariza.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(13, 34);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(300, 300);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btn_binariza);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(714, 352);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Imagen";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_der);
            this.groupBox2.Controls.Add(this.btn_izq);
            this.groupBox2.Controls.Add(this.btn_reconocer);
            this.groupBox2.Controls.Add(this.btn_5x7);
            this.groupBox2.Controls.Add(this.btn_separar);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Location = new System.Drawing.Point(745, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(324, 352);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reconocimiento";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Location = new System.Drawing.Point(15, 34);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(150, 210);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // btn_separar
            // 
            this.btn_separar.Location = new System.Drawing.Point(200, 34);
            this.btn_separar.Name = "btn_separar";
            this.btn_separar.Size = new System.Drawing.Size(102, 37);
            this.btn_separar.TabIndex = 1;
            this.btn_separar.Text = "Separar";
            this.btn_separar.UseVisualStyleBackColor = true;
            // 
            // btn_5x7
            // 
            this.btn_5x7.Location = new System.Drawing.Point(200, 89);
            this.btn_5x7.Name = "btn_5x7";
            this.btn_5x7.Size = new System.Drawing.Size(102, 37);
            this.btn_5x7.TabIndex = 2;
            this.btn_5x7.Text = "5x7";
            this.btn_5x7.UseVisualStyleBackColor = true;
            // 
            // btn_reconocer
            // 
            this.btn_reconocer.Location = new System.Drawing.Point(200, 149);
            this.btn_reconocer.Name = "btn_reconocer";
            this.btn_reconocer.Size = new System.Drawing.Size(102, 37);
            this.btn_reconocer.TabIndex = 3;
            this.btn_reconocer.Text = "Reconocer";
            this.btn_reconocer.UseVisualStyleBackColor = true;
            // 
            // btn_izq
            // 
            this.btn_izq.Location = new System.Drawing.Point(15, 245);
            this.btn_izq.Name = "btn_izq";
            this.btn_izq.Size = new System.Drawing.Size(63, 22);
            this.btn_izq.TabIndex = 4;
            this.btn_izq.Text = "<<";
            this.btn_izq.UseVisualStyleBackColor = true;
            // 
            // btn_der
            // 
            this.btn_der.Location = new System.Drawing.Point(102, 245);
            this.btn_der.Name = "btn_der";
            this.btn_der.Size = new System.Drawing.Size(63, 23);
            this.btn_der.TabIndex = 5;
            this.btn_der.Text = ">>";
            this.btn_der.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 423);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_binariza;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btn_5x7;
        private System.Windows.Forms.Button btn_separar;
        private System.Windows.Forms.Button btn_der;
        private System.Windows.Forms.Button btn_izq;
        private System.Windows.Forms.Button btn_reconocer;
    }
}

