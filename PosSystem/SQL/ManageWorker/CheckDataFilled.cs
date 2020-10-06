namespace PosSystem
{
    class CheckDataFilled
    {
        public static bool TextboxFilled(ManageWorker manageWorker)
        {
            if (manageWorker.txtBoxName.Text != string.Empty &&
                manageWorker.txtBoxSurname.Text != string.Empty &&
                manageWorker.txtBoxAge.Text != string.Empty &&
                manageWorker.txtBoxGender.Text != string.Empty &&
                manageWorker.txtBoxUsername.Text != string.Empty &&
                manageWorker.txtBoxPassword.Text != string.Empty)
                return true;
            else
            {
                System.Windows.Forms.MessageBox.Show("Please insert all textboxes", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
