using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08
{
    public interface IBag<Book> : IEnumerable
    { ///
      /// Add an item to the bag. null items are ignored. ///
        void Pack(Book item);

        /// <summary>
        /// Remove the item from the bag at the given index.
        /// </summary>
        /// <returns>The item that was removed.</returns>
        Book Unpack(int index);

    }
}
