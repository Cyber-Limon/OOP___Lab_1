using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            text_cl_2.Text = "";
        }

        private void text_cl_1_TextChanged(object sender, EventArgs e)
        {
            text_cl_2.Text = text_cl_1.Text;
        }

        private void text_cl_2_TextChanged(object sender, EventArgs e)
        {
            text_cl_1.Text = text_cl_2.Text;
        }

        private void text_cl_1_KeyDown(object sender, KeyEventArgs e)
        {
            text_code.Text = e.KeyValue.ToString();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            cord_X.Text = e.X.ToString();
            cord_Y.Text = e.Y.ToString();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.Button button = new System.Windows.Forms.Button();
            button.Location = new System.Drawing.Point(e.X - button.Size.Width / 2, 
                                                       e.Y - button.Size.Height / 2);
            button.Text = "---> 0";
            button.Click += new System.EventHandler(this.button7_Click);
            this.Controls.Add(button);            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) { text_check.Text = "+++++"; }
            else { text_check.Text = "-----"; }
        }

        private void button_ch_list_1_Click(object sender, EventArgs e)
        {
            checkedListBox1.SetItemChecked(0, true);
            checkedListBox1.BackColor = Color.Lime;
        }

        private void button_ch_list_2_Click(object sender, EventArgs e)
        {
            checkedListBox1.SetItemChecked(1, true);
            checkedListBox1.BackColor = Color.Yellow;
        }

        private void button_ch_list_3_Click(object sender, EventArgs e)
        {
            checkedListBox1.SetItemChecked(2, true);
            checkedListBox1.BackColor = Color.Red;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = System.Drawing.Image.FromFile("C:\\Users\\maxim\\source\\repos\\OOP_1\\1.jpg");
            label1.Text = "Орел";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.SelectedItem.ToString() + " " + comboBox1.Text);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            listBox3.Items.Add(dateTimePicker1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Windows.Forms.Label monday = new System.Windows.Forms.Label();
            monday.Location = new System.Drawing.Point(600, 260);
            monday.Size = new System.Drawing.Size(100, 100);
            monday.Text = "Понедельник - это первый, но далеко не последний день недели";
            this.Controls.Add(monday);
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            listBox3.Items.Add(monthCalendar1.SelectionRange.Start.ToShortDateString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem();
            ListViewItem.ListViewSubItem lvsi = new ListViewItem.ListViewSubItem();
            lvi.Text = textBox_fam.Text;
            lvsi.Text = textBox_name.Text;
            lvi.SubItems.Add(lvsi);
            listView1.Items.Add(lvi);

            textBox_fam.Text = "";
            textBox_name.Text = "";
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("Только цифры");
        }

        private void textBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = (numericUpDown1.Value + numericUpDown2.Value).ToString();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            label8.Text = (numericUpDown3.Value * numericUpDown3.Value).ToString();
        }
              
        private void notifyIcon1_MouseMove(object sender, MouseEventArgs e)
        {
            notifyIcon1.ShowBalloonTip(10);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) { MessageBox.Show("Радио-кнопка 1 выбрана"); }         
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked) { MessageBox.Show("Радио-кнопка 2 выбрана"); }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked) { MessageBox.Show("Радио-кнопка 3 выбрана"); }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value <= progressBar1.Maximum - progressBar1.Step) { progressBar1.Value += progressBar1.Step; }
            if (progressBar1.Value == progressBar1.Maximum) { MessageBox.Show("100 из 100"); }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            textBoxForRich.Text = richTextBox1.Text;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            textBoxTree.Text = treeView1.SelectedNode.Text;
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            MessageBox.Show("Документ загружен");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBoxSearch.Text);
        }

        private void label8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Результат возведения в квадрат");
        }

        private void buttonFLP2_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.BackColor = Color.Red;
        }

        private void buttonFLP1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.BackColor = Color.Blue;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked) { label11.Text = "Свет выключен"; };
            panel1.BackColor = Color.White;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked) { label11.Text = "Свет включен"; };
            panel1.BackColor = Color.Yellow;
        }

        private void buttonBig_Click(object sender, EventArgs e)
        {
            label12.Text = label12.Text.ToUpper();
        }

        private void buttonSmall_Click(object sender, EventArgs e)
        {
            label12.Text = label12.Text.ToLower();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0) { textBoxTab.Text = "Выбрана вкладка: 1"; }
            if (tabControl1.SelectedIndex == 1) { textBoxTab.Text = "Выбрана вкладка: 2"; }
        }

        int label_left, label_right = 1;

        private void progressBar2_Click(object sender, EventArgs e)
        {
            if (progressBar2.Value <= progressBar2.Maximum - progressBar1.Step) { 
                progressBar2.Value += progressBar2.Step;
                labelProgressBar.Text = "Выполнено: " + progressBar2.Value;
            }
            if (progressBar2.Value == progressBar2.Maximum) { labelProgressBar.Text = "Выполнено"; }
        }

        private void buttonTLP1_Click(object sender, EventArgs e)
        {
            progressBar3.Value = progressBar3.Maximum;
        }

        private void buttonTLP2_Click(object sender, EventArgs e)
        {
            progressBar3.Value = progressBar3.Minimum;
        }

        private void buttonTLP3_Click(object sender, EventArgs e)
        {
            if (progressBar3.Value <= progressBar3.Maximum - progressBar3.Step) { progressBar3.Value += progressBar3.Step; }
        }

        private void buttonTLP4_Click(object sender, EventArgs e)
        {
            if (progressBar3.Value >= progressBar3.Minimum + progressBar3.Step) { progressBar3.Value -= progressBar3.Step; }
        }

        private void buttonCLB_Click(object sender, EventArgs e)
        {
            listBox4.Items.Clear();
            foreach (string item in checkedListBox2.CheckedItems) listBox4.Items.Add(item);            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void белыйToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void белыйToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            menuStrip1.BackColor = Color.White;
        }

        private void синийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip1.BackColor= Color.Blue;
        }

        private void черныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip1.RightToLeft = RightToLeft.Yes;
        }

        private void белыйToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            menuStrip1.RightToLeft = RightToLeft.No;
        }

        string buffer;
        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buffer = textBoxMenu.SelectedText;
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxMenu.Paste(buffer);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(1235, 550);
        }

        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            label13.Text = i.ToString();
            if (i == 5) { button6.BackColor = Color.Red; }
            if (i == 10) { 
                button6.BackColor = Color.Blue;
                timer1.Enabled = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Minimum;
        }

        private void label14_SizeChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Размер изменен");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label14.Text = textBox2.Text;
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            label_left += 2;
            label_right *= 2;
            labelLeft.Text = label_left.ToString();
            labelRight.Text = label_right.ToString();
        }
    }
}
