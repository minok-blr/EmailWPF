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
using System.Windows.Shapes;

namespace EmailWPF
{
    /// <summary>
    /// Interaction logic for DialogWindow.xaml
    /// </summary>
    public partial class DialogWindow : Window
    {
        public DialogWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true; //keep changes made in the window
        }
        private void SendMsgButton(object sender, RoutedEventArgs e)
        {
            if (Subject.Text == "" || RecipientBox.Text == "")
            {
                MessageBox.Show("Please specify subject and recipient!");
            }
            else
            {
                if (mailboxBox.Text.Equals("sender1"))
                {
                    MainWindow.mailboxes.Mailbox1.Sent.Add(new Mails() { 
                        Content = this.Content.Text, 
                        Subject = this.Subject.Text
                    });
                    //MainWindow.Sent1.Add(Subject.Text, Content.Text);
                }
                else
                {
                    MainWindow.mailboxes.Mailbox2.Sent.Add(new Mails() { Content = this.Content.Text, Subject = this.Subject.Text });
                    //MainWindow.Sent2.Add(Subject.Text, Content.Text); 
                }
                Close();
            }
        }
        private void AttachmentButton(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.Multiselect = true;
            dlg.DefaultExt = ".";
            dlg.Filter =
                "All files (*.*)|*.*|" +
                "JPEG Files (*.jpeg)|*.jpeg|" +
                "PNG Files (*.png)|*.png|" +
                "JPG Files (*.jpg)|*.jpg|" +
                "BMP Files (*.bmp)|*.bmp|" +
                "MP3 Files (*.mp3)|*.mp3|" +
                "WMV Files (*.wmv)|*.wmv|" +
                "MPG Files (*.mpg)|*.mpg|" +
                "MPEG Files (*.mpeg)|*.mpeg";

            Nullable<bool> result = dlg.ShowDialog();


            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                string filename = dlg.FileName;
                foreach(var t in dlg.FileNames)
                {
                    var res = System.IO.Path.GetFileName(t.ToString());
                    AttachNames.Items.Add(res);
                }
                
                //textbox.Text = filename;
            }
        }
    }
}
