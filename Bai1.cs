using System;
using System.Windows.Forms;

namespace KT1_2033216515_NguyenHoangPhuc
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Dữ liệu bạn nhập không hợp lệ.", "Có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            e.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dia1 = MessageBox.Show("Bạn có chắc chắn muốn tắt chương trình?", "Lưu ý!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dia1 == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số n và m.", "Có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int n = Int32.Parse(textBox1.Text);
            int m = Int32.Parse(textBox2.Text);

            int mod3count = 0;

            for (int i = n; i <= m; i++)
            {
                if (i % 3 == 0)
                {
                    mod3count++;
                }
            }

            textBox3.Text = mod3count.ToString();
        }
    }
}
