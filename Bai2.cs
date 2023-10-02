using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KT1_2033216515_NguyenHoangPhuc
{
    public partial class Bai2 : Form
    {
        private Bai2Array b2arr;

        public Bai2()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
                MessageBox.Show("Dữ liệu bạn nhập không hợp lệ.", "Có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                b2arr = new Bai2Array(textBox1.Text);
                MessageBox.Show("Đã nhập mảng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show("Vui lòng nhập số n và m.", "Có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dia1 = MessageBox.Show("Bạn có chắc chắn muốn tắt chương trình?", "Lưu ý!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dia1 == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (b2arr != null)
            {
                List<int> arr = b2arr.sortArray();
                textBox2.Text = String.Join(" ", arr);
            } else
            {
                MessageBox.Show("Bạn chưa nhập mảng.", "Có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
