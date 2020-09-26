using System.Linq;
using System.Windows.Forms;

namespace PosSystem
{
    class CreateHomePage
    {
        public static void CreateNewHomePage()
        {
            if (MoreThan1ChildInPanel())
                DestroyChildInPanel();
            else
                AddHomePageToPanel();
        }

        private static void DestroyChildInPanel()
        {
            MessageBox.Show("DEBUG: there is MORE THAN 1 usercontrol in the panel...", "Warnig", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private static void AddHomePageToPanel()
        {
            (Form.ActiveForm.Controls.Find("panel1", true).FirstOrDefault() as Panel).Controls.Add(new HomePage());
        }

        private static bool MoreThan1ChildInPanel()
        {
            return (Form.ActiveForm.Controls.Find("panel1", true).FirstOrDefault() as Panel).Controls.Count > 1;
        }
    }
}
