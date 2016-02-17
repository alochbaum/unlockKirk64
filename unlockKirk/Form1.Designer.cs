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
            this.btnDecode = new System.Windows.Forms.Button();
            this.cbWriteOutHex = new System.Windows.Forms.CheckBox();
            this.btnTestHeader = new System.Windows.Forms.Button();
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
            this.rTBoutgoing.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTBoutgoing.Location = new System.Drawing.Point(19, 280);
            this.rTBoutgoing.Name = "rTBoutgoing";
            this.rTBoutgoing.Size = new System.Drawing.Size(728, 227);
            this.rTBoutgoing.TabIndex = 0;
            this.rTBoutgoing.Text = "";
            // 
            // btnDecode
            // 
            this.btnDecode.Location = new System.Drawing.Point(19, 248);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(125, 26);
            this.btnDecode.TabIndex = 1;
            this.btnDecode.Text = "Decode";
            this.btnDecode.UseVisualStyleBackColor = true;
            this.btnDecode.Click += new System.EventHandler(this.btDecode_Click);
            // 
            // cbWriteOutHex
            // 
            this.cbWriteOutHex.AutoSize = true;
            this.cbWriteOutHex.Checked = true;
            this.cbWriteOutHex.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbWriteOutHex.Location = new System.Drawing.Point(164, 256);
            this.cbWriteOutHex.Name = "cbWriteOutHex";
            this.cbWriteOutHex.Size = new System.Drawing.Size(93, 17);
            this.cbWriteOutHex.TabIndex = 2;
            this.cbWriteOutHex.Text = "Write Out Hex";
            this.cbWriteOutHex.UseVisualStyleBackColor = true;
            // 
            // btnTestHeader
            // 
            this.btnTestHeader.Location = new System.Drawing.Point(275, 248);
            this.btnTestHeader.Name = "btnTestHeader";
            this.btnTestHeader.Size = new System.Drawing.Size(89, 23);
            this.btnTestHeader.TabIndex = 3;
            this.btnTestHeader.Text = "test Header";
            this.btnTestHeader.UseVisualStyleBackColor = true;
            this.btnTestHeader.Click += new System.EventHandler(this.btnTestHeader_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 519);
            this.Controls.Add(this.btnTestHeader);
            this.Controls.Add(this.cbWriteOutHex);
            this.Controls.Add(this.btnDecode);
            this.Controls.Add(this.rTBoutgoing);
            this.Controls.Add(this.rTBIncoming);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rTBIncoming;
        private System.Windows.Forms.RichTextBox rTBoutgoing;
        private System.Windows.Forms.Button btnDecode;
        private System.Windows.Forms.CheckBox cbWriteOutHex;
        private System.Windows.Forms.Button btnTestHeader;
    }
}

