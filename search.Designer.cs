namespace LibraryDemo
{
    partial class search
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
            searchresult = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)searchresult).BeginInit();
            SuspendLayout();
            // 
            // searchresult
            // 
            searchresult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            searchresult.Location = new Point(116, 155);
            searchresult.Name = "searchresult";
            searchresult.Size = new Size(534, 127);
            searchresult.TabIndex = 0;
            searchresult.CellContentClick += searchresult_CellContentClick;
            // 
            // search
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(searchresult);
            Name = "search";
            Text = "search";
            Load += search_Load;
            ((System.ComponentModel.ISupportInitialize)searchresult).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView searchresult;
    }
}