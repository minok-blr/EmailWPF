using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace EmailWPF
{
    public class DataStruct
    {
        public ObservableCollection<Folder> mbs = new ObservableCollection<Folder>(); 
        public Folder Mailbox1 { get; set; } = new Folder();
        public Folder Mailbox2 { get; set; } = new Folder();
    }
}
