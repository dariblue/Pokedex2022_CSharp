namespace Pokedex2022_CSharp
{
    partial class VentannaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentannaPrincipal));
            this.Derecha = new System.Windows.Forms.Button();
            this.Izquierda = new System.Windows.Forms.Button();
            this.nombrePokemon = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.detalles = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Derecha
            // 
            this.Derecha.BackColor = System.Drawing.Color.Transparent;
            this.Derecha.Cursor = System.Windows.Forms.Cursors.PanEast;
            this.Derecha.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Derecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Derecha.ForeColor = System.Drawing.Color.Transparent;
            this.Derecha.Location = new System.Drawing.Point(74, 531);
            this.Derecha.Name = "Derecha";
            this.Derecha.Size = new System.Drawing.Size(39, 32);
            this.Derecha.TabIndex = 0;
            this.Derecha.Text = " ";
            this.Derecha.UseVisualStyleBackColor = false;
            this.Derecha.Click += new System.EventHandler(this.Derecha_Click);
            // 
            // Izquierda
            // 
            this.Izquierda.BackColor = System.Drawing.Color.Transparent;
            this.Izquierda.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.Izquierda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Izquierda.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Izquierda.Location = new System.Drawing.Point(28, 531);
            this.Izquierda.Name = "Izquierda";
            this.Izquierda.Size = new System.Drawing.Size(39, 31);
            this.Izquierda.TabIndex = 2;
            this.Izquierda.Text = " ";
            this.Izquierda.UseVisualStyleBackColor = false;
            this.Izquierda.Click += new System.EventHandler(this.Izquierda_Click);
            // 
            // nombrePokemon
            // 
            this.nombrePokemon.BackColor = System.Drawing.Color.Transparent;
            this.nombrePokemon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nombrePokemon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombrePokemon.Location = new System.Drawing.Point(132, 516);
            this.nombrePokemon.Name = "nombrePokemon";
            this.nombrePokemon.Size = new System.Drawing.Size(166, 64);
            this.nombrePokemon.TabIndex = 3;
            this.nombrePokemon.Text = "label1";
            this.nombrePokemon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(51, 139);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(308, 264);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // detalles
            // 
            this.detalles.BackColor = System.Drawing.Color.Transparent;
            this.detalles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.detalles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.detalles.FlatAppearance.BorderSize = 0;
            this.detalles.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.detalles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.detalles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.detalles.ForeColor = System.Drawing.Color.Transparent;
            this.detalles.Location = new System.Drawing.Point(320, 33);
            this.detalles.Name = "detalles";
            this.detalles.Size = new System.Drawing.Size(61, 61);
            this.detalles.TabIndex = 4;
            this.detalles.Text = " ";
            this.detalles.UseVisualStyleBackColor = false;
            this.detalles.Click += new System.EventHandler(this.detalles_Click);
            // 
            // VentannaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(411, 620);
            this.Controls.Add(this.detalles);
            this.Controls.Add(this.nombrePokemon);
            this.Controls.Add(this.Izquierda);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Derecha);
            this.DoubleBuffered = true;
            this.Name = "VentannaPrincipal";
            this.Text = "Form1";
            this.BackColorChanged += new System.EventHandler(this.Izquierda_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Derecha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Izquierda;
        private System.Windows.Forms.Label nombrePokemon;
        private System.Windows.Forms.Button detalles;
    }
}

