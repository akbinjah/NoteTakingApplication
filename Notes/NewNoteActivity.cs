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
    [Activity(Label = "NewNoteActivity")]
    public class NewNoteActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.NewNote);

            // Get our button from the layout resource,
            // and attach an event to it
            EditText note_text = FindViewById<EditText>(Resource.Id.text_note_text);
            ImageButton back_button = FindViewById<ImageButton>(Resource.Id.button_back_add_note);
            Button save_button = FindViewById<Button>(Resource.Id.button_process_add_note);

            save_button.Click += delegate
            {
                // add note and clear text box
                AllOneNotes allOneNotes = SingletonNotes.GetSingleTon();
                OneNote oneNote = new OneNote("Main Category", note_text.Text);
                allOneNotes.Add(oneNote);
                note_text.Text = "";
            };

            back_button.Click += delegate
            {
                StartActivity(typeof(MainActivity));
            };
        }
    }
}