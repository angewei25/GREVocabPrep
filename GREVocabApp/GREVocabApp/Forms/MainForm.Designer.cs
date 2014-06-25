namespace GREVocabApp.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonQuiz = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.groupBoxDef = new System.Windows.Forms.GroupBox();
            this.listBoxWords = new System.Windows.Forms.ListBox();
            this.textBoxDefinition = new System.Windows.Forms.TextBox();
            this.buttonIncFreq = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxWord = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.groupBoxDef.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSave,
            this.toolStripButtonQuiz});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(361, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonQuiz
            // 
            this.toolStripButtonQuiz.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonQuiz.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonQuiz.Image")));
            this.toolStripButtonQuiz.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonQuiz.Name = "toolStripButtonQuiz";
            this.toolStripButtonQuiz.Size = new System.Drawing.Size(35, 22);
            this.toolStripButtonQuiz.Text = "Quiz";
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSave.Image")));
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(35, 22);
            this.toolStripButtonSave.Text = "Save";
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 25);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.listBoxWords);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.groupBox2);
            this.splitContainerMain.Panel2.Controls.Add(this.groupBoxDef);
            this.splitContainerMain.Size = new System.Drawing.Size(361, 407);
            this.splitContainerMain.SplitterDistance = 197;
            this.splitContainerMain.TabIndex = 1;
            // 
            // groupBoxDef
            // 
            this.groupBoxDef.Controls.Add(this.buttonIncFreq);
            this.groupBoxDef.Controls.Add(this.textBoxDefinition);
            this.groupBoxDef.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxDef.Location = new System.Drawing.Point(0, 55);
            this.groupBoxDef.Name = "groupBoxDef";
            this.groupBoxDef.Size = new System.Drawing.Size(160, 352);
            this.groupBoxDef.TabIndex = 0;
            this.groupBoxDef.TabStop = false;
            this.groupBoxDef.Text = "Definition:";
            // 
            // listBoxWords
            // 
            this.listBoxWords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxWords.FormattingEnabled = true;
            this.listBoxWords.Location = new System.Drawing.Point(0, 0);
            this.listBoxWords.Name = "listBoxWords";
            this.listBoxWords.Size = new System.Drawing.Size(197, 407);
            this.listBoxWords.TabIndex = 0;
            // 
            // textBoxDefinition
            // 
            this.textBoxDefinition.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxDefinition.Location = new System.Drawing.Point(3, 16);
            this.textBoxDefinition.Multiline = true;
            this.textBoxDefinition.Name = "textBoxDefinition";
            this.textBoxDefinition.ReadOnly = true;
            this.textBoxDefinition.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDefinition.Size = new System.Drawing.Size(154, 108);
            this.textBoxDefinition.TabIndex = 0;
            // 
            // buttonIncFreq
            // 
            this.buttonIncFreq.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonIncFreq.Location = new System.Drawing.Point(3, 124);
            this.buttonIncFreq.Name = "buttonIncFreq";
            this.buttonIncFreq.Size = new System.Drawing.Size(154, 20);
            this.buttonIncFreq.TabIndex = 1;
            this.buttonIncFreq.Text = "Increase Fequency";
            this.buttonIncFreq.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxWord);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(160, 49);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Word:";
            // 
            // textBoxWord
            // 
            this.textBoxWord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxWord.Location = new System.Drawing.Point(3, 16);
            this.textBoxWord.Name = "textBoxWord";
            this.textBoxWord.ReadOnly = true;
            this.textBoxWord.Size = new System.Drawing.Size(154, 20);
            this.textBoxWord.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 432);
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "GRE Vocabulay App";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.groupBoxDef.ResumeLayout(false);
            this.groupBoxDef.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripButton toolStripButtonQuiz;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.GroupBox groupBoxDef;
        private System.Windows.Forms.ListBox listBoxWords;
        private System.Windows.Forms.Button buttonIncFreq;
        private System.Windows.Forms.TextBox textBoxDefinition;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxWord;
    }
}

