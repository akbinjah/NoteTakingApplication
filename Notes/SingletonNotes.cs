using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Notes
{
    class SingletonNotes
    {
        private static AllOneNotes allOneNotes;

        public static AllOneNotes GetSingleTon()
        {
            if (allOneNotes == null)
                allOneNotes = new AllOneNotes();

            return allOneNotes;
        }
    }
}