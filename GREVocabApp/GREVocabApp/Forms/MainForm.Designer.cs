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
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonQuiz = new System.Windows.Forms.ToolStripButton();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.listBoxWords = new System.Windows.Forms.ListBox();
            this.splitContainerWord = new System.Windows.Forms.SplitContainer();
            this.groupBoxWord = new System.Windows.Forms.GroupBox();
            this.textBoxWord = new System.Windows.Forms.TextBox();
            this.splitContainerDef = new System.Windows.Forms.SplitContainer();
            this.groupBoxDef = new System.Windows.Forms.GroupBox();
            this.textBoxDefinition = new System.Windows.Forms.TextBox();
            this.buttonIncFreq = new System.Windows.Forms.Button();
            this.groupBoxSentence = new System.Windows.Forms.GroupBox();
            this.textBoxSentence = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerWord)).BeginInit();
            this.splitContainerWord.Panel1.SuspendLayout();
            this.splitContainerWord.Panel2.SuspendLayout();
            this.splitContainerWord.SuspendLayout();
            this.groupBoxWord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDef)).BeginInit();
            this.splitContainerDef.Panel1.SuspendLayout();
            this.splitContainerDef.Panel2.SuspendLayout();
            this.splitContainerDef.SuspendLayout();
            this.groupBoxDef.SuspendLayout();
            this.groupBoxSentence.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSave,
            this.toolStripButtonQuiz});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(398, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
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
            // toolStripButtonQuiz
            // 
            this.toolStripButtonQuiz.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonQuiz.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonQuiz.Image")));
            this.toolStripButtonQuiz.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonQuiz.Name = "toolStripButtonQuiz";
            this.toolStripButtonQuiz.Size = new System.Drawing.Size(35, 22);
            this.toolStripButtonQuiz.Text = "Quiz";
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 25);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.AutoScroll = true;
            this.splitContainerMain.Panel1.Controls.Add(this.listBoxWords);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.splitContainerWord);
            this.splitContainerMain.Size = new System.Drawing.Size(398, 407);
            this.splitContainerMain.SplitterDistance = 194;
            this.splitContainerMain.TabIndex = 1;
            // 
            // listBoxWords
            // 
            this.listBoxWords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxWords.FormattingEnabled = true;
            this.listBoxWords.Location = new System.Drawing.Point(0, 0);
            this.listBoxWords.Name = "listBoxWords";
            this.listBoxWords.Size = new System.Drawing.Size(194, 407);
            this.listBoxWords.TabIndex = 0;
            this.listBoxWords.SelectedValueChanged += new System.EventHandler(this.listBoxWords_SelectedValueChanged);
            // 
            // splitContainerWord
            // 
            this.splitContainerWord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerWord.Location = new System.Drawing.Point(0, 0);
            this.splitContainerWord.Name = "splitContainerWord";
            this.splitContainerWord.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerWord.Panel1
            // 
            this.splitContainerWord.Panel1.Controls.Add(this.groupBoxWord);
            // 
            // splitContainerWord.Panel2
            // 
            this.splitContainerWord.Panel2.Controls.Add(this.splitContainerDef);
            this.splitContainerWord.Size = new System.Drawing.Size(200, 407);
            this.splitContainerWord.SplitterDistance = 44;
            this.splitContainerWord.TabIndex = 0;
            // 
            // groupBoxWord
            // 
            this.groupBoxWord.Controls.Add(this.textBoxWord);
            this.groupBoxWord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxWord.Location = new System.Drawing.Point(0, 0);
            this.groupBoxWord.Name = "groupBoxWord";
            this.groupBoxWord.Size = new System.Drawing.Size(200, 44);
            this.groupBoxWord.TabIndex = 1;
            this.groupBoxWord.TabStop = false;
            this.groupBoxWord.Text = "Word:";
            // 
            // textBoxWord
            // 
            this.textBoxWord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxWord.Location = new System.Drawing.Point(3, 16);
            this.textBoxWord.Name = "textBoxWord";
            this.textBoxWord.ReadOnly = true;
            this.textBoxWord.Size = new System.Drawing.Size(194, 20);
            this.textBoxWord.TabIndex = 0;
            // 
            // splitContainerDef
            // 
            this.splitContainerDef.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerDef.Location = new System.Drawing.Point(0, 0);
            this.splitContainerDef.Name = "splitContainerDef";
            this.splitContainerDef.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerDef.Panel1
            // 
            this.splitContainerDef.Panel1.Controls.Add(this.groupBoxDef);
            // 
            // splitContainerDef.Panel2
            // 
            this.splitContainerDef.Panel2.Controls.Add(this.buttonIncFreq);
            this.splitContainerDef.Panel2.Controls.Add(this.groupBoxSentence);
            this.splitContainerDef.Size = new System.Drawing.Size(200, 359);
            this.splitContainerDef.SplitterDistance = 67;
            this.splitContainerDef.TabIndex = 0;
            // 
            // groupBoxDef
            // 
            this.groupBoxDef.Controls.Add(this.textBoxDefinition);
            this.groupBoxDef.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDef.Location = new System.Drawing.Point(0, 0);
            this.groupBoxDef.Name = "groupBoxDef";
            this.groupBoxDef.Size = new System.Drawing.Size(200, 67);
            this.groupBoxDef.TabIndex = 0;
            this.groupBoxDef.TabStop = false;
            this.groupBoxDef.Text = "Definition:";
            // 
            // textBoxDefinition
            // 
            this.textBoxDefinition.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxDefinition.Location = new System.Drawing.Point(3, 16);
            this.textBoxDefinition.Multiline = true;
            this.textBoxDefinition.Name = "textBoxDefinition";
            this.textBoxDefinition.ReadOnly = true;
            this.textBoxDefinition.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDefinition.Size = new System.Drawing.Size(194, 51);
            this.textBoxDefinition.TabIndex = 0;
            // 
            // buttonIncFreq
            // 
            this.buttonIncFreq.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonIncFreq.Location = new System.Drawing.Point(0, 126);
            this.buttonIncFreq.Name = "buttonIncFreq";
            this.buttonIncFreq.Size = new System.Drawing.Size(200, 20);
            this.buttonIncFreq.TabIndex = 1;
            this.buttonIncFreq.Text = "Increase Fequency";
            this.buttonIncFreq.UseVisualStyleBackColor = true;
            this.buttonIncFreq.Click += new System.EventHandler(this.buttonIncFreq_Click);
            // 
            // groupBoxSentence
            // 
            this.groupBoxSentence.Controls.Add(this.textBoxSentence);
            this.groupBoxSentence.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxSentence.Location = new System.Drawing.Point(0, 0);
            this.groupBoxSentence.Name = "groupBoxSentence";
            this.groupBoxSentence.Size = new System.Drawing.Size(200, 126);
            this.groupBoxSentence.TabIndex = 2;
            this.groupBoxSentence.TabStop = false;
            this.groupBoxSentence.Text = "Sample Sentence:";
            // 
            // textBoxSentence
            // 
            this.textBoxSentence.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxSentence.Location = new System.Drawing.Point(3, 16);
            this.textBoxSentence.Multiline = true;
            this.textBoxSentence.Name = "textBoxSentence";
            this.textBoxSentence.ReadOnly = true;
            this.textBoxSentence.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSentence.Size = new System.Drawing.Size(194, 108);
            this.textBoxSentence.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 432);
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
            this.splitContainerWord.Panel1.ResumeLayout(false);
            this.splitContainerWord.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerWord)).EndInit();
            this.splitContainerWord.ResumeLayout(false);
            this.groupBoxWord.ResumeLayout(false);
            this.groupBoxWord.PerformLayout();
            this.splitContainerDef.Panel1.ResumeLayout(false);
            this.splitContainerDef.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDef)).EndInit();
            this.splitContainerDef.ResumeLayout(false);
            this.groupBoxDef.ResumeLayout(false);
            this.groupBoxDef.PerformLayout();
            this.groupBoxSentence.ResumeLayout(false);
            this.groupBoxSentence.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBoxWord;
        private System.Windows.Forms.TextBox textBoxWord;
        private System.Windows.Forms.GroupBox groupBoxSentence;
        private System.Windows.Forms.TextBox textBoxSentence;
        private System.Windows.Forms.SplitContainer splitContainerWord;
        private System.Windows.Forms.SplitContainer splitContainerDef;
    }
}

