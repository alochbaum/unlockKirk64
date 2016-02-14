namespace unlockKirk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rTBIncoming = new System.Windows.Forms.RichTextBox();
            this.rTBoutgoing = new System.Windows.Forms.RichTextBox();
            this.btDecode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rTBIncoming
            // 
            this.rTBIncoming.Location = new System.Drawing.Point(19, 14);
            this.rTBIncoming.Name = "rTBIncoming";
            this.rTBIncoming.Size = new System.Drawing.Size(728, 227);
            this.rTBIncoming.TabIndex = 0;
            this.rTBIncoming.Text = resources.GetString("rTBIncoming.Text");
            // 
            // rTBoutgoing
            // 
            this.rTBoutgoing.Location = new System.Drawing.Point(19, 280);
            this.rTBoutgoing.Name = "rTBoutgoing";
            this.rTBoutgoing.Size = new System.Drawing.Size(728, 227);
            this.rTBoutgoing.TabIndex = 0;
            this.rTBoutgoing.Text = "";
            // 
            // btDecode
            // 
            this.btDecode.Location = new System.Drawing.Point(25, 249);
            this.btDecode.Name = "btDecode";
            this.btDecode.Size = new System.Drawing.Size(138, 21);
            this.btDecode.TabIndex = 1;
            this.btDecode.Text = "Decode";
            this.btDecode.UseVisualStyleBackColor = true;
            this.btDecode.Click += new System.EventHandler(this.btDecode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 519);
            this.Controls.Add(this.btDecode);
            this.Controls.Add(this.rTBoutgoing);
            this.Controls.Add(this.rTBIncoming);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rTBIncoming;
        private System.Windows.Forms.RichTextBox rTBoutgoing;
        private System.Windows.Forms.Button btDecode;
    }
}

