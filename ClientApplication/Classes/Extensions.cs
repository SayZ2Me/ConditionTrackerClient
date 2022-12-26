using ClientApplication.Managers;
using System.Reflection;

namespace ClientApplication.Classes
{
    internal static class Extensions
    {
        public static IEnumerable<Control> All(this Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                foreach (Control childControl in control.Controls.All())
                {
                    yield return childControl;
                }
                yield return control;
            }
        }
        public static void SetDoubleBuffered(this Control control)
        {
            try
            {
                typeof(Control).InvokeMember("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty, null, control, new object[] { true });
            }
            catch (Exception exception)
            {
                FormManager.ShowErrorWindow("Graphics exception", exception.Message);
            }
        }
    }
}
