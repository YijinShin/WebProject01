using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OAHelperTest
{
    public partial class Form1 : Form
    {
        private Point mousePoint;
        
        public class TestData
        {
            public string data1 { get; private set; }
            public string data2 { get; private set; }
            public int data3 { get; private set; }
            public TestData(string data1, string data2, int data3)
            {
                this.data1 = data1;
                this.data2 = data2;
                this.data3 = data3;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }



        private void From1_Load(object sender, EventArgs e)
        {
            List<TestData> testData = GetTestDataList();
            this.gridControl1.DataSource = testData;
        }

        //create, return test data list 
        private List<TestData> GetTestDataList()
        {
            List<TestData> testDataList = new List<TestData>();
            testDataList.Add(new TestData("A", "aaa", 1));
            testDataList.Add(new TestData("B", "bbb", 2));
            testDataList.Add(new TestData("C", "ccc", 3));
            testDataList.Add(new TestData("D", "ddd", 4));

            return testDataList;
        }

        private void From1_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y); //save current window location
        }

        private void From1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int x = mousePoint.X - e.X;
                int y = mousePoint.Y - e.Y;
                Location = new Point(this.Left - x, this.Top - y);
            }
        }

        private void gridView1_MouseMove(object sender, MouseEventArgs e)
        {
            var info = gridView1.CalcHitInfo(gridControl1.PointToClient(Cursor.Position));
            gridView1.FocusedRowHandle = info.RowHandle;
          
        }

        private void gridView1_MouseLeave(object sender, EventArgs e)
        {
            gridView1.OptionsSelection.EnableAppearanceFocusedRow = false;

        }
    }
}
