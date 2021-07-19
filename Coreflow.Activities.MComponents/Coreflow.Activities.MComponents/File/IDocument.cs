using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coreflow.Activities.MComponents.File
{
    public interface IDocument
    {
        public string FileName { get; }

        public string Url { get; }
    }
}
