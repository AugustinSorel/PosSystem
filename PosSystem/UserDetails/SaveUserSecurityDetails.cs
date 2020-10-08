using System.Windows.Forms;

namespace PosSystem
{
    class SaveUserSecurityDetails
    {
        private readonly UserDetails UserDetails;

        public SaveUserSecurityDetails(UserDetails userDetails)
        {
            UserDetails = userDetails;
            if (CheckBoxChanged() && userDetails.checkBox1.Visible)
                ShowWarning();
            else
                SaveUserSecurity();
        }

        private void ShowWarning()
        {
            DialogResult dialogResult = MessageBox.Show("By removing admin right you will be logout...", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                SaveUserSecurity();
                new BackToLoginPage();
            }
        }

        private bool CheckBoxChanged()
        {
            return !UserDetails.checkBox1.Checked;
        }

        private void SaveUserSecurity()
        {
            new SaveUserSecurity(UserDetails);
            MessageBox.Show("Account Security saved successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UserDetails.groupBox2.Enabled = false;
        }
    }
}
