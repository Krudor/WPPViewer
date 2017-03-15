using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPPViewer.Utils;

namespace WPPViewer.Model
{
    public class Spell
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public bool ServerSide { get; set; }
        public string WowheadLink => WowheadUtils.GetWowheadURLForSpell(Id);
    }
}
