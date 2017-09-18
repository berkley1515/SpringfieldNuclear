namespace SpringfieldNuclear
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
            this.EnableReactors = new System.Windows.Forms.Button();
            this.Reactor1 = new System.Windows.Forms.Label();
            this.Reactor2 = new System.Windows.Forms.Label();
            this.Reactor1Text = new System.Windows.Forms.Label();
            this.Reactor2Text = new System.Windows.Forms.Label();
            this.ReactorStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Turquoise;
            this.titleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(150, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(390, 42);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Springfield Power Plant";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titleLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // EnableReactors
            // 
            this.EnableReactors.BackColor = System.Drawing.Color.Orange;
            this.EnableReactors.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.EnableReactors.FlatAppearance.BorderSize = 3;
            this.EnableReactors.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EnableReactors.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.EnableReactors.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnableReactors.Location = new System.Drawing.Point(187, 296);
            this.EnableReactors.Name = "EnableReactors";
            this.EnableReactors.Size = new System.Drawing.Size(310, 50);
            this.EnableReactors.TabIndex = 1;
            this.EnableReactors.Text = "Enable Reactors";
            this.EnableReactors.UseVisualStyleBackColor = false;
            this.EnableReactors.Click += new System.EventHandler(this.EnableReactors_Click);
            // 
            // Reactor1
            // 
            this.Reactor1.BackColor = System.Drawing.Color.Silver;
            this.Reactor1.Location = new System.Drawing.Point(192, 123);
            this.Reactor1.Name = "Reactor1";
            this.Reactor1.Size = new System.Drawing.Size(131, 127);
            this.Reactor1.TabIndex = 2;
            this.Reactor1.Click += new System.EventHandler(this.Reactor1_Click);
            // 
            // Reactor2
            // 
            this.Reactor2.BackColor = System.Drawing.Color.Silver;
            this.Reactor2.Location = new System.Drawing.Point(366, 123);
            this.Reactor2.Name = "Reactor2";
            this.Reactor2.Size = new System.Drawing.Size(131, 127);
            this.Reactor2.TabIndex = 3;
            // 
            // Reactor1Text
            // 
            this.Reactor1Text.AutoSize = true;
            this.Reactor1Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reactor1Text.Location = new System.Drawing.Point(192, 94);
            this.Reactor1Text.Name = "Reactor1Text";
            this.Reactor1Text.Size = new System.Drawing.Size(73, 18);
            this.Reactor1Text.TabIndex = 4;
            this.Reactor1Text.Text = "Reactor 1";
            // 
            // Reactor2Text
            // 
            this.Reactor2Text.AutoSize = true;
            this.Reactor2Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reactor2Text.Location = new System.Drawing.Point(366, 94);
            this.Reactor2Text.Name = "Reactor2Text";
            this.Reactor2Text.Size = new System.Drawing.Size(73, 18);
            this.Reactor2Text.TabIndex = 5;
            this.Reactor2Text.Text = "Reactor 2";
            // 
            // ReactorStatus
            // 
            this.ReactorStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReactorStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReactorStatus.Location = new System.Drawing.Point(150, 396);
            this.ReactorStatus.Name = "ReactorStatus";
            this.ReactorStatus.Size = new System.Drawing.Size(390, 35);
            this.ReactorStatus.TabIndex = 6;
            this.ReactorStatus.Text = "Reactor Status";
            this.ReactorStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SpringfieldNuclear.Properties.Resources.thumb_1920_625910;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.ReactorStatus);
            this.Controls.Add(this.Reactor2Text);
            this.Controls.Add(this.Reactor1Text);
            this.Controls.Add(this.Reactor2);
            this.Controls.Add(this.Reactor1);
            this.Controls.Add(this.EnableReactors);
            this.Controls.Add(this.titleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Control Centre";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button EnableReactors;
        private System.Windows.Forms.Label Reactor1;
        private System.Windows.Forms.Label Reactor2;
        private System.Windows.Forms.Label Reactor1Text;
        private System.Windows.Forms.Label Reactor2Text;
        private System.Windows.Forms.Label ReactorStatus;
    }
}

