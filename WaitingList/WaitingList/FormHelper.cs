using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaitingList
{
    class FormHelper
    {
        public static bool SureToDelete()
        {
            return MessageBox.Show("삭제하시겠습니까?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes;
        }
    }
}
