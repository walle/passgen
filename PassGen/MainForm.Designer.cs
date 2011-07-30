namespace PassGen
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.saltTextbox = new System.Windows.Forms.TextBox();
            this.saltContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showSaltTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saltLabel = new System.Windows.Forms.Label();
            this.codeLabel = new System.Windows.Forms.Label();
            this.codeTextbox = new System.Windows.Forms.TextBox();
            this.codeContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showCodeTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputLabel = new System.Windows.Forms.Label();
            this.outputTextbox = new System.Windows.Forms.TextBox();
            this.outputContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showOutputTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateButton = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyButton = new System.Windows.Forms.Button();
            this.numberTrackBar = new System.Windows.Forms.TrackBar();
            this.numberLabel = new System.Windows.Forms.Label();
            this.charLabel = new System.Windows.Forms.Label();
            this.saltContextMenuStrip.SuspendLayout();
            this.codeContextMenuStrip.SuspendLayout();
            this.outputContextMenuStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // saltTextbox
            // 
            this.saltTextbox.ContextMenuStrip = this.saltContextMenuStrip;
            this.saltTextbox.Location = new System.Drawing.Point(15, 53);
            this.saltTextbox.Name = "saltTextbox";
            this.saltTextbox.Size = new System.Drawing.Size(411, 20);
            this.saltTextbox.TabIndex = 0;
            // 
            // saltContextMenuStrip
            // 
            this.saltContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showSaltTextToolStripMenuItem});
            this.saltContextMenuStrip.Name = "saltContextMenuStrip";
            this.saltContextMenuStrip.Size = new System.Drawing.Size(144, 26);
            // 
            // showSaltTextToolStripMenuItem
            // 
            this.showSaltTextToolStripMenuItem.Checked = true;
            this.showSaltTextToolStripMenuItem.CheckOnClick = true;
            this.showSaltTextToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showSaltTextToolStripMenuItem.Name = "showSaltTextToolStripMenuItem";
            this.showSaltTextToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.showSaltTextToolStripMenuItem.Text = "Show salt text";
            this.showSaltTextToolStripMenuItem.CheckedChanged += new System.EventHandler(this.showSaltTextToolStripMenuItem_CheckedChanged);
            // 
            // saltLabel
            // 
            this.saltLabel.AutoSize = true;
            this.saltLabel.Location = new System.Drawing.Point(12, 37);
            this.saltLabel.Name = "saltLabel";
            this.saltLabel.Size = new System.Drawing.Size(25, 13);
            this.saltLabel.TabIndex = 1;
            this.saltLabel.Text = "Salt";
            // 
            // codeLabel
            // 
            this.codeLabel.AutoSize = true;
            this.codeLabel.Location = new System.Drawing.Point(12, 85);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Size = new System.Drawing.Size(32, 13);
            this.codeLabel.TabIndex = 3;
            this.codeLabel.Text = "Code";
            // 
            // codeTextbox
            // 
            this.codeTextbox.ContextMenuStrip = this.codeContextMenuStrip;
            this.codeTextbox.Location = new System.Drawing.Point(15, 101);
            this.codeTextbox.Name = "codeTextbox";
            this.codeTextbox.Size = new System.Drawing.Size(411, 20);
            this.codeTextbox.TabIndex = 2;
            // 
            // codeContextMenuStrip
            // 
            this.codeContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showCodeTextToolStripMenuItem});
            this.codeContextMenuStrip.Name = "saltContextMenuStrip";
            this.codeContextMenuStrip.Size = new System.Drawing.Size(150, 26);
            // 
            // showCodeTextToolStripMenuItem
            // 
            this.showCodeTextToolStripMenuItem.Checked = true;
            this.showCodeTextToolStripMenuItem.CheckOnClick = true;
            this.showCodeTextToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showCodeTextToolStripMenuItem.Name = "showCodeTextToolStripMenuItem";
            this.showCodeTextToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.showCodeTextToolStripMenuItem.Text = "Show code text";
            this.showCodeTextToolStripMenuItem.CheckedChanged += new System.EventHandler(this.showCodeTextToolStripMenuItem_CheckedChanged);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(12, 188);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(39, 13);
            this.outputLabel.TabIndex = 5;
            this.outputLabel.Text = "Output";
            // 
            // outputTextbox
            // 
            this.outputTextbox.ContextMenuStrip = this.outputContextMenuStrip;
            this.outputTextbox.Location = new System.Drawing.Point(15, 204);
            this.outputTextbox.Name = "outputTextbox";
            this.outputTextbox.Size = new System.Drawing.Size(271, 20);
            this.outputTextbox.TabIndex = 4;
            // 
            // outputContextMenuStrip
            // 
            this.outputContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showOutputTextToolStripMenuItem});
            this.outputContextMenuStrip.Name = "saltContextMenuStrip";
            this.outputContextMenuStrip.Size = new System.Drawing.Size(159, 26);
            // 
            // showOutputTextToolStripMenuItem
            // 
            this.showOutputTextToolStripMenuItem.Checked = true;
            this.showOutputTextToolStripMenuItem.CheckOnClick = true;
            this.showOutputTextToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showOutputTextToolStripMenuItem.Name = "showOutputTextToolStripMenuItem";
            this.showOutputTextToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.showOutputTextToolStripMenuItem.Text = "Show output text";
            this.showOutputTextToolStripMenuItem.CheckedChanged += new System.EventHandler(this.showOutputTextToolStripMenuItem_CheckedChanged);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(299, 200);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(59, 24);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(450, 24);
            this.menuStrip.TabIndex = 7;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showTextToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // showTextToolStripMenuItem
            // 
            this.showTextToolStripMenuItem.Checked = true;
            this.showTextToolStripMenuItem.CheckOnClick = true;
            this.showTextToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showTextToolStripMenuItem.Name = "showTextToolStripMenuItem";
            this.showTextToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.showTextToolStripMenuItem.Text = "&Show text";
            this.showTextToolStripMenuItem.CheckedChanged += new System.EventHandler(this.showTextToolStripMenuItem_CheckedChanged);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(367, 200);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(59, 24);
            this.copyButton.TabIndex = 8;
            this.copyButton.Text = "Copy";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // numberTrackBar
            // 
            this.numberTrackBar.Location = new System.Drawing.Point(13, 143);
            this.numberTrackBar.Maximum = 32;
            this.numberTrackBar.Minimum = 1;
            this.numberTrackBar.Name = "numberTrackBar";
            this.numberTrackBar.Size = new System.Drawing.Size(388, 45);
            this.numberTrackBar.TabIndex = 9;
            this.numberTrackBar.Value = 1;
            this.numberTrackBar.Scroll += new System.EventHandler(this.numberTrackBar_Scroll);
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.numberLabel.Location = new System.Drawing.Point(401, 145);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Padding = new System.Windows.Forms.Padding(2);
            this.numberLabel.Size = new System.Drawing.Size(19, 19);
            this.numberLabel.TabIndex = 10;
            this.numberLabel.Text = "1";
            // 
            // charLabel
            // 
            this.charLabel.AutoSize = true;
            this.charLabel.Location = new System.Drawing.Point(15, 128);
            this.charLabel.Name = "charLabel";
            this.charLabel.Size = new System.Drawing.Size(109, 13);
            this.charLabel.TabIndex = 11;
            this.charLabel.Text = "Number of characters";
            // 
            // MainForm
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 251);
            this.Controls.Add(this.charLabel);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.outputTextbox);
            this.Controls.Add(this.codeLabel);
            this.Controls.Add(this.codeTextbox);
            this.Controls.Add(this.saltLabel);
            this.Controls.Add(this.saltTextbox);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.numberTrackBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "PassGen";
            this.saltContextMenuStrip.ResumeLayout(false);
            this.codeContextMenuStrip.ResumeLayout(false);
            this.outputContextMenuStrip.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox saltTextbox;
        private System.Windows.Forms.Label saltLabel;
        private System.Windows.Forms.Label codeLabel;
        private System.Windows.Forms.TextBox codeTextbox;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.TextBox outputTextbox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showTextToolStripMenuItem;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.ContextMenuStrip saltContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem showSaltTextToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip codeContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem showCodeTextToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip outputContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem showOutputTextToolStripMenuItem;
        private System.Windows.Forms.TrackBar numberTrackBar;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.Label charLabel;
    }
}

