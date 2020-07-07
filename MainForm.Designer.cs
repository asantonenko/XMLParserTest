/*
 * Created by SharpDevelop.
 * User: Alexander
 * Date: 07.07.2020
 * Time: 12:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace XMLParserTest
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.bDownload = new System.Windows.Forms.Button();
			this.tbURL = new System.Windows.Forms.TextBox();
			this.lbParsed = new System.Windows.Forms.ListBox();
			this.tbPath = new System.Windows.Forms.TextBox();
			this.tbResult = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Height = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// bDownload
			// 
			this.bDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.bDownload.Location = new System.Drawing.Point(29, 46);
			this.bDownload.Margin = new System.Windows.Forms.Padding(2);
			this.bDownload.Name = "bDownload";
			this.bDownload.Size = new System.Drawing.Size(162, 49);
			this.bDownload.TabIndex = 0;
			this.bDownload.Text = "&Download && Parse";
			this.bDownload.UseVisualStyleBackColor = true;
			this.bDownload.Click += new System.EventHandler(this.BDownloadClick);
			// 
			// tbURL
			// 
			this.tbURL.Location = new System.Drawing.Point(9, 24);
			this.tbURL.Margin = new System.Windows.Forms.Padding(2);
			this.tbURL.Name = "tbURL";
			this.tbURL.Size = new System.Drawing.Size(283, 20);
			this.tbURL.TabIndex = 1;
			// 
			// lbParsed
			// 
			this.lbParsed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.lbParsed.FormattingEnabled = true;
			this.lbParsed.Location = new System.Drawing.Point(9, 172);
			this.lbParsed.Margin = new System.Windows.Forms.Padding(2);
			this.lbParsed.Name = "lbParsed";
			this.lbParsed.Size = new System.Drawing.Size(682, 160);
			this.lbParsed.TabIndex = 2;
			// 
			// tbPath
			// 
			this.tbPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.tbPath.Location = new System.Drawing.Point(340, 24);
			this.tbPath.Margin = new System.Windows.Forms.Padding(2);
			this.tbPath.Name = "tbPath";
			this.tbPath.Size = new System.Drawing.Size(360, 20);
			this.tbPath.TabIndex = 3;
			// 
			// tbResult
			// 
			this.tbResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.tbResult.Location = new System.Drawing.Point(340, 54);
			this.tbResult.Margin = new System.Windows.Forms.Padding(2);
			this.tbResult.Multiline = true;
			this.tbResult.Name = "tbResult";
			this.tbResult.Size = new System.Drawing.Size(360, 41);
			this.tbResult.TabIndex = 4;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Name,
									this.Age,
									this.Height});
			this.dataGridView1.Location = new System.Drawing.Point(13, 100);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(687, 57);
			this.dataGridView1.TabIndex = 5;
			// 
			// Name
			// 
			this.Name.HeaderText = "Name";
			this.Name.Name = "Name";
			this.Name.Width = 120;
			// 
			// Age
			// 
			this.Age.HeaderText = "Age";
			this.Age.Name = "Age";
			// 
			// Height
			// 
			this.Height.HeaderText = "Height";
			this.Height.Name = "Height";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(708, 343);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.tbResult);
			this.Controls.Add(this.tbPath);
			this.Controls.Add(this.lbParsed);
			this.Controls.Add(this.tbURL);
			this.Controls.Add(this.bDownload);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "MainForm";
			this.Text = "XMLParserTest";
			this.SizeChanged += new System.EventHandler(this.MainFormSizeChanged);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn Height;
		private System.Windows.Forms.DataGridViewTextBoxColumn Age;
		private System.Windows.Forms.DataGridViewTextBoxColumn Name;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox tbResult;
		private System.Windows.Forms.TextBox tbPath;
		private System.Windows.Forms.ListBox lbParsed;
		private System.Windows.Forms.TextBox tbURL;
		private System.Windows.Forms.Button bDownload;
	}
}
