/*Auto generated - this code was generated by the MvcFramework compiler, created by RatCow Soft - 
 See http://code.google.com/p/ratcowsoftopensource/ */ 

using System; 
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

//3rd Party
using RatCow.MvcFramework;

namespace testapp2
{
	internal partial class Form1Controller
	{
		public Form1Controller() : base()
		{
		}

		partial void statusStrip1Click(EventArgs e);
		partial void toolStripStatusLabel1Click(EventArgs e);
		partial void toolStripStatusLabel2Click(EventArgs e);
		partial void toolStripProgressBar1Click(EventArgs e);
		partial void panel1Click(EventArgs e);
		partial void textBox3Click(EventArgs e);
		partial void textBox3TextChanged(EventArgs e);
		partial void button4Click(EventArgs e);
		partial void dateTimePicker1Click(EventArgs e);
		partial void panel2Click(EventArgs e);
		partial void tabControl1Click(EventArgs e);
		partial void tabPage1Click(EventArgs e);
		partial void textBox2Click(EventArgs e);
		partial void textBox2TextChanged(EventArgs e);
		partial void button2Click(EventArgs e);
		partial void tabPage2Click(EventArgs e);
		partial void checkBox3Click(EventArgs e);
		partial void checkBox3CheckedChanged(EventArgs e);
		partial void button3Click(EventArgs e);
		partial void checkBox2Click(EventArgs e);
		partial void checkBox2CheckedChanged(EventArgs e);
		partial void listView1Click(EventArgs e);
		protected virtual void listView1RetrieveVirtualItem(RetrieveVirtualItemEventArgs e)
		{
			/*we will first try to get an item from the partial method*/
			ListViewItem item = null; //set to a known value
			listView1GetItem(ref item, e); //try to get the value from partial implementation
			if (item == null) //if, null, save ourselves from crashing 
			{
			/*default placeholder to avoid crashes*/
			item = new ListViewItem();

			/*we need to provide a value for each column*/
			int count = (listView1.Columns.Count);
			if (count > 1)
			{
				item.Text = "Temp value";
				for (int i = 1; i < count; i++)
				{
					item.SubItems.Add("Temp Subitem");
				}	
			}
		}

			e.Item = item;
		}

		partial void listView1GetItem(ref ListViewItem item, RetrieveVirtualItemEventArgs e);
		partial void textBox1Click(EventArgs e);
		partial void textBox1TextChanged(EventArgs e);
		partial void label1Click(EventArgs e);
		partial void button1Click(EventArgs e);
		partial void checkBox1Click(EventArgs e);
		partial void checkBox1CheckedChanged(EventArgs e);
	}


#region GUI glue code

	partial class Form1Controller
	{
		[Outlet("statusStrip1")]
		public StatusStrip statusStrip1 { get; set; }
		[Action("statusStrip1", "Click")]
		public void FstatusStrip1_Click(object sender, EventArgs e)
		{
			//Auto generated call
			statusStrip1Click(e);
		}

		[Outlet("toolStripStatusLabel1")]
		public ToolStripStatusLabel toolStripStatusLabel1 { get; set; }
		[Action("toolStripStatusLabel1", "Click")]
		public void FtoolStripStatusLabel1_Click(object sender, EventArgs e)
		{
			//Auto generated call
			toolStripStatusLabel1Click(e);
		}

		[Outlet("toolStripStatusLabel2")]
		public ToolStripStatusLabel toolStripStatusLabel2 { get; set; }
		[Action("toolStripStatusLabel2", "Click")]
		public void FtoolStripStatusLabel2_Click(object sender, EventArgs e)
		{
			//Auto generated call
			toolStripStatusLabel2Click(e);
		}

		[Outlet("toolStripProgressBar1")]
		public ToolStripProgressBar toolStripProgressBar1 { get; set; }
		[Action("toolStripProgressBar1", "Click")]
		public void FtoolStripProgressBar1_Click(object sender, EventArgs e)
		{
			//Auto generated call
			toolStripProgressBar1Click(e);
		}

		[Outlet("panel1")]
		public Panel panel1 { get; set; }
		[Action("panel1", "Click")]
		public void Fpanel1_Click(object sender, EventArgs e)
		{
			//Auto generated call
			panel1Click(e);
		}

		[Outlet("textBox3")]
		public TextBox textBox3 { get; set; }
		[Action("textBox3", "Click")]
		public void FtextBox3_Click(object sender, EventArgs e)
		{
			//Auto generated call
			textBox3Click(e);
		}

		[Action("textBox3", "TextChanged")]
		public void FtextBox3_TextChanged(object sender, EventArgs e)
		{
			//Auto generated call
			textBox3TextChanged(e);
		}

		[Outlet("button4")]
		public Button button4 { get; set; }
		[Action("button4", "Click")]
		public void Fbutton4_Click(object sender, EventArgs e)
		{
			//Auto generated call
			button4Click(e);
		}

		[Outlet("dateTimePicker1")]
		public DateTimePicker dateTimePicker1 { get; set; }
		[Action("dateTimePicker1", "Click")]
		public void FdateTimePicker1_Click(object sender, EventArgs e)
		{
			//Auto generated call
			dateTimePicker1Click(e);
		}

		[Outlet("panel2")]
		public Panel panel2 { get; set; }
		[Action("panel2", "Click")]
		public void Fpanel2_Click(object sender, EventArgs e)
		{
			//Auto generated call
			panel2Click(e);
		}

		[Outlet("tabControl1")]
		public TabControl tabControl1 { get; set; }
		[Action("tabControl1", "Click")]
		public void FtabControl1_Click(object sender, EventArgs e)
		{
			//Auto generated call
			tabControl1Click(e);
		}

		[Outlet("tabPage1")]
		public TabPage tabPage1 { get; set; }
		[Action("tabPage1", "Click")]
		public void FtabPage1_Click(object sender, EventArgs e)
		{
			//Auto generated call
			tabPage1Click(e);
		}

		[Outlet("textBox2")]
		public TextBox textBox2 { get; set; }
		[Action("textBox2", "Click")]
		public void FtextBox2_Click(object sender, EventArgs e)
		{
			//Auto generated call
			textBox2Click(e);
		}

		[Action("textBox2", "TextChanged")]
		public void FtextBox2_TextChanged(object sender, EventArgs e)
		{
			//Auto generated call
			textBox2TextChanged(e);
		}

		[Outlet("button2")]
		public Button button2 { get; set; }
		[Action("button2", "Click")]
		public void Fbutton2_Click(object sender, EventArgs e)
		{
			//Auto generated call
			button2Click(e);
		}

		[Outlet("tabPage2")]
		public TabPage tabPage2 { get; set; }
		[Action("tabPage2", "Click")]
		public void FtabPage2_Click(object sender, EventArgs e)
		{
			//Auto generated call
			tabPage2Click(e);
		}

		[Outlet("checkBox3")]
		public CheckBox checkBox3 { get; set; }
		[Action("checkBox3", "Click")]
		public void FcheckBox3_Click(object sender, EventArgs e)
		{
			//Auto generated call
			checkBox3Click(e);
		}

		[Action("checkBox3", "CheckedChanged")]
		public void FcheckBox3_CheckedChanged(object sender, EventArgs e)
		{
			//Auto generated call
			checkBox3CheckedChanged(e);
		}

		[Outlet("button3")]
		public Button button3 { get; set; }
		[Action("button3", "Click")]
		public void Fbutton3_Click(object sender, EventArgs e)
		{
			//Auto generated call
			button3Click(e);
		}

		[Outlet("checkBox2")]
		public CheckBox checkBox2 { get; set; }
		[Action("checkBox2", "Click")]
		public void FcheckBox2_Click(object sender, EventArgs e)
		{
			//Auto generated call
			checkBox2Click(e);
		}

		[Action("checkBox2", "CheckedChanged")]
		public void FcheckBox2_CheckedChanged(object sender, EventArgs e)
		{
			//Auto generated call
			checkBox2CheckedChanged(e);
		}

		[Outlet("listView1")]
		public ListView listView1 { get; set; }
		[Action("listView1", "Click")]
		public void FlistView1_Click(object sender, EventArgs e)
		{
			//Auto generated call
			listView1Click(e);
		}

		protected ListViewHelper<T> GetlistView1Helper<T>() where T : class
		{
			//Auto generated call
			var lvh = new ListViewHelper<T>(listView1);
			return lvh;
		}

		[Action("listView1", "RetrieveVirtualItem")]
		public void FlistView1_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
		{
			//Auto generated call
			listView1RetrieveVirtualItem(e);
		}

		[Outlet("textBox1")]
		public TextBox textBox1 { get; set; }
		[Action("textBox1", "Click")]
		public void FtextBox1_Click(object sender, EventArgs e)
		{
			//Auto generated call
			textBox1Click(e);
		}

		[Action("textBox1", "TextChanged")]
		public void FtextBox1_TextChanged(object sender, EventArgs e)
		{
			//Auto generated call
			textBox1TextChanged(e);
		}

		[Outlet("label1")]
		public Label label1 { get; set; }
		[Action("label1", "Click")]
		public void Flabel1_Click(object sender, EventArgs e)
		{
			//Auto generated call
			label1Click(e);
		}

		[Outlet("button1")]
		public Button button1 { get; set; }
		[Action("button1", "Click")]
		public void Fbutton1_Click(object sender, EventArgs e)
		{
			//Auto generated call
			button1Click(e);
		}

		[Outlet("checkBox1")]
		public CheckBox checkBox1 { get; set; }
		[Action("checkBox1", "Click")]
		public void FcheckBox1_Click(object sender, EventArgs e)
		{
			//Auto generated call
			checkBox1Click(e);
		}

		[Action("checkBox1", "CheckedChanged")]
		public void FcheckBox1_CheckedChanged(object sender, EventArgs e)
		{
			//Auto generated call
			checkBox1CheckedChanged(e);
		}

		[Outlet("timer1")]
		public Timer timer1 { get; set; }
		protected void SetData<T>(ListViewHelper<T> helper, List<T> data) where T : class
		{
			//Auto generated call
			Type t = helper.GetType();
			t.InvokeMember("SetData", BindingFlags.Default | BindingFlags.InvokeMethod, null, helper, new object[] { data });
		}

	}
#endregion /*GUI glue code*/

}

