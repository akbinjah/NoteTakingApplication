using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Notes
{
    [Activity(Label = "ShowNotesActivity")]
    public class ShowNotesActivity : Activity
    {
        int current_index = 0;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.ShowNotes);

            // Get our button from the layout resource,
            // and attach an event to it
            EditText note_text = FindViewById<EditText>(Resource.Id.NoteTxt);
            ImageButton back_button = FindViewById<ImageButton>(Resource.Id.BackBtn);
            Button first_button = FindViewById<Button>(Resource.Id.FirstBtn);
            Button next_button = FindViewById<Button>(Resource.Id.NextBtn);
            Button previous_button = FindViewById<Button>(Resource.Id.PreviousBtn);

            first_button.Click += delegate
            {
                // add note and clear text box
                AllOneNotes allOneNotes = SingletonNotes.GetSingleTon();
                current_index = 0;
                OneNote oneNote = allOneNotes.GetNote(current_index);
                if(oneNote!=null)
                {
                    note_text.Text = oneNote.Note;
                }
                else
                {
                    note_text.Text = "";
                }
            };

            next_button.Click += delegate
            {
                // add note and clear text box
                AllOneNotes allOneNotes = SingletonNotes.GetSingleTon();
                current_index = current_index + 1;
                OneNote oneNote = allOneNotes.GetNote(current_index);
                if (oneNote != null)
                {
                    note_text.Text = oneNote.Note;
                }
                else
                {
                    note_text.Text = "";
                }
            };

            previous_button.Click += delegate
            {
                // add note and clear text box
                AllOneNotes allOneNotes = SingletonNotes.GetSingleTon();
                current_index = current_index - 1;
                OneNote oneNote = allOneNotes.GetNote(current_index);
                if (oneNote != null)
                {
                    note_text.Text = oneNote.Note;
                }
                else
                {
                    note_text.Text = "";
                }
            };

            back_button.Click += delegate
            {
                StartActivity(typeof(MainActivity));
            };
        }
    }
}