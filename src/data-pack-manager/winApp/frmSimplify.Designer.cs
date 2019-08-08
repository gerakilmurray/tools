/*
*    Poblaciones - Plataforma abierta de datos espaciales de población.
*    Copyright (C) 2018-2019. Consejo Nacional de Investigaciones Científicas y Técnicas (CONICET)
*		 y Universidad Católica Argentina (UCA).
*
*    This program is free software: you can redistribute it and/or modify
*    it under the terms of the GNU General Public License as published by
*    the Free Software Foundation, either version 3 of the License, or
*    (at your option) any later version.
*
*    This program is distributed in the hope that it will be useful,
*    but WITHOUT ANY WARRANTY; without even the implied warranty of
*    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
*    GNU General Public License for more details.
*
*    You should have received a copy of the GNU General Public License
*    along with this program.  If not, see <https://www.gnu.org/licenses/>.
*/
namespace medea.winApp
{
	partial class frmsimplify
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
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.btnToDisk = new System.Windows.Forms.Button();
			this.SuspendLayout();
			//
			// button1
			//
			this.button1.Location = new System.Drawing.Point(12, 29);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(140, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Geographies To Disk";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			//
			// button2
			//
			this.button2.Location = new System.Drawing.Point(12, 75);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(113, 23);
			this.button2.TabIndex = 0;
			this.button2.Text = "ClippingRegions";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			//
			// button3
			//
			this.button3.Location = new System.Drawing.Point(39, 124);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(113, 23);
			this.button3.TabIndex = 0;
			this.button3.Text = "Ambos";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			//
			// btnToDisk
			//
			this.btnToDisk.Location = new System.Drawing.Point(158, 29);
			this.btnToDisk.Name = "btnToDisk";
			this.btnToDisk.Size = new System.Drawing.Size(140, 23);
			this.btnToDisk.TabIndex = 0;
			this.btnToDisk.Text = "Geographies Exec";
			this.btnToDisk.UseVisualStyleBackColor = true;
			this.btnToDisk.Click += new System.EventHandler(this.btnToDisk_Click);
			//
			// frmsimplify
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 273);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.btnToDisk);
			this.Controls.Add(this.button1);
			this.Name = "frmsimplify";
			this.ShowInTaskbar = false;
			this.Text = "frmsimplify";
			this.Load += new System.EventHandler(this.frmsimplify_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button btnToDisk;
	}
}