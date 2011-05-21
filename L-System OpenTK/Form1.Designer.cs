namespace L_System_OpenTK
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.cmdRun = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtIterations = new System.Windows.Forms.ToolStripTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.glControl = new OpenTK.GLControl();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtString = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtRule = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPop = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPush = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAngle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLeft = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtForwards = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdRun,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.txtIterations});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(666, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // cmdRun
            // 
            this.cmdRun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cmdRun.Image = ((System.Drawing.Image)(resources.GetObject("cmdRun.Image")));
            this.cmdRun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdRun.Name = "cmdRun";
            this.cmdRun.Size = new System.Drawing.Size(32, 22);
            this.cmdRun.Text = "Run";
            this.cmdRun.Click += new System.EventHandler(this.cmdRun_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel1.Text = "Iterations:";
            // 
            // txtIterations
            // 
            this.txtIterations.Name = "txtIterations";
            this.txtIterations.Size = new System.Drawing.Size(100, 25);
            this.txtIterations.Text = "1";
            this.txtIterations.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.glControl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel2MinSize = 154;
            this.splitContainer1.Size = new System.Drawing.Size(666, 365);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.TabIndex = 2;
            // 
            // glControl
            // 
            this.glControl.BackColor = System.Drawing.Color.Black;
            this.glControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.glControl.Location = new System.Drawing.Point(0, 0);
            this.glControl.Name = "glControl";
            this.glControl.Size = new System.Drawing.Size(666, 200);
            this.glControl.TabIndex = 0;
            this.glControl.VSync = false;
            this.glControl.Load += new System.EventHandler(this.glControl_Load);
            this.glControl.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl_Paint);
            this.glControl.Resize += new System.EventHandler(this.glControl_Resize);
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(666, 161);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtString);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(658, 135);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "String";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtString
            // 
            this.txtString.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtString.Location = new System.Drawing.Point(3, 3);
            this.txtString.Multiline = true;
            this.txtString.Name = "txtString";
            this.txtString.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtString.Size = new System.Drawing.Size(652, 129);
            this.txtString.TabIndex = 0;
            this.txtString.Text = "FX";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtRule);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(658, 135);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Production Rule(s)";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtRule
            // 
            this.txtRule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRule.Location = new System.Drawing.Point(3, 3);
            this.txtRule.Multiline = true;
            this.txtRule.Name = "txtRule";
            this.txtRule.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRule.Size = new System.Drawing.Size(652, 129);
            this.txtRule.TabIndex = 1;
            this.txtRule.Text = "X=X+YF\r\nY=FX-Y";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.txtPop);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.txtPush);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.txtAngle);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.txtRight);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.txtLeft);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.txtForwards);
            this.tabPage3.Location = new System.Drawing.Point(4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(658, 135);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Definitions";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(225, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Restore Position:";
            // 
            // txtPop
            // 
            this.txtPop.Location = new System.Drawing.Point(314, 38);
            this.txtPop.Name = "txtPop";
            this.txtPop.Size = new System.Drawing.Size(70, 20);
            this.txtPop.TabIndex = 14;
            this.txtPop.Text = "]";
            this.txtPop.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(225, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Save Position:";
            // 
            // txtPush
            // 
            this.txtPush.Location = new System.Drawing.Point(314, 12);
            this.txtPush.Name = "txtPush";
            this.txtPush.Size = new System.Drawing.Size(70, 20);
            this.txtPush.TabIndex = 12;
            this.txtPush.Text = "[";
            this.txtPush.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Angle (Degrees):";
            // 
            // txtAngle
            // 
            this.txtAngle.Location = new System.Drawing.Point(314, 64);
            this.txtAngle.Name = "txtAngle";
            this.txtAngle.Size = new System.Drawing.Size(70, 20);
            this.txtAngle.TabIndex = 10;
            this.txtAngle.Text = "90";
            this.txtAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Turn Right:";
            // 
            // txtRight
            // 
            this.txtRight.Location = new System.Drawing.Point(97, 64);
            this.txtRight.Name = "txtRight";
            this.txtRight.Size = new System.Drawing.Size(100, 20);
            this.txtRight.TabIndex = 8;
            this.txtRight.Text = "+";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Turn Left:";
            // 
            // txtLeft
            // 
            this.txtLeft.Location = new System.Drawing.Point(97, 38);
            this.txtLeft.Name = "txtLeft";
            this.txtLeft.Size = new System.Drawing.Size(100, 20);
            this.txtLeft.TabIndex = 6;
            this.txtLeft.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Move Forwards:";
            // 
            // txtForwards
            // 
            this.txtForwards.Location = new System.Drawing.Point(97, 12);
            this.txtForwards.Name = "txtForwards";
            this.txtForwards.Size = new System.Drawing.Size(100, 20);
            this.txtForwards.TabIndex = 4;
            this.txtForwards.Text = "F";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 390);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "L-System Workpad";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton cmdRun;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtIterations;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtString;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtRule;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAngle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLeft;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtForwards;
        private OpenTK.GLControl glControl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPush;
    }
}

