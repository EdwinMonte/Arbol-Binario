namespace Arbol_Binario
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
            txtValue = new TextBox();
            btnInsert = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
            SuspendLayout();
            // 
            // txtValue
            // 
            txtValue.Location = new Point(21, 293);
            txtValue.Multiline = true;
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(210, 57);
            txtValue.TabIndex = 0;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(44, 26);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(139, 50);
            btnInsert.TabIndex = 1;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(44, 102);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(139, 50);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(44, 179);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(139, 46);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1063, 666);
            Controls.Add(btnSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnInsert);
            Controls.Add(txtValue);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtValue;
        private Button btnInsert;
        private Button btnDelete;
        private Button btnSearch;
    }
}
