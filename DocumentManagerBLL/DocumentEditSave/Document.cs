using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManagerBLL
{
    public class Document
    {
        public string DocumentName { get; set; }
        
        public  DocumentMemento CreateMemento()
        {
            return new DocumentMemento() { DocumentName = this.DocumentName };
        }
        public void LoadDocumentMemonto(DocumentMemento memento)
        {
            this.DocumentName = memento.DocumentName;
        }
    }
}
