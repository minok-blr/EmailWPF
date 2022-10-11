using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace EmailWPF
{
    public class Folder
    {
        public string Title = "Mailbox with subfolders";
        public ObservableCollection<Mails> Inbox { get; set; } = new ObservableCollection<Mails>();
        public ObservableCollection<Mails> Sent { get; set; } = new ObservableCollection<Mails>();
        public ObservableCollection<Mails> Deleted { get; set; } = new ObservableCollection<Mails>();
        public void Clear()
        {
            Inbox.Clear();
            Sent.Clear();
            Deleted.Clear();
        }
    }
}
