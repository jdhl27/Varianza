namespace proyectoV2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResu = new System.Windows.Forms.Label();
            this.btnAgregarX = new System.Windows.Forms.Button();
            this.btnArray = new System.Windows.Forms.Button();
            this.lstX = new System.Windows.Forms.ListBox();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.lstVarianza = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.imgFlecha = new System.Windows.Forms.PictureBox();
            this.progreso = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFlecha)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Agency FB", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(78, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 77);
            this.label1.TabIndex = 0;
            this.label1.Text = "VARIANZA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(35, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese X:";
            // 
            // txtX
            // 
            this.txtX.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtX.Enabled = false;
            this.txtX.Location = new System.Drawing.Point(123, 167);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 20);
            this.txtX.TabIndex = 2;
            // 
            // txtN
            // 
            this.txtN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN.Location = new System.Drawing.Point(123, 127);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 22);
            this.txtN.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(35, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ingrese N:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Coral;
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.Enabled = false;
            this.btnCalcular.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCalcular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCalcular.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Location = new System.Drawing.Point(137, 213);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblResu
            // 
            this.lblResu.AutoSize = true;
            this.lblResu.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblResu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResu.ForeColor = System.Drawing.Color.White;
            this.lblResu.Location = new System.Drawing.Point(120, 252);
            this.lblResu.Name = "lblResu";
            this.lblResu.Size = new System.Drawing.Size(0, 16);
            this.lblResu.TabIndex = 6;
            // 
            // btnAgregarX
            // 
            this.btnAgregarX.BackColor = System.Drawing.Color.Coral;
            this.btnAgregarX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarX.Enabled = false;
            this.btnAgregarX.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAgregarX.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAgregarX.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAgregarX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarX.Location = new System.Drawing.Point(255, 163);
            this.btnAgregarX.Name = "btnAgregarX";
            this.btnAgregarX.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarX.TabIndex = 7;
            this.btnAgregarX.Text = "AGREGAR X";
            this.btnAgregarX.UseVisualStyleBackColor = false;
            this.btnAgregarX.Click += new System.EventHandler(this.btnAgregarX_Click);
            // 
            // btnArray
            // 
            this.btnArray.BackColor = System.Drawing.Color.Coral;
            this.btnArray.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArray.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnArray.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnArray.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnArray.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArray.Location = new System.Drawing.Point(255, 123);
            this.btnArray.Name = "btnArray";
            this.btnArray.Size = new System.Drawing.Size(75, 23);
            this.btnArray.TabIndex = 8;
            this.btnArray.Text = "CREAR ARRAY";
            this.btnArray.UseVisualStyleBackColor = false;
            this.btnArray.Click += new System.EventHandler(this.btnArray_Click);
            // 
            // lstX
            // 
            this.lstX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstX.FormattingEnabled = true;
            this.lstX.ItemHeight = 16;
            this.lstX.Location = new System.Drawing.Point(39, 301);
            this.lstX.Name = "lstX";
            this.lstX.Size = new System.Drawing.Size(56, 130);
            this.lstX.TabIndex = 9;
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(39, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Datos X:";
            // 
            // lstVarianza
            // 
            this.lstVarianza.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstVarianza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstVarianza.FormattingEnabled = true;
            this.lstVarianza.ItemHeight = 16;
            this.lstVarianza.Location = new System.Drawing.Point(160, 301);
            this.lstVarianza.Name = "lstVarianza";
            this.lstVarianza.Size = new System.Drawing.Size(162, 130);
            this.lstVarianza.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(157, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "VARIANZAS CALCULADAS:";
            // 
            // imgFlecha
            // 
            this.imgFlecha.BackColor = System.Drawing.Color.Transparent;
            this.imgFlecha.Enabled = false;
            this.imgFlecha.Image = ((System.Drawing.Image)(resources.GetObject("imgFlecha.Image")));
            this.imgFlecha.Location = new System.Drawing.Point(218, 213);
            this.imgFlecha.Name = "imgFlecha";
            this.imgFlecha.Size = new System.Drawing.Size(69, 32);
            this.imgFlecha.TabIndex = 13;
            this.imgFlecha.TabStop = false;
            this.imgFlecha.Visible = false;
            // 
            // progreso
            // 
            this.progreso.BackColor = System.Drawing.Color.Blue;
            this.progreso.Dock = System.Windows.Forms.DockStyle.Top;
            this.progreso.Location = new System.Drawing.Point(0, 0);
            this.progreso.MarqueeAnimationSpeed = 60;
            this.progreso.Name = "progreso";
            this.progreso.Size = new System.Drawing.Size(384, 10);
            this.progreso.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(384, 456);
            this.Controls.Add(this.progreso);
            this.Controls.Add(this.imgFlecha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lstVarianza);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstX);
            this.Controls.Add(this.btnArray);
            this.Controls.Add(this.btnAgregarX);
            this.Controls.Add(this.lblResu);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "VARIANZA";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFlecha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResu;
        private System.Windows.Forms.Button btnAgregarX;
        private System.Windows.Forms.Button btnArray;
        private System.Windows.Forms.ListBox lstX;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstVarianza;
        private System.Windows.Forms.PictureBox imgFlecha;
        private System.Windows.Forms.ProgressBar progreso;
    }
}

