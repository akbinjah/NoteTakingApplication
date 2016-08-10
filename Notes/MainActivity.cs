using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Notes
{
    [Activity(Label = "Notes Manager", MainLauncher = true, Icon = "@drawable/Icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            ImageButton button_add_new = FindViewById<ImageButton>(Resource.Id.button_add_note);
            ImageButton button_show_notes = FindViewById<ImageButton>(Resource.Id.button_show_notes);

            button_add_new.Click += delegate 
            {
                StartActivity(typeof(NewNoteActivity));
            };

            button_show_notes.Click += delegate
            {
                StartActivity(typeof(ShowNotesActivity));
            };
        }
    }
}

