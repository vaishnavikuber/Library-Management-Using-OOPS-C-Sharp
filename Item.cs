using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementSystem
{
    abstract class Item
    {

        public string Title { get; set; }
        public abstract void DisplayInfo();

    }
}
