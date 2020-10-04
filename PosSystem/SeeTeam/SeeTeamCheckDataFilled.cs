namespace PosSystem
{
    class SeeTeamCheckDataFilled
    {
        public static bool TextboxFilled(SeeTeam seeTeam)
        {
            if (seeTeam.textBox5.Text != string.Empty && seeTeam.textBox6.Text != string.Empty)
                return true;
            else
            {
                System.Windows.Forms.MessageBox.Show("Please insert all textboxes", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }
    }
}