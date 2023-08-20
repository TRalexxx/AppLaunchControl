namespace AppLaunchControl
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
            chooseFileBtn = new Button();
            programLB = new ListBox();
            startMonitorBtn = new Button();
            stopMonitorBtn = new Button();
            deleteFromListBtn = new Button();
            appPathTB = new TextBox();
            timeNUD = new NumericUpDown();
            addAppBtn = new Button();
            monitorWorkingLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)timeNUD).BeginInit();
            SuspendLayout();
            // 
            // chooseFileBtn
            // 
            chooseFileBtn.Location = new Point(12, 12);
            chooseFileBtn.Name = "chooseFileBtn";
            chooseFileBtn.Size = new Size(100, 23);
            chooseFileBtn.TabIndex = 0;
            chooseFileBtn.Text = "Choose exe file";
            chooseFileBtn.UseVisualStyleBackColor = true;
            chooseFileBtn.Click += chooseFileBtn_Click;
            // 
            // programLB
            // 
            programLB.FormattingEnabled = true;
            programLB.ItemHeight = 15;
            programLB.Location = new Point(12, 78);
            programLB.Name = "programLB";
            programLB.Size = new Size(564, 94);
            programLB.TabIndex = 1;
            // 
            // startMonitorBtn
            // 
            startMonitorBtn.Location = new Point(12, 178);
            startMonitorBtn.Name = "startMonitorBtn";
            startMonitorBtn.Size = new Size(100, 23);
            startMonitorBtn.TabIndex = 2;
            startMonitorBtn.Text = "Start Mobitor";
            startMonitorBtn.UseVisualStyleBackColor = true;
            startMonitorBtn.Click += startMonitorBtn_Click;
            // 
            // stopMonitorBtn
            // 
            stopMonitorBtn.Location = new Point(118, 178);
            stopMonitorBtn.Name = "stopMonitorBtn";
            stopMonitorBtn.Size = new Size(100, 23);
            stopMonitorBtn.TabIndex = 3;
            stopMonitorBtn.Text = "Stop Monitor";
            stopMonitorBtn.UseVisualStyleBackColor = true;
            stopMonitorBtn.Click += stopMonitorBtn_Click;
            // 
            // deleteFromListBtn
            // 
            deleteFromListBtn.Location = new Point(476, 41);
            deleteFromListBtn.Name = "deleteFromListBtn";
            deleteFromListBtn.Size = new Size(100, 23);
            deleteFromListBtn.TabIndex = 4;
            deleteFromListBtn.Text = "Delete from list";
            deleteFromListBtn.UseVisualStyleBackColor = true;
            deleteFromListBtn.Click += deleteFromListBtn_Click;
            // 
            // appPathTB
            // 
            appPathTB.Location = new Point(118, 13);
            appPathTB.Name = "appPathTB";
            appPathTB.Size = new Size(458, 23);
            appPathTB.TabIndex = 5;
            // 
            // timeNUD
            // 
            timeNUD.Location = new Point(12, 41);
            timeNUD.Name = "timeNUD";
            timeNUD.Size = new Size(120, 23);
            timeNUD.TabIndex = 6;
            // 
            // addAppBtn
            // 
            addAppBtn.Location = new Point(395, 42);
            addAppBtn.Name = "addAppBtn";
            addAppBtn.Size = new Size(75, 23);
            addAppBtn.TabIndex = 7;
            addAppBtn.Text = "Add App";
            addAppBtn.UseVisualStyleBackColor = true;
            addAppBtn.Click += addAppBtn_Click;
            // 
            // monitorWorkingLabel
            // 
            monitorWorkingLabel.AutoSize = true;
            monitorWorkingLabel.Location = new Point(469, 186);
            monitorWorkingLabel.Name = "monitorWorkingLabel";
            monitorWorkingLabel.Size = new Size(107, 15);
            monitorWorkingLabel.TabIndex = 8;
            monitorWorkingLabel.Text = "Monitor is working";
            monitorWorkingLabel.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(588, 450);
            Controls.Add(monitorWorkingLabel);
            Controls.Add(addAppBtn);
            Controls.Add(timeNUD);
            Controls.Add(appPathTB);
            Controls.Add(deleteFromListBtn);
            Controls.Add(stopMonitorBtn);
            Controls.Add(startMonitorBtn);
            Controls.Add(programLB);
            Controls.Add(chooseFileBtn);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)timeNUD).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button chooseFileBtn;
        private ListBox programLB;
        private Button startMonitorBtn;
        private Button stopMonitorBtn;
        private Button deleteFromListBtn;
        private TextBox appPathTB;
        private NumericUpDown timeNUD;
        private Button addAppBtn;
        private Label monitorWorkingLabel;
    }
}