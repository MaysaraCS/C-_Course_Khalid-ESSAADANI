namespace TreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            treeView1.Nodes.Add("AnimalNode", "Animal", 0, 0);
            treeView1.Nodes[0].Nodes.Add("", "Lion", 1, 1);
            treeView1.Nodes[0].Nodes.Add("", "Tiger", 1, 1);
            treeView1.Nodes[0].Nodes.Add("", "Horse", 1, 1);

            treeView1.Nodes.Add("PrgNode", "Programming laguage", 0, 0);
            treeView1.Nodes[1].Nodes.Add("", "Java", 1, 1);
            treeView1.Nodes[1].Nodes.Add("", "C#", 1, 1);
            treeView1.Nodes[1].Nodes.Add("", "Python", 1, 1);


            listView1.Columns.Add("Folders");
            listView1.Columns.Add("Description");

            listView1.Items.Add("Folder1", 0);
            listView1.Items.Add("Folder2", 0);
            listView1.Items.Add("Folder3", 0);
            listView1.Items.Add("Folder4", 0);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (TreeNode node in treeView1.Nodes)
            {
                if (node.Checked == true)
                {
                    listBox1.Items.Add(node.Text);
                }
            }
            for (int i = 0; i < treeView1.Nodes.Count; i++)
            {
                foreach (TreeNode node in treeView1.Nodes[i].Nodes)
                {
                    if (node.Checked == true)
                    {
                        listBox1.Items.Add(node.Text);
                    }
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "LargeIcon")
            {
                listView1.View = View.LargeIcon;
            }
            else if (comboBox1.Text == "Details")
            {
                listView1.View = View.Details;
            }
            else if (comboBox1.Text == "SmallIcon")
            {
                listView1.View = View.SmallIcon;
            }
            else if (comboBox1.Text == "Tile")
            {
                listView1.View = View.Tile;
            }
            else if (comboBox1.Text == "List")
            {
                listView1.View = View.List;
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Program is mine ", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
