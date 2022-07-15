using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TestGroupedComboBoxDatasource
{
    public partial class Form1 : Form
    {
        private int itemCounter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var loadedDataSource = new List<DummyItem>();

            Enumerable.Range(1, 3).ToList().ForEach(i =>
            {
                itemCounter++;
                loadedDataSource.Add(new DummyItem { ItemId = Guid.NewGuid(), ItemName = string.Concat("Item ", itemCounter.ToString()), GroupName = "Main Group" });
            });

            cboComboBox.DataSource = loadedDataSource;
        }

        private void btnChangeDataSource_Click(object sender, EventArgs e)
        {
            var changedDataSource = new List<DummyItem>();

            Enumerable.Range(1, 3).ToList().ForEach(i =>
            {
                itemCounter++;
                changedDataSource.Add(new DummyItem { ItemId = Guid.NewGuid(), ItemName = string.Concat("Item ", itemCounter.ToString()), GroupName = "Main Group" });
            });

            cboComboBox.DataSource = changedDataSource;
        }
    }

    /// <summary>
    /// DummyItem class represents the Dto I'm using in my main project
    /// </summary>
    internal class DummyItem
    {
        public Guid ItemId { get; set; }
        public string ItemName { get; set; }
        public string GroupName { get; set; }
    }
}
