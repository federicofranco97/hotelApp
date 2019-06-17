namespace hotelApp
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPrincipal = new System.Windows.Forms.TabPage();
            this.listCuartos = new System.Windows.Forms.ListView();
            this.NumeroCuarto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Categoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Estado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IDCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.tabIn = new System.Windows.Forms.TabPage();
            this.tabOut = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPrincipal);
            this.tabControl.Controls.Add(this.tabIn);
            this.tabControl.Controls.Add(this.tabOut);
            this.tabControl.Location = new System.Drawing.Point(-6, 2);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1210, 694);
            this.tabControl.TabIndex = 0;
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Controls.Add(this.button2);
            this.tabPrincipal.Controls.Add(this.label1);
            this.tabPrincipal.Controls.Add(this.listCuartos);
            this.tabPrincipal.Controls.Add(this.button1);
            this.tabPrincipal.Location = new System.Drawing.Point(4, 29);
            this.tabPrincipal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPrincipal.Size = new System.Drawing.Size(1202, 661);
            this.tabPrincipal.TabIndex = 0;
            this.tabPrincipal.Text = "Principal";
            this.tabPrincipal.UseVisualStyleBackColor = true;
            // 
            // listCuartos
            // 
            this.listCuartos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NumeroCuarto,
            this.Categoria,
            this.Estado,
            this.IDCliente});
            this.listCuartos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listCuartos.Location = new System.Drawing.Point(82, 170);
            this.listCuartos.Name = "listCuartos";
            this.listCuartos.Size = new System.Drawing.Size(534, 388);
            this.listCuartos.TabIndex = 2;
            this.listCuartos.UseCompatibleStateImageBehavior = false;
            // 
            // NumeroCuarto
            // 
            this.NumeroCuarto.Text = "Cuarto";
            this.NumeroCuarto.Width = 80;
            // 
            // Categoria
            // 
            this.Categoria.Text = "Categoria";
            this.Categoria.Width = 90;
            // 
            // Estado
            // 
            this.Estado.Text = "Estado";
            this.Estado.Width = 110;
            // 
            // IDCliente
            // 
            this.IDCliente.Text = "ID Cliente";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(890, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "Prueba clasedb";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabIn
            // 
            this.tabIn.Location = new System.Drawing.Point(4, 29);
            this.tabIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabIn.Name = "tabIn";
            this.tabIn.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabIn.Size = new System.Drawing.Size(1202, 661);
            this.tabIn.TabIndex = 1;
            this.tabIn.Text = "Check In";
            this.tabIn.UseVisualStyleBackColor = true;
            // 
            // tabOut
            // 
            this.tabOut.Location = new System.Drawing.Point(4, 29);
            this.tabOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabOut.Name = "tabOut";
            this.tabOut.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabOut.Size = new System.Drawing.Size(1202, 661);
            this.tabOut.TabIndex = 2;
            this.tabOut.Text = "Check Out";
            this.tabOut.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lista de los Cuartos";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(890, 315);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 48);
            this.button2.TabIndex = 4;
            this.button2.Text = "Rentar Cuarto";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "HotelApp";
            this.tabControl.ResumeLayout(false);
            this.tabPrincipal.ResumeLayout(false);
            this.tabPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPrincipal;
        private System.Windows.Forms.TabPage tabIn;
        private System.Windows.Forms.TabPage tabOut;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listCuartos;
        private System.Windows.Forms.ColumnHeader NumeroCuarto;
        private System.Windows.Forms.ColumnHeader Categoria;
        private System.Windows.Forms.ColumnHeader Estado;
        private System.Windows.Forms.ColumnHeader IDCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}

