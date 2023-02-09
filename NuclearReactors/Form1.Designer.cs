namespace NuclearReactors
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.reactor1Label = new System.Windows.Forms.Label();
            this.reacter2Label = new System.Windows.Forms.Label();
            this.reactor1stateLabel = new System.Windows.Forms.Label();
            this.reactor2stateLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Old English Text MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(247, 43);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(236, 26);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Nuclear Reactor Control";
            this.titleLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // reactor1Label
            // 
            this.reactor1Label.AutoSize = true;
            this.reactor1Label.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reactor1Label.Location = new System.Drawing.Point(99, 95);
            this.reactor1Label.Name = "reactor1Label";
            this.reactor1Label.Size = new System.Drawing.Size(99, 23);
            this.reactor1Label.TabIndex = 1;
            this.reactor1Label.Text = "Reactor 1";
            // 
            // reacter2Label
            // 
            this.reacter2Label.AutoSize = true;
            this.reacter2Label.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reacter2Label.Location = new System.Drawing.Point(537, 95);
            this.reacter2Label.Name = "reacter2Label";
            this.reacter2Label.Size = new System.Drawing.Size(99, 23);
            this.reacter2Label.TabIndex = 2;
            this.reacter2Label.Text = "Reactor 2";
            // 
            // reactor1stateLabel
            // 
            this.reactor1stateLabel.BackColor = System.Drawing.Color.Lime;
            this.reactor1stateLabel.Location = new System.Drawing.Point(45, 139);
            this.reactor1stateLabel.Name = "reactor1stateLabel";
            this.reactor1stateLabel.Size = new System.Drawing.Size(187, 160);
            this.reactor1stateLabel.TabIndex = 3;
            // 
            // reactor2stateLabel
            // 
            this.reactor2stateLabel.BackColor = System.Drawing.Color.Lime;
            this.reactor2stateLabel.Location = new System.Drawing.Point(490, 139);
            this.reactor2stateLabel.Name = "reactor2stateLabel";
            this.reactor2stateLabel.Size = new System.Drawing.Size(187, 160);
            this.reactor2stateLabel.TabIndex = 4;
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.outputLabel.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(298, 254);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(135, 22);
            this.outputLabel.TabIndex = 5;
            this.outputLabel.Text = "Reactors Stable";
            this.outputLabel.Click += new System.EventHandler(this.outputLabel_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Red;
            this.startButton.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(324, 139);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 73);
            this.startButton.TabIndex = 6;
            this.startButton.Text = "TURN ON";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(725, 345);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.reactor2stateLabel);
            this.Controls.Add(this.reactor1stateLabel);
            this.Controls.Add(this.reacter2Label);
            this.Controls.Add(this.reactor1Label);
            this.Controls.Add(this.titleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "NuclearStuf";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label reactor1Label;
        private System.Windows.Forms.Label reacter2Label;
        private System.Windows.Forms.Label reactor1stateLabel;
        private System.Windows.Forms.Label reactor2stateLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button startButton;
    }
}

