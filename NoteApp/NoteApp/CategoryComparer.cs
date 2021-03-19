using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    class CategoryComparer : IComparer<Note>
    {
        public int Compare(Note x, Note y)
        {
            if (x.Modified > y.Modified)
                return 1;
            else if (x.Modified < y.Modified)
                return -1;
            else
                return 0;
        }
    }
}
