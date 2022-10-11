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
using System.IO;
using System.Collections.ObjectModel;
using System.Xml.Serialization;

namespace EmailWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region hardcoded_content
        public string mail1 = "Build started! PRoject WPF email client status update";
        public string mail2 = "Buildings collapsing all over the world! The new material being used is proved to be very unstable, click this link to find out more!";
        public string mail3 = "hey bruh psst u wanna buy some pc components?";
        public string mail4 = "Do you think this is funny?";
        public string mail5 = "Hey boss, I heard your boss was talking to his boss, because he had to report to his boss, and then the boss of the boss that the boss was talking to walked in and.. hey boss?";
        public string mail6 = "Your email client, well, how to put it...it sucks";
        public string mail7 = "Hey, how are you? I heard they put everyone in quarantine over there... Hope you're okay";
        public string mail8 = "Yes.";
        public string mail9 = "This is not a drill. The Government has declared a state of emergency following the outbreak of sars-cov2. This is not a drill.";
        public static DataStruct mailboxes = new DataStruct();
        #endregion
        public MainWindow()
        {
            InitializeComponent();
            #region Load_Mails
            mailboxes.Mailbox1.Inbox.Add(new Mails()
            {
                Sender = "Alex Veljic",
                Subject = "Breaking news!",
                Content = mail2,
                Attachments = null,
                CopyRecipients = "Mhm",
                Recipients = "Jaz",
                Date = "21.3.2020"
            });
            mailboxes.Mailbox1.Inbox.Add(new Mails()
            {
                Sender = "Alex Veljic",
                Subject = "Project info",
                Content = mail1,
                Attachments = new ObservableCollection<object>() { "picture.png", "audio.mp3" },
                CopyRecipients = "Mhm",
                Recipients = "Jaz",
                Date = "10.3.2019"
            });
            mailboxes.Mailbox1.Inbox.Add(new Mails()
            {
                Sender = "Alex Veljic",
                Subject = "Selling pcs",
                Content = mail3,
                Attachments = null,
                CopyRecipients = "Mhm",
                Recipients = "Jaz",
                Date = "25.12.2019"
            });
            mailboxes.Mailbox1.Inbox.Add(new Mails()
            {
                Sender = "Alex Veljic",
                Subject = "Your grade",
                Content = mail6,
                Attachments = null,
                CopyRecipients = "Mhm",
                Recipients = "Jaz",
                Date = "21.8.2018"
            });
            mailboxes.Mailbox2.Inbox.Add(new Mails()
            {
                Sender = "Mirko Veljic",
                Subject = "BOSS!",
                Content = mail5,
                Attachments = null,
                CopyRecipients = "Mhm",
                Recipients = "Jaz",
                Date = "17.2.2015"
            });
            mailboxes.Mailbox2.Inbox.Add(new Mails()
            {
                Sender = "Perun Jaroslavljevic",
                Subject = "Humor.",
                Content = mail4,
                Attachments = null,
                CopyRecipients = "Mhm",
                Recipients = "Jaz",
                Date = "31.12.2017"
            });
            mailboxes.Mailbox2.Inbox.Add(new Mails()
            {
                Sender = "Perun Jaroslavljevic",
                Subject = "Checking in on you",
                Content = mail7,
                Attachments = null,
                CopyRecipients = "Mhm",
                Recipients = "Jaz",
                Date = "10.12.2019"
            });
            mailboxes.Mailbox2.Inbox.Add(new Mails()
            {
                Sender = "Perun Jaroslavljevic",
                Subject = "Yes indeed.",
                Content = mail8,
                Attachments = null,
                CopyRecipients = "Mhm",
                Recipients = "Jaz",
                Date = "21.3.2020"
            });
            mailboxes.Mailbox2.Inbox.Add(new Mails()
            {
                Sender = "Perun Jaroslavljevic",
                Subject = "Government SOE notification",
                Content = mail9,
                Attachments = null,
                CopyRecipients = "Mhm",
                Recipients = "Jaz",
                Date = "31.8.2020"
            });
            #endregion
        }

        #region ItemsSource updater
        private void RefreshSent1(object sender, MouseButtonEventArgs e)
        {
            MailContent.Text = "";
            MessageList.ItemsSource = mailboxes.Mailbox1.Sent;
        }
        private void RefreshSent2(object sender, MouseButtonEventArgs e)
        {
            MailContent.Text = "";
            MessageList.ItemsSource = mailboxes.Mailbox2.Sent;
        }
        private void RefreshInbox1(object sender, MouseButtonEventArgs e)
        {
            MailContent.Text = "";
            MessageList.ItemsSource = mailboxes.Mailbox1.Inbox; 
        }
        private void RefreshInbox2(object sender, MouseButtonEventArgs e)
        {
            MailContent.Text = "";
            MessageList.ItemsSource = mailboxes.Mailbox2.Inbox;
        }    
        private void RefreshDeleted1(object sender, MouseButtonEventArgs e)
        {
            MailContent.Text = "";
            MessageList.ItemsSource = mailboxes.Mailbox1.Deleted;
        }
        private void RefreshDeleted2(object sender, MouseButtonEventArgs e)
        {
            MailContent.Text = "";
            MessageList.ItemsSource = mailboxes.Mailbox2.Deleted;
        }
        #endregion

        #region Exercise_2&3-Windows_C#
        private string[] SetContent()
        {
            string content = "";
            var Key = MessageList.SelectedItem.ToString();

            foreach (var t in mailboxes.Mailbox1.Deleted)
            {
                if(t.Subject == Key)
                {
                    content = t.Content;
                    t.IsRead = true;
                }
            }

            foreach (var t in mailboxes.Mailbox2.Deleted)
            {
                if (t.Subject == Key)
                {
                    content = t.Content;
                    t.IsRead = true;
                }
            }

            foreach (var t in mailboxes.Mailbox1.Sent)
            {
                if (t.Subject == Key)
                {
                    content = t.Content;
                    t.IsRead = true;
                }
            }

            foreach (var t in mailboxes.Mailbox2.Sent)
            {
                if (t.Subject == Key)
                {
                    content = t.Content;
                    t.IsRead = true;
                }
            }

            foreach (var t in mailboxes.Mailbox1.Inbox)
            {
                if (t.Subject == Key)
                {
                    content = t.Content;
                    t.IsRead = true;
                }
            }

            foreach (var t in mailboxes.Mailbox2.Inbox)
            {
                if (t.Subject == Key)
                {
                    content = t.Content;
                    t.IsRead = true;
                }
            }

            string[] ret = { content, Key };
            return ret;  
        }
        private void ShowMailDW(object sender, MouseButtonEventArgs e)
        {
            string[] info = SetContent();
            DialogWindow dw = new DialogWindow();
            dw.Content.Text = info[0];
            dw.Title = info[1];

            // setting read-only properties below
            dw.Content.IsEnabled = false;
            dw.SendButton.IsEnabled = false;
            dw.AttachButton.IsEnabled = false;
            dw.AttachNames.IsEnabled = false;
            dw.Subject.IsEnabled = false;
            dw.RecipientBox.IsEnabled = false;
            dw.CopyRec.IsEnabled = false;
            dw.mailboxBox.IsEnabled = false;

            dw.ShowDialog();
        }
        private void SelectMailFromList(object sender, MouseButtonEventArgs e)
        {      
            DeleteButton.IsEnabled = true;
            DockController.Visibility = Visibility.Visible;
            MailContent.Text = SetContent()[0];
        }
        private void CloseButton(object sender, RoutedEventArgs e)
        {
            DockController.Visibility = Visibility.Hidden;
            //how to add a bg picture?
        }
        private void DeleteMsgButton(object sender, RoutedEventArgs e)
        {
            if (MessageList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Nothing selected");
                DeleteButton.IsEnabled = false;
                return;
            }

            MessageBoxButton buttons = MessageBoxButton.YesNo;
            MessageBoxResult result = MessageBox.Show("Are you sure you want to delete this?", "Attention!", buttons);

            if(result == MessageBoxResult.Yes)
            {
                var Key = MessageList.SelectedItem.ToString();

                foreach(var t in mailboxes.Mailbox1.Deleted)
                {
                    if (t.Subject == Key)
                    {
                        mailboxes.Mailbox1.Deleted.Remove(t);
                        RefreshDeleted1(null, null);
                        break;
                    }
                }

                foreach (var t in mailboxes.Mailbox2.Deleted)
                {
                    if (t.Subject == Key)
                    {
                        mailboxes.Mailbox2.Deleted.Remove(t);
                        RefreshDeleted2(null, null);
                        break;
                    }
                }

                foreach (var t in mailboxes.Mailbox1.Sent)
                {
                    if (t.Subject == Key)
                    {
                        mailboxes.Mailbox1.Sent.Remove(t);
                        mailboxes.Mailbox1.Deleted.Add(t);
                        RefreshSent1(null, null);
                        break;
                    }
                }

                foreach (var t in mailboxes.Mailbox2.Sent)
                {
                    if (t.Subject == Key)
                    {
                        mailboxes.Mailbox2.Sent.Remove(t);
                        mailboxes.Mailbox2.Deleted.Add(t);
                        RefreshSent2(null, null);
                        break;
                    }
                }

                foreach (var t in mailboxes.Mailbox1.Inbox)
                {
                    if (t.Subject == Key)
                    {
                        mailboxes.Mailbox1.Inbox.Remove(t);
                        mailboxes.Mailbox1.Deleted.Add(t);
                        RefreshInbox1(null, null);
                        break;
                    }
                }

                foreach (var t in mailboxes.Mailbox2.Inbox)
                {
                    if (t.Subject == Key)
                    {
                        mailboxes.Mailbox2.Inbox.Remove(t);
                        mailboxes.Mailbox2.Deleted.Add(t);
                        RefreshInbox2(null, null);
                        break;
                    }
                }
            }
        }
        private void RWInNewDialogWindow(object sender, RoutedEventArgs e)
        {
            DialogWindow dw = new DialogWindow();
            if (dw.ShowDialog() == true)
            {
                Properties.Settings.Default.Save();
            }
        }
        private void ReplyFunc(object sender, RoutedEventArgs e)
        {
            if (sender.ToString() == ReplyB.ToString())
            {
                MessageBox.Show("'Reply' button clicked");
            }
            if (sender.ToString() == ReplyAllB.ToString())
            {
                MessageBox.Show("'Reply all' button clicked");
            }
            if (sender.ToString() == ForwardB.ToString())
            {
                MessageBox.Show("'Forward' button clicked");
            }

            RWInNewDialogWindow(null, null);
            // in later updates, the sender's mail should be passed immediately to the new window
            // same applies for reply all and forward
        }
        #endregion

        #region Exercise_4-XML
        private void XMLImport(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.Multiselect = true;
            dlg.DefaultExt = ".";
            dlg.Filter = "XML Files (*.xml)|*.xml";

            Nullable<bool> result = dlg.ShowDialog();

            if(result == false)
            {
                return;
            }
            
            mailboxes.Mailbox1.Clear();
            mailboxes.Mailbox2.Clear();

            using(TextReader tr = new StreamReader(dlg.FileName))
            {
                XmlSerializer xs = new XmlSerializer(typeof(DataStruct));
                mailboxes = (DataStruct)xs.Deserialize(tr);
            }
        }
        private void XMLExport(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
            dlg.DefaultExt = ".";
            dlg.Title = "Save XML file";
            dlg.Filter =
                "All files (*.*)|*.*|" +
                "XML Files (*.xml)|*.xml";

            Nullable<bool> result = dlg.ShowDialog();

            using (TextWriter tw = new StreamWriter(dlg.FileName))
            {
                XmlSerializer xs = new XmlSerializer(typeof(DataStruct));
                xs.Serialize(tw, mailboxes);
            }
        }
        #endregion
    }
}