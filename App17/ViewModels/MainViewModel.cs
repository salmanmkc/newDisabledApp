using System;

using App17.Helpers;

namespace App17.ViewModels
{
    public class MainViewModel : Observable
    {
        public MainViewModel()
        { }
            private string firstName;

            public string FirstName
            {
                get { return firstName; }
                set { firstName = value; }
            }


    }
    }
}
