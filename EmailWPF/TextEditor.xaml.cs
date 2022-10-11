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

namespace EmailWPF
{
    /// <summary>
    /// Interaction logic for TextEditor.xaml
    /// </summary>
    public partial class TextEditor : UserControl
    {
        bool IsBold = false;
        bool IsItalic = false;
        bool IsUnderline = false;
        int ProgramCounter = 0;

        public TextEditor()
        {
            InitializeComponent();
        }
        private void Testing(object sender, RoutedEventArgs e)
        {
            rtfbox.Selection.ApplyPropertyValue(Run.FontWeightProperty, FontWeights.Normal);
            rtfbox.Selection.ApplyPropertyValue(Run.FontStyleProperty, FontStyles.Normal);
            rtfbox.Selection.ApplyPropertyValue(Inline.TextDecorationsProperty, null);
        }
        private void Bold(object sender, RoutedEventArgs e)
        {
            if (!IsBold)
            {
                rtfbox.Selection.ApplyPropertyValue(Run.FontWeightProperty, FontWeights.Bold);
                IsBold = true;
            }
            else
            {
                rtfbox.Selection.ApplyPropertyValue(Run.FontWeightProperty, FontWeights.Normal);
                IsBold = false;
            }

        }
        private void Italic(object sender, RoutedEventArgs e)
        {
            if (!IsItalic)
            {
                rtfbox.Selection.ApplyPropertyValue(Run.FontStyleProperty, FontStyles.Italic);
                IsItalic = true;
            }
            else
            {
                rtfbox.Selection.ApplyPropertyValue(Run.FontStyleProperty, FontStyles.Normal);
                IsItalic = false;
            }
                
        }
        private void Underline(object sender, RoutedEventArgs e)
        {
            if (!IsUnderline)
            {
                rtfbox.Selection.ApplyPropertyValue(Inline.TextDecorationsProperty, TextDecorations.Underline);
                IsUnderline = true;
            }

            else
            {
                rtfbox.Selection.ApplyPropertyValue(Inline.TextDecorationsProperty, null);
                IsUnderline = false;
            }
                
        }
        private void ColorTable_SelectedColorChanged(object sender, RoutedPropertyChangedEventArgs<Color?> e)
        {
            Color clr = Color.FromArgb(
                ColorTable.SelectedColor.Value.A, 
                ColorTable.SelectedColor.Value.R, 
                ColorTable.SelectedColor.Value.G,
                ColorTable.SelectedColor.Value.B);
            SolidColorBrush brs = new SolidColorBrush(clr);
            rtfbox.Selection.ApplyPropertyValue(Run.ForegroundProperty, brs);
        }
        private void FontSize_Selected(object sender, RoutedEventArgs e)
        {
            if (ProgramCounter == 0) return;
            rtfbox.Selection.ApplyPropertyValue(Run.FontSizeProperty, FontSize.SelectedItem.ToString().Substring(38));
        }
        private void FontSize_DropDownClosed(object sender, EventArgs e)
        {
            return;
        }
        private void FontFam_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ProgramCounter == 0) return;
            rtfbox.Selection.ApplyPropertyValue(Run.FontFamilyProperty, FontFam.SelectedItem.ToString().Substring(38));
        }
        private void rtfbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            ProgramCounter++;
        }
    }
}
