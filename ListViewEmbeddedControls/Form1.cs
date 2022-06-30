using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ListViewEmbeddedControls
{
	/// <summary>
	/// Zusammenfassung f? Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private ListViewEx listView1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.Label label1;
        private ColumnHeader columnHeader3;
        private System.ComponentModel.IContainer components;

		private String[] todoType = { "(none)", "a", "b", "c" }; //type_combobox testdata

		public Form1()
		{
			//
			// Erforderlich f? die Windows Form-Designerunterst?zung
			//
			InitializeComponent();
		}

		/// <summary>
		/// Die verwendeten Ressourcen bereinigen.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Vom Windows Form-Designer generierter Code
		/// <summary>
		/// Erforderliche Methode f? die Designerunterst?zung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor ge?dert werden.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            "aaa"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("");
            this.listView1 = new ListViewEmbeddedControls.ListViewEx();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.AllowColumnReorder = true;
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            listViewItem1.StateImageIndex = 0;
            listViewItem1.UseItemStyleForSubItems = false;
            listViewItem2.StateImageIndex = 0;
            listViewItem3.StateImageIndex = 0;
            listViewItem4.StateImageIndex = 0;
            listViewItem5.StateImageIndex = 0;
            listViewItem6.StateImageIndex = 0;
            listViewItem7.StateImageIndex = 0;
            listViewItem8.StateImageIndex = 0;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8});
            this.listView1.Location = new System.Drawing.Point(19, 34);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(362, 236);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Check";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Contents";
            this.columnHeader2.Width = 124;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Type";
            this.columnHeader3.Width = 121;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Date";
            this.columnHeader4.Width = 121;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Location = new System.Drawing.Point(19, 279);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(154, 20);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(19, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "The columns can be reordered and sorted";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(400, 302);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Sample for Controls embedded in a ListView";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
			



		}
		#endregion

		/// <summary>
		/// Der Haupteinstiegspunkt f? die Anwendung.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.EnableVisualStyles();
			Application.Run(new Form1());
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			// Create some controls and embed them in our ListView
			/* First, a button:
			Button b = new Button();
			b.Text = "ClickMe";
			b.BackColor = SystemColors.Control;
			b.Font = this.Font;
			b.Click += new EventHandler(b_Click);
			// Put it in the first column of the fourth row
			listView1.AddEmbeddedControl(b, 0, 3);
			*/

			// Second, a RichTextBox (slightly modified to make it non-selectable)
			ReadOnlyRichTextBox rtb = new ReadOnlyRichTextBox();
			rtb.ScrollBars = RichTextBoxScrollBars.None;
			rtb.BorderStyle = BorderStyle.None;
			rtb.WordWrap = false;
			rtb.BackColor = Color.White;
			rtb.Cursor = Cursors.Default;
			rtb.Rtf = @"{\rtf1\ansi\ansicpg1252\deff0\deflang1031{\fonttbl{\f0\fnil\fcharset0 Arial;}}{\colortbl ;\red255\green0\blue0;}\viewkind4\uc1\pard\fs14 Sample\cf1\b\fs20 Entry\cf0\par}";
			// Embed it
			listView1.AddEmbeddedControl(rtb, 2, 5);

			// Third, a number of ProcessBars that will be updated by a timer
			Random r = new Random();
			foreach (ListViewItem i in listView1.Items)
			{
				int cnt = r.Next(100);
				i.SubItems.Add(cnt.ToString());

				ProgressBar pb = new ProgressBar();
				pb.Value = cnt;
				pb.Click += new EventHandler(pb_Click);

				//type box
				ComboBox type_comboBox = new ComboBox();
				type_comboBox.Items.AddRange(todoType); //data initialize
				type_comboBox.SelectedIndex = 0;

				//DateTimePicker
				DateTimePicker dt = new DateTimePicker();

				// Embed the objects in Column 2
				listView1.AddEmbeddedControl(pb, 1, i.Index);
				listView1.AddEmbeddedControl(type_comboBox, 2, i.Index);
				listView1.AddEmbeddedControl(dt, 3, i.Index);
			}

			// Fill the View ComboBox
			Array a = Enum.GetValues(typeof(View));
			foreach (View v in a)
			{
				comboBox1.Items.Add(v.ToString());
			}
			// Default view is Details
			comboBox1.Text = View.Details.ToString();
		}

		private void b_Click(object sender, EventArgs e)
		{
			MessageBox.Show(this, "Thank you!");
		}

		// Once an embedded ProgressBar is clicked, it's removed from the ListView.
		// This way the ListViewSubItem's Text value becomes visible.
		private void pb_Click(object sender, EventArgs e)
		{
			listView1.RemoveEmbeddedControl(sender as Control);
		}

		// Update embedded ProgressBars
		private Random rnd = new Random();
		private void timer1_Tick(object sender, System.EventArgs e)
		{
			int row = rnd.Next(listView1.Items.Count);

			ProgressBar pb = listView1.GetEmbeddedControl(1, row) as ProgressBar;
			if (pb==null)
			{
				int val = int.Parse(listView1.Items[row].SubItems[1].Text);
				val += 5;
				if (val>100)
					val=0;

				listView1.Items[row].SubItems[1].Text = val.ToString();
				return;
			}

			if (pb.Value >= pb.Maximum-5)
				pb.Value = pb.Minimum;
			else
				pb.Value += 5;

			listView1.Items[row].SubItems[1].Text = pb.Value.ToString();
		}


		// Switch ListView View
		private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			View v = (View)Enum.Parse(typeof(View),comboBox1.Text,true);
			listView1.View = v;
		}

		// Sort ListView
		private void listView1_ColumnClick(object sender, System.Windows.Forms.ColumnClickEventArgs e)
		{
			switch (listView1.Sorting)
			{
				case SortOrder.None:
				case SortOrder.Ascending:
					listView1.Sorting = SortOrder.Descending;
					break;
				case SortOrder.Descending:
					listView1.Sorting = SortOrder.Ascending;
					break;
			}
		}

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
