using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfApp4
{
    internal class MatchTextBox: TextBox
    {        
        protected override void OnTextChanged(TextChangedEventArgs e)
        {
            var Pattern = $"^(\\-|\\+)?\\d+(\\.\\d+)?$";
            var PatternEndPoint = $"^(\\-|\\+)?\\d+(\\.){{1}}$";// (-)XX. 情況
            if (this.Text != "-")
            {
                if(!Regex.IsMatch(this.Text, Pattern))
                {
                    if (Regex.IsMatch(this.Text, PatternEndPoint))
                    {
                        return;
                    }
                    this.Text = "";
                }
            }
           
        }
    }
}
