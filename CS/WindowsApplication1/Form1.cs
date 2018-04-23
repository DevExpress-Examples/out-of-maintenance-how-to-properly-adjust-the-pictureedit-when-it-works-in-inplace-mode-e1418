using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1 {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e) {

			DataTable dt = new DataTable();
			dt.Columns.Add("Photo", typeof(Image));
			dt.Columns.Add("Test");
			dt.Rows.Add(new object[] { Image.FromFile("..\\..\\Creek.jpg"), "test1" });
			dt.Rows.Add(new object[] { Image.FromFile("..\\..\\Creek.jpg"), "test2" });
			dt.Rows.Add(new object[] { Image.FromFile("..\\..\\Creek.jpg"), "test3" });

			gridControl1.DataSource = dt; 

			DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit item = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();

			gridControl1.RepositoryItems.Add(item);
			gridView1.Columns["Photo"].ColumnEdit = item;



		}
	}
}