using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KT1_2033216515_NguyenHoangPhuc
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
            checkBox2.Checked = false;
        }

        private void checkBox2_Click(object sender, EventArgs e)
        {
            checkBox2.Checked = true;
            checkBox1.Checked = false;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Dữ liệu bạn nhập không hợp lệ.", "Có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Dữ liệu bạn nhập không hợp lệ.", "Có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Dữ liệu bạn nhập không hợp lệ.", "Có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TongTien tongTien;

            if (radioButton1.Checked)
            {
                if (textBox1.Text != "")
                {
                    tongTien = new TongTien(checkBox1.Checked ? 0 : 1, 0, Int32.Parse(textBox3.Text));
                    textBox4.Text = tongTien.ThanhTien().ToString();

                    button2.Enabled = true;
                } else
                {
                    MessageBox.Show("Vui lòng nhập số lượng cho Cua biển.", "Có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else if (radioButton2.Checked)
            {
                if (textBox2.Text != "")
                {
                    tongTien = new TongTien(checkBox1.Checked ? 0 : 1, 1, Int32.Parse(textBox2.Text));
                    textBox4.Text = tongTien.ThanhTien().ToString();
                    button2.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số lượng cho Ghẹ biển.", "Có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else if (radioButton3.Checked)
            {
                if (textBox3.Text != "")
                {
                    tongTien = new TongTien(checkBox1.Checked ? 0 : 1, 2, Int32.Parse(textBox3.Text));
                    textBox4.Text = tongTien.ThanhTien().ToString();
                    button2.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số lượng cho Ghẹ biển.", "Có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string textBox1value = textBox1.Text;
            int textBox1res;

            if (Int32.TryParse(textBox1value, out textBox1res))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetIconAlignment(textBox1, ErrorIconAlignment.MiddleRight);
                errorProvider1.SetIconPadding(textBox1, 5);
                errorProvider1.SetError(textBox1, "Dữ liệu không hợp lệ");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string textBox2value = textBox2.Text;
            int textBox2res;

            if (Int32.TryParse(textBox2value, out textBox2res))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetIconAlignment(textBox2, ErrorIconAlignment.MiddleRight);
                errorProvider1.SetIconPadding(textBox2, 5);
                errorProvider1.SetError(textBox2, "Dữ liệu không hợp lệ");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string textBox3value = textBox3.Text;
            int textBox3res;

            if (Int32.TryParse(textBox3value, out textBox3res))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetIconAlignment(textBox3, ErrorIconAlignment.MiddleRight);
                errorProvider1.SetIconPadding(textBox3, 5);
                errorProvider1.SetError(textBox3, "Dữ liệu không hợp lệ");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dia1 = MessageBox.Show("Bạn có chắc chắn muốn tắt chương trình?", "Lưu ý!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dia1 == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Enabled)
            {
                textBox4.Text = "";
                checkBox1.Checked = true;
                checkBox2.Checked = false;

                radioButton1.Checked = true;
                radioButton2.Checked = false;
                radioButton3.Checked = false;

                textBox1.Text = "1";
                textBox2.Text = "1";
                textBox3.Text = "1";

                button2.Enabled = false;
            }
        }
    }
}
