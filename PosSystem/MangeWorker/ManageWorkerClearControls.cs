using System.Windows.Forms;

namespace PosSystem
{
    class ManageWorkerClearControls
    {
        public static void ClearTextBoxesInPanel1(GroupBox groupBox1, GroupBox groupBox2, CheckBox checkBox)
        {
            foreach (Control item in groupBox1.Controls)
                if (item is TextBox)
                    ((TextBox)item).Text = string.Empty;

            foreach (Control item in groupBox2.Controls)
                if (item is TextBox)
                    ((TextBox)item).Text = string.Empty;
        }

        public static void EnabledToFalseControlsInGroupBox1(ManageWorker manageWorker)
        {
            manageWorker.groupBox1.Enabled = false;
            manageWorker.groupBox2.Enabled = false;
            manageWorker.checkBox1.Checked = false;
            manageWorker.pictureBox1.Image = Properties.Resources.DefaultAvatar;
        }

        public static void ClearTextBoxesInPanel2(GroupBox groupBox3)
        {
            foreach (Control item in groupBox3.Controls)
                if (item is TextBox)
                    ((TextBox)item).Text = string.Empty;

            groupBox3.Enabled = false;
        }
    }
}
