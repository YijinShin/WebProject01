using System;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private ColumnHeader columnHeader3;
        private System.ComponentModel.IContainer components;
        private BackgroundWorker backgroundWorker1;
        private BackgroundWorker backgroundWorker2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        String selectedDate;
        Label selectedDateLabel;

        //Test data
        private String[] todoType = { "(none)", "a", "b", "c" }; //type_combobox testdata			
        private List<String> todoContents = new List<String>() { "111", "222" ,"333" };
        private DevExpress.XtraEditors.Controls.CalendarControl calendarControl1;
        private List<System.Windows.Forms.ListViewItem> itemList = new List<System.Windows.Forms.ListViewItem>();
        private List<Label> dateLabelList = new List<Label>();

        public Form1()
		{
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
            //initial list item setting
            for(int i = 0; i < todoContents.Count; i++)
            {
                //list item add
                System.Windows.Forms.ListViewItem item = new System.Windows.Forms.ListViewItem(todoContents[i]);
                item.StateImageIndex = 0;
                itemList.Add(item);

                //date label add
                Label label = new Label();
                label.Click += new EventHandler(dateLabe_Click);
                dateLabelList.Add(label);
            }
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.listView1 = new ListViewEmbeddedControls.ListViewEx();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.calendarControl1 = new DevExpress.XtraEditors.Controls.CalendarControl();
            ((System.ComponentModel.ISupportInitialize)(this.calendarControl1.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Location = new System.Drawing.Point(19, 536);
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
            this.listView1.Location = new System.Drawing.Point(19, 34);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(703, 493);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = " ";
            this.columnHeader1.Width = 30;
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
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(50, 484);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(89, 23);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "addItem";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // calendarControl1
            // 
            this.calendarControl1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calendarControl1.Location = new System.Drawing.Point(443, 102);
            this.calendarControl1.Name = "calendarControl1";
            this.calendarControl1.Size = new System.Drawing.Size(239, 245);
            this.calendarControl1.TabIndex = 5;
            this.calendarControl1.DateTimeChanged += new System.EventHandler(this.calendarControl1_DateTimeChange);
            this.calendarControl1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(741, 559);
            this.Controls.Add(this.calendarControl1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Sample for Controls embedded in a ListView";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.calendarControl1.CalendarTimeProperties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
            //add item to listview
            for (int i = 0; i < todoContents.Count; i++)
            {
                ComboBox type_comboBox = new ComboBox();
                type_comboBox.Items.AddRange(todoType); //data initialize
                type_comboBox.SelectedIndex = 0;

                listView1.Items.Add(itemList[i]);
                listView1.AddEmbeddedControl(dateLabelList[i], 3, i);
                listView1.AddEmbeddedControl(type_comboBox, 2, i);
            }

            /*
            foreach (ListViewItem i in listView1.Items)
			{
				//type box
				ComboBox type_comboBox = new ComboBox();
				type_comboBox.Items.AddRange(todoType); //data initialize
				type_comboBox.SelectedIndex = 0;

                //DateTimePicker
                //teTimePicker dt = new DateTimePicker();

                //label
                //System.Windows.Forms.Label calendarLabel = new System.Windows.Forms.Label();
                //calendarLabel.Click += new EventHandler(DatePicker);
                //listView1.contro

				// Embed the objects in Column 2
				listView1.AddEmbeddedControl(type_comboBox, 2, i.Index);
				//listView1.AddEmbeddedControl(calendarLabel, 3, i.Index);
			}*/

			// Fill the View ComboBox
			Array a = Enum.GetValues(typeof(View));
			foreach (View v in a)
			{
				comboBox1.Items.Add(v.ToString());
			}
			// Default view is Details
			comboBox1.Text = View.Details.ToString();

            //listView1.EndUpdate(); 
		}

        public void dateLabe_Click(object sender, EventArgs arg)
        {
            Label selectedLabel = sender as Label;
            calendarControl1.Location = new Point(selectedLabel.Location.X + selectedLabel.Width, selectedLabel.Location.Y + selectedLabel.Height);
            calendarControl1.Visible = true;
            selectedDateLabel = selectedLabel;

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

        private void calendarControl1_DateTimeChange(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.Controls.CalendarControl cc = sender as DevExpress.XtraEditors.Controls.CalendarControl;
            selectedDate = cc.DateTime.ToString("yy.MM.dd (ddd)");
            selectedDateLabel.Text = selectedDate;
            //MessageBox.Show(selectedDate);
            cc.Visible = false;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
           
            todoContents.Add(" - - - ");
            //dateLabelList.Add( )
        }
    }
}
