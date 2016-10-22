using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parallel_Tasks
{
    public partial class Form2 : Form
    {
        private string fileString1;
        private string fileString2;
        private string fileString3;
        private object selectedItem;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string fileString1, string fileString2, string fileString3, object selectedItem)
        {
            this.fileString1 = fileString1;
            this.fileString2 = fileString2;
            this.fileString3 = fileString3;
            this.selectedItem = selectedItem;
        }
    }
}
