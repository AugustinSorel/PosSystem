﻿using System.Windows.Forms;

namespace PosSystem
{
    class CheckDeleteItem
    {
        public static bool Check()
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to Delete this worker ?", "Warning", MessageBoxButtons.YesNo);
            return dialogResult == DialogResult.Yes;
        }
}
}
