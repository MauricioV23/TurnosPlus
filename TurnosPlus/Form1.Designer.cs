namespace TurnosPlus
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
            btnSolicitarTiquet = new Button();
            btnAbrirVista2 = new Button();
            SuspendLayout();
            // 
            // btnSolicitarTiquet
            // 
            btnSolicitarTiquet.Location = new Point(79, 280);
            btnSolicitarTiquet.Name = "btnSolicitarTiquet";
            btnSolicitarTiquet.Size = new Size(155, 57);
            btnSolicitarTiquet.TabIndex = 0;
            btnSolicitarTiquet.Text = "Solicitar Tiquet";
            btnSolicitarTiquet.UseVisualStyleBackColor = true;
            // 
            // btnAbrirVista2
            // 
            btnAbrirVista2.Location = new Point(330, 280);
            btnAbrirVista2.Name = "btnAbrirVista2";
            btnAbrirVista2.Size = new Size(170, 57);
            btnAbrirVista2.TabIndex = 1;
            btnAbrirVista2.Text = "Abrir Vista2";
            btnAbrirVista2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            ClientSize = new Size(780, 461);
            Controls.Add(btnAbrirVista2);
            Controls.Add(btnSolicitarTiquet);
            Name = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSolicitarTiquet;
        private Button btnAbrirVista2;
    }
}
