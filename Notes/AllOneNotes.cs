using System;
using System.Collections.Generic;

namespace Notes
{
    public class AllOneNotes
    {
        private List<OneNote> allNotes;

        public AllOneNotes()
        {
            allNotes = new List<OneNote>();
        }

        public void Add(OneNote aNote)
        {
            allNotes.Add(aNote);
        }

        public OneNote GetNote(int i)
        {
            try
            {
                return allNotes[i];
            }
            catch(Exception)
            {
                return null;
            }
        }
    }
}