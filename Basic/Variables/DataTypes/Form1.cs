using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataTypes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DataTypeSbyte_Click(object sender, EventArgs e)
        {
            MessageBox.Show("from -128 to 127");
        }

        private void DataTypeByte_Click(object sender, EventArgs e)
        {
            MessageBox.Show("from 0 to 255");
        }

        private void DataTypeShort_Click(object sender, EventArgs e)
        {
            MessageBox.Show("from -32768 to 32767");
        }

        private void DataTypeUshort_Click(object sender, EventArgs e)
        {
            MessageBox.Show("from 0 to 65535");
        }

        private void DataTypeInt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("from -2147483648 to 2147483647");
        }

        private void DataTypeUint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("from 0 4294967295");
        }

        private void DataTypeLong_Click(object sender, EventArgs e)
        {
            MessageBox.Show("from -9223372036854775808 to 9223372036854775807");
        }

        private void DataTypeUlong_Click(object sender, EventArgs e)
        {
            MessageBox.Show("from 0 to 18446744073709551615");
        }
       
    }
}
