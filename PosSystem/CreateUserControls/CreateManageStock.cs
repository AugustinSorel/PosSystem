using System.Linq;
using System.Windows.Forms;

namespace PosSystem
{
    class CreateManageStock
    {
        public CreateManageStock()
        {
            if (MoreThan1ChildInPanel())
                DestroyChildInPanel();
            else
                AddUserDetails();
        }

        private void DestroyChildInPanel()
        {
            foreach (Control item in (Form.ActiveForm.Controls.Find("panel1", true).FirstOrDefault() as Panel).Controls.OfType<UserControl>())
                (Form.ActiveForm.Controls.Find("panel1", true).FirstOrDefault() as Panel).Controls.Remove(item);

            AddUserDetails();
        }

        private void AddUserDetails()
        {
            (Form.ActiveForm.Controls.Find("panel1", true).FirstOrDefault() as Panel).Controls.Add(new ManageStock());
        }

        private bool MoreThan1ChildInPanel()
        {
            return (Form.ActiveForm.Controls.Find("panel1", true).FirstOrDefault() as Panel).Controls.Count > 1;
        }
    }
}

