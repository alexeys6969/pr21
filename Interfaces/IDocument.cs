using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace documents_shashin.Interfaces
{
    public interface IDocument
    {
        void Save(bool Update = false);
        List<documents_shashin.Classes.DocumentContext> AllDocuments();
        void Delete();
    }
}
