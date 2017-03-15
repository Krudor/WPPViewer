using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPPViewer.Model
{
    public class Chat
    {
        public Unit Source { get; set; }
        public Unit Target { get; set; }
        public string Text { get; set; }
    }
}
