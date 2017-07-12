using System;

namespace TaylorQuestTool
{
    partial class questCreator
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.questCreationLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.questDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.questNameLabel = new System.Windows.Forms.Label();
            this.questLevelLabel = new System.Windows.Forms.Label();
            this.expRewardLabel = new System.Windows.Forms.Label();
            this.cashRewardLabel = new System.Windows.Forms.Label();
            this.difficultyLabel = new System.Windows.Forms.Label();
            this.isQuestTimed = new System.Windows.Forms.CheckBox();
            this.questTime = new System.Windows.Forms.Label();
            this.itemRewards = new System.Windows.Forms.Label();
            this.questDescription = new System.Windows.Forms.Label();
            this.questDescriptionText = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.difficultySettings = new System.Windows.Forms.ComboBox();
            this.questLevelNumber = new System.Windows.Forms.NumericUpDown();
            this.experienceRewardNum = new System.Windows.Forms.NumericUpDown();
            this.cashRewardNumber = new System.Windows.Forms.NumericUpDown();
            this.itemsRewardNumber = new System.Windows.Forms.NumericUpDown();
            this.questTimeNumber = new System.Windows.Forms.NumericUpDown();
            this.questStepsLabel = new System.Windows.Forms.Label();
            this.stepDescriptionLabe = new System.Windows.Forms.Label();
            this.stepDescriptionText = new System.Windows.Forms.TextBox();
            this.stepCompletesQuestCheckbox = new System.Windows.Forms.CheckBox();
            this.stepTypeLabel = new System.Windows.Forms.Label();
            this.stepTypeSettings = new System.Windows.Forms.ComboBox();
            this.killNumberLabel = new System.Windows.Forms.Label();
            this.killNumber = new System.Windows.Forms.NumericUpDown();
            this.stepSaveButton = new System.Windows.Forms.Button();
            this.orderLabel = new System.Windows.Forms.Label();
            this.questStepsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stepsList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questLevelNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.experienceRewardNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashRewardNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsRewardNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questTimeNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.killNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questStepsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // questCreationLabel
            // 
            this.questCreationLabel.AutoSize = true;
            this.questCreationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questCreationLabel.Location = new System.Drawing.Point(353, 9);
            this.questCreationLabel.Name = "questCreationLabel";
            this.questCreationLabel.Size = new System.Drawing.Size(288, 46);
            this.questCreationLabel.TabIndex = 0;
            this.questCreationLabel.Text = "Quest Creation";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.questDataBindingSource, "_questName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nameTextBox.Location = new System.Drawing.Point(384, 67);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // questDataBindingSource
            // 
            this.questDataBindingSource.DataSource = typeof(TaylorQuestTool.questData);
            // 
            // questNameLabel
            // 
            this.questNameLabel.AutoSize = true;
            this.questNameLabel.Location = new System.Drawing.Point(312, 70);
            this.questNameLabel.Name = "questNameLabel";
            this.questNameLabel.Size = new System.Drawing.Size(66, 13);
            this.questNameLabel.TabIndex = 2;
            this.questNameLabel.Text = "Quest Name";
            // 
            // questLevelLabel
            // 
            this.questLevelLabel.AutoSize = true;
            this.questLevelLabel.Location = new System.Drawing.Point(515, 70);
            this.questLevelLabel.Name = "questLevelLabel";
            this.questLevelLabel.Size = new System.Drawing.Size(64, 13);
            this.questLevelLabel.TabIndex = 3;
            this.questLevelLabel.Text = "Quest Level";
            // 
            // expRewardLabel
            // 
            this.expRewardLabel.AutoSize = true;
            this.expRewardLabel.Location = new System.Drawing.Point(23, 109);
            this.expRewardLabel.Name = "expRewardLabel";
            this.expRewardLabel.Size = new System.Drawing.Size(100, 13);
            this.expRewardLabel.TabIndex = 5;
            this.expRewardLabel.Text = "Experience Reward";
            // 
            // cashRewardLabel
            // 
            this.cashRewardLabel.AutoSize = true;
            this.cashRewardLabel.Location = new System.Drawing.Point(179, 107);
            this.cashRewardLabel.Name = "cashRewardLabel";
            this.cashRewardLabel.Size = new System.Drawing.Size(71, 13);
            this.cashRewardLabel.TabIndex = 7;
            this.cashRewardLabel.Text = "Cash Reward";
            // 
            // difficultyLabel
            // 
            this.difficultyLabel.AutoSize = true;
            this.difficultyLabel.Location = new System.Drawing.Point(324, 107);
            this.difficultyLabel.Name = "difficultyLabel";
            this.difficultyLabel.Size = new System.Drawing.Size(78, 13);
            this.difficultyLabel.TabIndex = 8;
            this.difficultyLabel.Text = "Quest Difficulty";
            // 
            // isQuestTimed
            // 
            this.isQuestTimed.AutoSize = true;
            this.isQuestTimed.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.questDataBindingSource, "_isThisQuestTimed", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "false"));
            this.isQuestTimed.Location = new System.Drawing.Point(442, 126);
            this.isQuestTimed.Name = "isQuestTimed";
            this.isQuestTimed.Size = new System.Drawing.Size(97, 17);
            this.isQuestTimed.TabIndex = 10;
            this.isQuestTimed.Text = "Is quest timed?";
            this.isQuestTimed.UseVisualStyleBackColor = true;
            this.isQuestTimed.CheckedChanged += new System.EventHandler(this.isQuestTimed_CheckedChanged);
            // 
            // questTime
            // 
            this.questTime.AutoSize = true;
            this.questTime.Location = new System.Drawing.Point(591, 107);
            this.questTime.Name = "questTime";
            this.questTime.Size = new System.Drawing.Size(61, 13);
            this.questTime.TabIndex = 11;
            this.questTime.Text = "Quest Time";
            // 
            // itemRewards
            // 
            this.itemRewards.AutoSize = true;
            this.itemRewards.Location = new System.Drawing.Point(710, 128);
            this.itemRewards.Name = "itemRewards";
            this.itemRewards.Size = new System.Drawing.Size(140, 13);
            this.itemRewards.TabIndex = 13;
            this.itemRewards.Text = "Number of Items To Reward";
            // 
            // questDescription
            // 
            this.questDescription.AutoSize = true;
            this.questDescription.Location = new System.Drawing.Point(426, 159);
            this.questDescription.Name = "questDescription";
            this.questDescription.Size = new System.Drawing.Size(91, 13);
            this.questDescription.TabIndex = 15;
            this.questDescription.Text = "Quest Description";
            // 
            // questDescriptionText
            // 
            this.questDescriptionText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.questDataBindingSource, "questDescription", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.questDescriptionText.Location = new System.Drawing.Point(280, 175);
            this.questDescriptionText.Multiline = true;
            this.questDescriptionText.Name = "questDescriptionText";
            this.questDescriptionText.Size = new System.Drawing.Size(361, 64);
            this.questDescriptionText.TabIndex = 16;
            this.questDescriptionText.Text = ".";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(424, 645);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 23);
            this.saveButton.TabIndex = 17;
            this.saveButton.Text = "Save Quest!";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // difficultySettings
            // 
            this.difficultySettings.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.questDataBindingSource, "questDifficulty", true));
            this.difficultySettings.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.questDataBindingSource, "questDifficulty", true));
            this.difficultySettings.FormattingEnabled = true;
            this.difficultySettings.Items.AddRange(new object[] {
            "Easy",
            "Standard",
            "Hard ",
            "Group",
            "Raid"});
            this.difficultySettings.Location = new System.Drawing.Point(300, 123);
            this.difficultySettings.Name = "difficultySettings";
            this.difficultySettings.Size = new System.Drawing.Size(121, 21);
            this.difficultySettings.TabIndex = 18;
            this.difficultySettings.Text = "Select Difficulty";
            this.difficultySettings.Validating += new System.ComponentModel.CancelEventHandler(this.difficultySettings_Validating);
            // 
            // questLevelNumber
            // 
            this.questLevelNumber.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.questDataBindingSource, "_questLevel", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "0", "N0"));
            this.questLevelNumber.Location = new System.Drawing.Point(585, 68);
            this.questLevelNumber.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.questLevelNumber.Name = "questLevelNumber";
            this.questLevelNumber.Size = new System.Drawing.Size(120, 20);
            this.questLevelNumber.TabIndex = 19;
            // 
            // experienceRewardNum
            // 
            this.experienceRewardNum.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.questDataBindingSource, "_experienceReward", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "0", "N0"));
            this.experienceRewardNum.Location = new System.Drawing.Point(12, 125);
            this.experienceRewardNum.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.experienceRewardNum.Name = "experienceRewardNum";
            this.experienceRewardNum.Size = new System.Drawing.Size(120, 20);
            this.experienceRewardNum.TabIndex = 20;
            // 
            // cashRewardNumber
            // 
            this.cashRewardNumber.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.questDataBindingSource, "_cashReward", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "0", "N0"));
            this.cashRewardNumber.Location = new System.Drawing.Point(158, 123);
            this.cashRewardNumber.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.cashRewardNumber.Name = "cashRewardNumber";
            this.cashRewardNumber.Size = new System.Drawing.Size(120, 20);
            this.cashRewardNumber.TabIndex = 21;
            // 
            // itemsRewardNumber
            // 
            this.itemsRewardNumber.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.questDataBindingSource, "_numItemsRewarded", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "0", "N0"));
            this.itemsRewardNumber.Location = new System.Drawing.Point(856, 123);
            this.itemsRewardNumber.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.itemsRewardNumber.Name = "itemsRewardNumber";
            this.itemsRewardNumber.Size = new System.Drawing.Size(120, 20);
            this.itemsRewardNumber.TabIndex = 22;
            // 
            // questTimeNumber
            // 
            this.questTimeNumber.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.questDataBindingSource, "questTimer", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "0", "N2"));
            this.questTimeNumber.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.questTimeNumber.Location = new System.Drawing.Point(567, 125);
            this.questTimeNumber.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.questTimeNumber.Name = "questTimeNumber";
            this.questTimeNumber.ReadOnly = true;
            this.questTimeNumber.Size = new System.Drawing.Size(120, 20);
            this.questTimeNumber.TabIndex = 23;
            // 
            // questStepsLabel
            // 
            this.questStepsLabel.AutoSize = true;
            this.questStepsLabel.Location = new System.Drawing.Point(439, 255);
            this.questStepsLabel.Name = "questStepsLabel";
            this.questStepsLabel.Size = new System.Drawing.Size(65, 13);
            this.questStepsLabel.TabIndex = 24;
            this.questStepsLabel.Text = "Quest Steps";
            // 
            // stepDescriptionLabe
            // 
            this.stepDescriptionLabe.AutoSize = true;
            this.stepDescriptionLabe.Location = new System.Drawing.Point(439, 471);
            this.stepDescriptionLabe.Name = "stepDescriptionLabe";
            this.stepDescriptionLabe.Size = new System.Drawing.Size(85, 13);
            this.stepDescriptionLabe.TabIndex = 26;
            this.stepDescriptionLabe.Text = "Step Description";
            // 
            // stepDescriptionText
            // 
            this.stepDescriptionText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.questDataBindingSource, "_currentStepDescription", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.stepDescriptionText.Location = new System.Drawing.Point(291, 497);
            this.stepDescriptionText.Multiline = true;
            this.stepDescriptionText.Name = "stepDescriptionText";
            this.stepDescriptionText.Size = new System.Drawing.Size(361, 64);
            this.stepDescriptionText.TabIndex = 27;
            this.stepDescriptionText.Text = ".";
            // 
            // stepCompletesQuestCheckbox
            // 
            this.stepCompletesQuestCheckbox.AutoSize = true;
            this.stepCompletesQuestCheckbox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.questDataBindingSource, "_isThisQuestTimed", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "false"));
            this.stepCompletesQuestCheckbox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.questDataBindingSource, "_currentStepCompletesQuest", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.stepCompletesQuestCheckbox.Location = new System.Drawing.Point(235, 591);
            this.stepCompletesQuestCheckbox.Name = "stepCompletesQuestCheckbox";
            this.stepCompletesQuestCheckbox.Size = new System.Drawing.Size(155, 17);
            this.stepCompletesQuestCheckbox.TabIndex = 28;
            this.stepCompletesQuestCheckbox.Text = "Does step complete quest?";
            this.stepCompletesQuestCheckbox.UseVisualStyleBackColor = true;
            // 
            // stepTypeLabel
            // 
            this.stepTypeLabel.AutoSize = true;
            this.stepTypeLabel.Location = new System.Drawing.Point(448, 564);
            this.stepTypeLabel.Name = "stepTypeLabel";
            this.stepTypeLabel.Size = new System.Drawing.Size(56, 13);
            this.stepTypeLabel.TabIndex = 29;
            this.stepTypeLabel.Text = "Step Type";
            // 
            // stepTypeSettings
            // 
            this.stepTypeSettings.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.questDataBindingSource, "_currentStepType", true));
            this.stepTypeSettings.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.questDataBindingSource, "_currentStepType", true));
            this.stepTypeSettings.FormattingEnabled = true;
            this.stepTypeSettings.Items.AddRange(new object[] {
            "Kill",
            "Explore",
            "Conversation"});
            this.stepTypeSettings.Location = new System.Drawing.Point(418, 589);
            this.stepTypeSettings.Name = "stepTypeSettings";
            this.stepTypeSettings.Size = new System.Drawing.Size(121, 21);
            this.stepTypeSettings.TabIndex = 30;
            this.stepTypeSettings.Text = "Select Step Type";
            this.stepTypeSettings.SelectedIndexChanged += new System.EventHandler(this.stepTypeSettings_SelectedIndexChanged);
            this.stepTypeSettings.Validating += new System.ComponentModel.CancelEventHandler(this.stepTypeSettings_Validating);
            // 
            // killNumberLabel
            // 
            this.killNumberLabel.AutoSize = true;
            this.killNumberLabel.Location = new System.Drawing.Point(611, 564);
            this.killNumberLabel.Name = "killNumberLabel";
            this.killNumberLabel.Size = new System.Drawing.Size(60, 13);
            this.killNumberLabel.TabIndex = 31;
            this.killNumberLabel.Text = "Kill Number";
            // 
            // killNumber
            // 
            this.killNumber.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.questDataBindingSource, "_currentStepKillCount", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "0", "N0"));
            this.killNumber.Location = new System.Drawing.Point(585, 588);
            this.killNumber.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.killNumber.Name = "killNumber";
            this.killNumber.ReadOnly = true;
            this.killNumber.Size = new System.Drawing.Size(120, 20);
            this.killNumber.TabIndex = 32;
            // 
            // stepSaveButton
            // 
            this.stepSaveButton.Location = new System.Drawing.Point(419, 616);
            this.stepSaveButton.Name = "stepSaveButton";
            this.stepSaveButton.Size = new System.Drawing.Size(105, 23);
            this.stepSaveButton.TabIndex = 33;
            this.stepSaveButton.Text = "Save This Step!";
            this.stepSaveButton.UseVisualStyleBackColor = true;
            this.stepSaveButton.Click += new System.EventHandler(this.stepSaveButton_Click);
            // 
            // orderLabel
            // 
            this.orderLabel.AutoSize = true;
            this.orderLabel.Location = new System.Drawing.Point(440, 296);
            this.orderLabel.Name = "orderLabel";
            this.orderLabel.Size = new System.Drawing.Size(56, 13);
            this.orderLabel.TabIndex = 35;
            this.orderLabel.Text = "Step order";
            // 
            // questStepsBindingSource
            // 
            this.questStepsBindingSource.DataMember = "questSteps";
            this.questStepsBindingSource.DataSource = this.questDataBindingSource;
            // 
            // stepsList
            // 
            this.stepsList.FormattingEnabled = true;
            this.stepsList.Location = new System.Drawing.Point(404, 312);
            this.stepsList.Name = "stepsList";
            this.stepsList.Size = new System.Drawing.Size(120, 95);
            this.stepsList.TabIndex = 37;
            this.stepsList.DragDrop += new System.Windows.Forms.DragEventHandler(this.stepsList_DragDrop);
            this.stepsList.DragOver += new System.Windows.Forms.DragEventHandler(this.stepsList_DragOver);
            this.stepsList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.stepsList_MouseDown);
            // 
            // questCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(988, 671);
            this.Controls.Add(this.stepsList);
            this.Controls.Add(this.orderLabel);
            this.Controls.Add(this.stepSaveButton);
            this.Controls.Add(this.killNumber);
            this.Controls.Add(this.killNumberLabel);
            this.Controls.Add(this.stepTypeSettings);
            this.Controls.Add(this.stepTypeLabel);
            this.Controls.Add(this.stepCompletesQuestCheckbox);
            this.Controls.Add(this.stepDescriptionText);
            this.Controls.Add(this.stepDescriptionLabe);
            this.Controls.Add(this.questStepsLabel);
            this.Controls.Add(this.questTimeNumber);
            this.Controls.Add(this.itemsRewardNumber);
            this.Controls.Add(this.cashRewardNumber);
            this.Controls.Add(this.experienceRewardNum);
            this.Controls.Add(this.questLevelNumber);
            this.Controls.Add(this.difficultySettings);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.questDescriptionText);
            this.Controls.Add(this.questDescription);
            this.Controls.Add(this.itemRewards);
            this.Controls.Add(this.questTime);
            this.Controls.Add(this.isQuestTimed);
            this.Controls.Add(this.difficultyLabel);
            this.Controls.Add(this.cashRewardLabel);
            this.Controls.Add(this.expRewardLabel);
            this.Controls.Add(this.questLevelLabel);
            this.Controls.Add(this.questNameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.questCreationLabel);
            this.Name = "questCreator";
            this.Text = "Quest Creation";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questLevelNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.experienceRewardNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashRewardNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsRewardNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questTimeNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.killNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questStepsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      


        #endregion
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label expRewardLabel;
        private System.Windows.Forms.Label questLevelLabel;
        private System.Windows.Forms.Label questNameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label questCreationLabel;
        private System.Windows.Forms.CheckBox isQuestTimed;
        private System.Windows.Forms.Label difficultyLabel;
        private System.Windows.Forms.Label cashRewardLabel;
        private System.Windows.Forms.ComboBox difficultySettings;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox questDescriptionText;
        private System.Windows.Forms.Label questDescription;
        private System.Windows.Forms.Label itemRewards;
        private System.Windows.Forms.Label questTime;
        private System.Windows.Forms.NumericUpDown questLevelNumber;
        private System.Windows.Forms.NumericUpDown experienceRewardNum;
        private System.Windows.Forms.NumericUpDown questTimeNumber;
        private System.Windows.Forms.NumericUpDown itemsRewardNumber;
        private System.Windows.Forms.NumericUpDown cashRewardNumber;
        private System.Windows.Forms.BindingSource questDataBindingSource;
        private System.Windows.Forms.Label questStepsLabel;
        private System.Windows.Forms.Button stepSaveButton;
        private System.Windows.Forms.NumericUpDown killNumber;
        private System.Windows.Forms.Label killNumberLabel;
        private System.Windows.Forms.ComboBox stepTypeSettings;
        private System.Windows.Forms.Label stepTypeLabel;
        private System.Windows.Forms.CheckBox stepCompletesQuestCheckbox;
        private System.Windows.Forms.TextBox stepDescriptionText;
        private System.Windows.Forms.Label stepDescriptionLabe;
        private System.Windows.Forms.Label orderLabel;
        private System.Windows.Forms.BindingSource questStepsBindingSource;
        private System.Windows.Forms.ListBox stepsList;
    }
}

