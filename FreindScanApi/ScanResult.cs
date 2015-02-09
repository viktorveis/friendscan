using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FriendScan
{
    /// <summary>
    /// Represents all information found online for a friend. The class is immutable.
    /// </summary>
    public class ScanResult
    {
        /// <summary>
        /// The friend name that was scanned.
        /// </summary>
        public string FriendName { get; private set; }

        /// <summary>
        /// A collection of blog URLs for the friend.
        /// </summary>
        public IReadOnlyCollection<string> BlogUrls { get; private set; }

        public ScanResult(string friendName, IReadOnlyCollection<string> blogUrls)
        {
            if (null == friendName) throw new ArgumentNullException("friendName");
            if (null == blogUrls) throw new ArgumentNullException("blogUrls");

            this.FriendName = friendName;
            this.BlogUrls = blogUrls;
        }
    }
}
