namespace PropertyGridExample
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
            this.prgProperty = new System.Windows.Forms.PropertyGrid();
            this.cbKindOfProps = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // prgProperty
            // 
            this.prgProperty.Location = new System.Drawing.Point(12, 42);
            this.prgProperty.Name = "prgProperty";
            this.prgProperty.Size = new System.Drawing.Size(310, 266);
            this.prgProperty.TabIndex = 0;
            // 
            // cbKindOfProps
            // 
            this.cbKindOfProps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbKindOfProps.FormattingEnabled = true;
            this.cbKindOfProps.Items.AddRange(new object[] {
            "Example of PropertyGrid for TextField",
            "Example of PropertyGrid for True/False field",
            "Example of PropertyGrid for Categories",
            "Example of PropertyGrid for Color field",
            "Example of PropertyGrid for Font field",
            "Example of PropertyGrid for Enum"});
            this.cbKindOfProps.Location = new System.Drawing.Point(12, 12);
            this.cbKindOfProps.Name = "cbKindOfProps";
            this.cbKindOfProps.Size = new System.Drawing.Size(310, 21);
            this.cbKindOfProps.TabIndex = 1;
            this.cbKindOfProps.SelectedIndexChanged += new System.EventHandler(this.cbKindOfProps_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 320);
            this.Controls.Add(this.cbKindOfProps);
            this.Controls.Add(this.prgProperty);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "PropertyGrid Example";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PropertyGrid prgProperty;
        private System.Windows.Forms.ComboBox cbKindOfProps;
    }
}

