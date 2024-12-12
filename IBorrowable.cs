using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementSystem
{
    internal interface IBorrowable
    {
        public void Borrow();

        public void Return();
    }
}
