using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;

namespace Embryonic_UV_Analysis
{
    public class NumericTextBox : TextBox
    {
        //rights to amurra ... http://stackoverflow.com/questions/268207/how-to-create-a-numeric-textbox-in-silverlight
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            // Handle Shift case
            if (Keyboard.Modifiers == ModifierKeys.Shift)
            {
                e.Handled = true;
            }

            // Handle all other cases, OemMinus = keycode 189
            if (!e.Handled && (e.Key < Key.D0 || e.Key > Key.D9) && (e.Key != Key.Subtract) && (e.Key != Key.Decimal) && (e.Key != Key.OemMinus) && (e.Key != Key.OemPeriod))
            {
                if (e.Key < Key.NumPad0 || e.Key > Key.NumPad9)
                {
                    if (e.Key != Key.Back)
                    {
                        e.Handled = true;
                    }
                }
            }
        }
        public override string ToString()
        {
            return Text;
        }
    }
}
