using System;

namespace Notes
{
    public class OneNote
    {
        private String category;
        private String note;

        public OneNote()
        {
            category = "";
            note = "";
        }

        public OneNote(String a_category, String a_note)
        {
            category = a_category;
            note = a_note;
        }

        public String Category
        {
            get
            {
                return category;
            }
            set
            {
                category = value;
            }
        }

        public String Note
        {
            get
            {
                return note;
            }
            set
            {
                note = value;
            }
        }
    }
}