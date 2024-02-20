namespace Atividade01_Aula_João
{
    partial class Menu
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
            label1 = new Label();
            cadastrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 192, 255);
            label1.Font = new Font("Lucida Handwriting", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(93, 53);
            label1.Name = "label1";
            label1.Size = new Size(84, 27);
            label1.TabIndex = 0;
            label1.Text = "MENU";
            label1.Click += label1_Click;
            // 
            // cadastrar
            // 
            cadastrar.BackColor = Color.FromArgb(255, 192, 255);
            cadastrar.Location = new Point(69, 150);
            cadastrar.Name = "cadastrar";
            cadastrar.Size = new Size(136, 23);
            cadastrar.TabIndex = 1;
            cadastrar.Text = "Cadastrar Empresa";
            cadastrar.UseVisualStyleBackColor = false;
            cadastrar.Click += button1_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(283, 283);
            Controls.Add(cadastrar);
            Controls.Add(label1);
            Name = "Menu";
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button cadastrar;
    }
}