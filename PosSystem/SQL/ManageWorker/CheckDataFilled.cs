namespace PosSystem
{
    class CheckDataFilled
    {
        public static bool TextboxFilled(ManageWorker manageWorker)
        {
            if (manageWorker.textBox1.Text != string.Empty &&
                manageWorker.textBox2.Text != string.Empty &&
                manageWorker.textBox3.Text != string.Empty &&
                manageWorker.textBox4.Text != string.Empty &&
                manageWorker.textBox5.Text != string.Empty &&
                manageWorker.textBox6.Text != string.Empty)
                return true;
            else
            {
                System.Windows.Forms.MessageBox.Show("Please insert all textboxes", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
