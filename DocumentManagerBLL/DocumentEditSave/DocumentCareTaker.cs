using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManagerBLL
{
    public class DocumentCareTaker
    {
        public List<DocumentMemento> DocumentMementos { get; set; }
        public DocumentCareTaker()
        {
            DocumentMementos = new List<DocumentMemento>();
        }
    }
}
