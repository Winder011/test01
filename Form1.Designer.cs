namespace JuegoDe4Líneas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtJugador1 = new TextBox();
            txtJugador2 = new TextBox();
            btnAceptar = new Button();
            btnBorrar = new Button();
            SuspendLayout();
            // 
            // txtJugador1
            // 
            txtJugador1.Location = new Point(165, 104);
            txtJugador1.Name = "txtJugador1";
            txtJugador1.PlaceholderText = "Ingrese el nombre...";
            txtJugador1.Size = new Size(116, 23);
            txtJugador1.TabIndex = 0;
            // 
            // txtJugador2
            // 
            txtJugador2.Location = new Point(304, 104);
            txtJugador2.Name = "txtJugador2";
            txtJugador2.PlaceholderText = "Ingrese el nombre...";
            txtJugador2.Size = new Size(110, 23);
            txtJugador2.TabIndex = 1;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(206, 200);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(304, 200);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(75, 23);
            btnBorrar.TabIndex = 3;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBorrar);
            Controls.Add(btnAceptar);
            Controls.Add(txtJugador2);
            Controls.Add(txtJugador1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtJugador1;
        private TextBox txtJugador2;
        private Button btnAceptar;
        private Button btnBorrar;
    }
}
