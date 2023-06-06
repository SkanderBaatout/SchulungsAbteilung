namespace Essai.Forms
{
    partial class CustomMessageBox
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            labelMessage = new Label();
            button = new Button();
            SuspendLayout();
            // 
            // labelMessage
            // 
            labelMessage.AutoSize = true;
            labelMessage.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            labelMessage.ForeColor = Color.Teal;
            labelMessage.Location = new Point(310, 100);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new Size(58, 19);
            labelMessage.TabIndex = 0;
            labelMessage.Text = "label1";
            // 
            // button
            // 
            button.ForeColor = Color.White;
            button.Location = new Point(310, 181);
            button.Name = "button";
            button.Size = new Size(75, 23);
            button.TabIndex = 1;
            button.Text = "OK";
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click;
            // 
            // CustomMessageBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(button);
            Controls.Add(labelMessage);
            Location = new Point(110, 80);
            Name = "CustomMessageBox";
            Size = new Size(740, 235);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelMessage;
        private Button button;
    }
}
