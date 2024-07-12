namespace HSDRawViewer
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
            treeView1 = new System.Windows.Forms.TreeView();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saveAsUnoptimizedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            addNodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            fromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            fromDATFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            fromTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            trimExcessDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            propertyViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            aJToolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            sSMEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            sEMEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            selectAudioPlaybackDeviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            LocationLabel = new System.Windows.Forms.Label();
            dockPanel = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            showHideButton = new System.Windows.Forms.Button();
            nodeBox = new System.Windows.Forms.GroupBox();
            splitter1 = new System.Windows.Forms.Splitter();
            starToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            kirbyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            powerUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            mapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            musicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            soundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            githubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            discordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            docsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            nodeBox.SuspendLayout();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            treeView1.HideSelection = false;
            treeView1.Indent = 16;
            treeView1.ItemHeight = 24;
            treeView1.LabelEdit = true;
            treeView1.Location = new System.Drawing.Point(3, 19);
            treeView1.Name = "treeView1";
            treeView1.Size = new System.Drawing.Size(208, 372);
            treeView1.TabIndex = 0;
            treeView1.BeforeLabelEdit += treeView1_BeforeLabelEdit;
            treeView1.AfterLabelEdit += treeView1_AfterLabelEdit;
            treeView1.DragDrop += MainForm_DragDrop;
            treeView1.DragEnter += MainForm_DragEnter;
            treeView1.DoubleClick += treeView1_DoubleClick;
            treeView1.KeyDown += treeView1_KeyDown;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, viewToolStripMenuItem, toolsToolStripMenuItem, optionsToolStripMenuItem, starToolStripMenuItem, kirbyToolStripMenuItem, powerUpToolStripMenuItem, mapToolStripMenuItem, helpToolStripMenuItem, helpToolStripMenuItem1 });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            menuStrip1.Size = new System.Drawing.Size(751, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem1, saveToolStripMenuItem, saveAsUnoptimizedToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O;
            openToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem1
            // 
            saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            saveToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S;
            saveToolStripMenuItem1.Size = new System.Drawing.Size(192, 22);
            saveToolStripMenuItem1.Text = "Save";
            saveToolStripMenuItem1.Click += saveToolStripMenuItem1_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.S;
            saveToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            saveToolStripMenuItem.Text = "Save As";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveAsUnoptimizedToolStripMenuItem
            // 
            saveAsUnoptimizedToolStripMenuItem.Name = "saveAsUnoptimizedToolStripMenuItem";
            saveAsUnoptimizedToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            saveAsUnoptimizedToolStripMenuItem.Text = "Save As (No Optimize)";
            saveAsUnoptimizedToolStripMenuItem.Click += saveAsUnoptimizedToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { addNodeToolStripMenuItem, toolStripSeparator2, trimExcessDataToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // addNodeToolStripMenuItem
            // 
            addNodeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { fromFileToolStripMenuItem, fromDATFileToolStripMenuItem, fromTypeToolStripMenuItem });
            addNodeToolStripMenuItem.Name = "addNodeToolStripMenuItem";
            addNodeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            addNodeToolStripMenuItem.Text = "Add Node";
            // 
            // fromFileToolStripMenuItem
            // 
            fromFileToolStripMenuItem.Name = "fromFileToolStripMenuItem";
            fromFileToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            fromFileToolStripMenuItem.Text = "From File";
            fromFileToolStripMenuItem.Click += addRootFromFileToolStripMenuItem1_Click;
            // 
            // fromDATFileToolStripMenuItem
            // 
            fromDATFileToolStripMenuItem.Name = "fromDATFileToolStripMenuItem";
            fromDATFileToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            fromDATFileToolStripMenuItem.Text = "From DAT File";
            fromDATFileToolStripMenuItem.Click += addRootFromFileToolStripMenuItem_Click;
            // 
            // fromTypeToolStripMenuItem
            // 
            fromTypeToolStripMenuItem.Name = "fromTypeToolStripMenuItem";
            fromTypeToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            fromTypeToolStripMenuItem.Text = "From Type";
            fromTypeToolStripMenuItem.Click += addRootFromTypeToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // trimExcessDataToolStripMenuItem
            // 
            trimExcessDataToolStripMenuItem.Name = "trimExcessDataToolStripMenuItem";
            trimExcessDataToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            trimExcessDataToolStripMenuItem.Text = "Trim/Fix Data";
            trimExcessDataToolStripMenuItem.ToolTipText = "Removes garbage and unused data as well as aligns certain structures";
            trimExcessDataToolStripMenuItem.Click += trimExcessDataToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { propertyViewToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            viewToolStripMenuItem.Text = "View";
            // 
            // propertyViewToolStripMenuItem
            // 
            propertyViewToolStripMenuItem.Checked = true;
            propertyViewToolStripMenuItem.CheckOnClick = true;
            propertyViewToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            propertyViewToolStripMenuItem.Name = "propertyViewToolStripMenuItem";
            propertyViewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            propertyViewToolStripMenuItem.Text = "Property View";
            propertyViewToolStripMenuItem.CheckStateChanged += propertyViewToolStripMenuItem_CheckStateChanged;
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { aJToolToolStripMenuItem, sSMEditorToolStripMenuItem, sEMEditorToolStripMenuItem });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            toolsToolStripMenuItem.Text = "Tools";
            // 
            // aJToolToolStripMenuItem
            // 
            aJToolToolStripMenuItem.Name = "aJToolToolStripMenuItem";
            aJToolToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            aJToolToolStripMenuItem.Text = "AJ Tool";
            aJToolToolStripMenuItem.Click += aJToolToolStripMenuItem_Click;
            // 
            // sSMEditorToolStripMenuItem
            // 
            sSMEditorToolStripMenuItem.Name = "sSMEditorToolStripMenuItem";
            sSMEditorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            sSMEditorToolStripMenuItem.Text = "SSM Editor";
            sSMEditorToolStripMenuItem.Click += sSMEditorToolStripMenuItem_Click;
            // 
            // sEMEditorToolStripMenuItem
            // 
            sEMEditorToolStripMenuItem.Name = "sEMEditorToolStripMenuItem";
            sEMEditorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            sEMEditorToolStripMenuItem.Text = "SEM Editor";
            sEMEditorToolStripMenuItem.Click += sEMEditorToolStripMenuItem_Click;
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { selectAudioPlaybackDeviceToolStripMenuItem });
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            optionsToolStripMenuItem.Text = "Options";
            // 
            // selectAudioPlaybackDeviceToolStripMenuItem
            // 
            selectAudioPlaybackDeviceToolStripMenuItem.Name = "selectAudioPlaybackDeviceToolStripMenuItem";
            selectAudioPlaybackDeviceToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            selectAudioPlaybackDeviceToolStripMenuItem.Text = "Select Audio Playback Device";
            selectAudioPlaybackDeviceToolStripMenuItem.Click += selectAudioPlaybackDeviceToolStripMenuItem_Click;
            // 
            // LocationLabel
            // 
            LocationLabel.Dock = System.Windows.Forms.DockStyle.Top;
            LocationLabel.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            LocationLabel.Location = new System.Drawing.Point(0, 24);
            LocationLabel.Name = "LocationLabel";
            LocationLabel.Size = new System.Drawing.Size(751, 16);
            LocationLabel.TabIndex = 5;
            LocationLabel.Text = "Location:";
            // 
            // dockPanel
            // 
            dockPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            dockPanel.DocumentStyle = WeifenLuo.WinFormsUI.Docking.DocumentStyle.DockingMdi;
            dockPanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dockPanel.Location = new System.Drawing.Point(231, 40);
            dockPanel.Name = "dockPanel";
            dockPanel.Size = new System.Drawing.Size(520, 394);
            dockPanel.TabIndex = 6;
            // 
            // showHideButton
            // 
            showHideButton.BackColor = System.Drawing.SystemColors.Control;
            showHideButton.Dock = System.Windows.Forms.DockStyle.Left;
            showHideButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            showHideButton.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            showHideButton.Location = new System.Drawing.Point(217, 40);
            showHideButton.Name = "showHideButton";
            showHideButton.Size = new System.Drawing.Size(14, 394);
            showHideButton.TabIndex = 10;
            showHideButton.Text = "<";
            showHideButton.UseVisualStyleBackColor = false;
            showHideButton.Click += showHideButton_Click;
            // 
            // nodeBox
            // 
            nodeBox.Controls.Add(treeView1);
            nodeBox.Dock = System.Windows.Forms.DockStyle.Left;
            nodeBox.Location = new System.Drawing.Point(0, 40);
            nodeBox.Name = "nodeBox";
            nodeBox.Size = new System.Drawing.Size(214, 394);
            nodeBox.TabIndex = 11;
            nodeBox.TabStop = false;
            nodeBox.Text = "Nodes";
            // 
            // splitter1
            // 
            splitter1.Location = new System.Drawing.Point(214, 40);
            splitter1.Name = "splitter1";
            splitter1.Size = new System.Drawing.Size(3, 394);
            splitter1.TabIndex = 12;
            splitter1.TabStop = false;
            // 
            // starToolStripMenuItem
            // 
            starToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { newToolStripMenuItem, loadToolStripMenuItem });
            starToolStripMenuItem.Name = "starToolStripMenuItem";
            starToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            starToolStripMenuItem.Text = "Star";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            newToolStripMenuItem.Text = "New";
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            loadToolStripMenuItem.Text = "Load";
            // 
            // kirbyToolStripMenuItem
            // 
            kirbyToolStripMenuItem.Name = "kirbyToolStripMenuItem";
            kirbyToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            kirbyToolStripMenuItem.Text = "Kirby";
            // 
            // powerUpToolStripMenuItem
            // 
            powerUpToolStripMenuItem.Name = "powerUpToolStripMenuItem";
            powerUpToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            powerUpToolStripMenuItem.Text = "Power Up";
            // 
            // mapToolStripMenuItem
            // 
            mapToolStripMenuItem.Name = "mapToolStripMenuItem";
            mapToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            mapToolStripMenuItem.Text = "Map";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { musicToolStripMenuItem, soundToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            helpToolStripMenuItem.Text = "Audio";
            // 
            // helpToolStripMenuItem1
            // 
            helpToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { githubToolStripMenuItem, discordToolStripMenuItem, docsToolStripMenuItem });
            helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            helpToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            helpToolStripMenuItem1.Text = "Help";
            // 
            // musicToolStripMenuItem
            // 
            musicToolStripMenuItem.Name = "musicToolStripMenuItem";
            musicToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            musicToolStripMenuItem.Text = "Music";
            // 
            // soundToolStripMenuItem
            // 
            soundToolStripMenuItem.Name = "soundToolStripMenuItem";
            soundToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            soundToolStripMenuItem.Text = "Sound";
            // 
            // githubToolStripMenuItem
            // 
            githubToolStripMenuItem.Name = "githubToolStripMenuItem";
            githubToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            githubToolStripMenuItem.Text = "Github";
            // 
            // discordToolStripMenuItem
            // 
            discordToolStripMenuItem.Name = "discordToolStripMenuItem";
            discordToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            discordToolStripMenuItem.Text = "Discord";
            // 
            // docsToolStripMenuItem
            // 
            docsToolStripMenuItem.Name = "docsToolStripMenuItem";
            docsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            docsToolStripMenuItem.Text = "Docs";
            // 
            // MainForm
            // 
            AllowDrop = true;
            AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            ClientSize = new System.Drawing.Size(751, 434);
            Controls.Add(dockPanel);
            Controls.Add(showHideButton);
            Controls.Add(splitter1);
            Controls.Add(nodeBox);
            Controls.Add(LocationLabel);
            Controls.Add(menuStrip1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            TabText = "Hal DAT Browser";
            Text = "HSD-KAR";
            Load += MainForm_Load;
            DragDrop += MainForm_DragDrop;
            DragEnter += MainForm_DragEnter;
            KeyDown += MainForm_KeyDown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            nodeBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.Label LocationLabel;
        private WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propertyViewToolStripMenuItem;
        private System.Windows.Forms.Button showHideButton;
        private System.Windows.Forms.GroupBox nodeBox;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aJToolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsUnoptimizedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sSMEditorToolStripMenuItem;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sEMEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAudioPlaybackDeviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trimExcessDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromDATFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem starToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kirbyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem powerUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem musicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem githubToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem discordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem docsToolStripMenuItem;
    }
}

