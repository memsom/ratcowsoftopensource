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

namespace testapp3
{
	internal partial class Form1Controller: BaseController<Form1>
	{
		public Form1Controller() : base()
		{
		}

		partial void listBox1Click(EventArgs e);
		partial void comboBox3Click(EventArgs e);
		partial void comboBox2Click(EventArgs e);
		partial void comboBox1Click(EventArgs e);
		partial void dateTimePicker1Click(EventArgs e);
		partial void checkBox1Click(EventArgs e);
		partial void checkBox1CheckedChanged(EventArgs e);
		partial void button1Click(EventArgs e);
		partial void label1Click(EventArgs e);
		partial void textBox1Click(EventArgs e);
		partial void textBox1TextChanged(EventArgs e);
	}


#region GUI glue code

	partial class Form1Controller
	{
		[Outlet("listBox1")]
		public ListBox listBox1 { get; set; }
		[Action("listBox1", "Click")]
		public void FlistBox1_Click(object sender, EventArgs e)
		{
			//Auto generated call
			listBox1Click(e);
		}

		[Outlet("comboBox3")]
		public ComboBox comboBox3 { get; set; }
		[Action("comboBox3", "Click")]
		public void FcomboBox3_Click(object sender, EventArgs e)
		{
			//Auto generated call
			comboBox3Click(e);
		}

		[Outlet("comboBox2")]
		public ComboBox comboBox2 { get; set; }
		[Action("comboBox2", "Click")]
		public void FcomboBox2_Click(object sender, EventArgs e)
		{
			//Auto generated call
			comboBox2Click(e);
		}

		[Outlet("comboBox1")]
		public ComboBox comboBox1 { get; set; }
		[Action("comboBox1", "Click")]
		public void FcomboBox1_Click(object sender, EventArgs e)
		{
			//Auto generated call
			comboBox1Click(e);
		}

		[Outlet("dateTimePicker1")]
		public DateTimePicker dateTimePicker1 { get; set; }
		[Action("dateTimePicker1", "Click")]
		public void FdateTimePicker1_Click(object sender, EventArgs e)
		{
			//Auto generated call
			dateTimePicker1Click(e);
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

		[Outlet("button1")]
		public Button button1 { get; set; }
		[Action("button1", "Click")]
		public void Fbutton1_Click(object sender, EventArgs e)
		{
			//Auto generated call
			button1Click(e);
		}

		[Outlet("label1")]
		public Label label1 { get; set; }
		[Action("label1", "Click")]
		public void Flabel1_Click(object sender, EventArgs e)
		{
			//Auto generated call
			label1Click(e);
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

		protected void SetData<T>(ListViewHelper<T> helper, List<T> data) where T : class
		{
			//Auto generated call
			Type t = helper.GetType();
			t.InvokeMember("SetData", BindingFlags.Default | BindingFlags.InvokeMethod, null, helper, new object[] { data });
		}

	}
#endregion /*GUI glue code*/

}

