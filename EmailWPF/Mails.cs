using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Media;

namespace EmailWPF
{
    public class Mails:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }

        private string _sender = "";
        private string _subject = "";
        private string _content = "";
        private bool _isread = false;

        /*public string fontsize = "";
        public string fontfam = "";
        public Color fontcolor;
        public bool IsBold;
        public bool IsItalic;
        public bool IsUnderline;*/

        public bool IsRead
        {
            get { return _isread; }
            set
            {
                _isread = value;
                OnPropertyChanged(new PropertyChangedEventArgs("IsRead"));
            }
        }
        public string Sender {
            get { return _sender; }
            set{ _sender = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Sender"));
            }
        }
        public string Content
        {
            get { return _content; }
            set
            {
                _content = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Content"));
            }
        }
        public string Subject
        {
            get { return _subject; }
            set
            {
                _subject = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Subject"));
            }
        }

        public string Recipients { get; set; } = null;
        public string CopyRecipients { get; set; } = null;
        public string Date { get; set; } = null;
        public ObservableCollection<object> Attachments { get; set; } = new ObservableCollection<object>();
        public override string ToString()
        {
            return this.Subject;
        }
    }
}
