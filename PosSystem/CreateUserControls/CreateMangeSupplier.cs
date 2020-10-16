using System.Linq;
using System.Windows.Forms;

namespace PosSystem
{
    internal class CreateMangeSupplier
    {
        public CreateMangeSupplier()
        {
            if (MoreThan1ChildInPanel())
                DestroyChildInPanel();
            else
                AddHomePageToPanel();
        }

        private void DestroyChildInPanel()
        {
            foreach (Control item in (Form.ActiveForm.Controls.Find("panel1", true).FirstOrDefault() as Panel).Controls.OfType<UserControl>())
                (Form.ActiveForm.Controls.Find("panel1", true).FirstOrDefault() as Panel).Controls.Remove(item);

            AddHomePageToPanel();
        }

        private void AddHomePageToPanel()
        {
            (Form.ActiveForm.Controls.Find("panel1", true).FirstOrDefault() as Panel).Controls.Add(new ManageSupplier());
        }

        private bool MoreThan1ChildInPanel()
        {
            return (Form.ActiveForm.Controls.Find("panel1", true).FirstOrDefault() as Panel).Controls.Count > 1;
        }
    }
}