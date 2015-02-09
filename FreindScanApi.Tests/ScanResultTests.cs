using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using FriendScan;
using FluentAssertions;

namespace FriendScanApi.Tests
{
    /// <summary>
    /// Summary description for UrlCollectionTests
    /// </summary>
    [TestClass]
    public class ScanResultTests
    {
        [TestMethod]
        public void ScanResult_NullFriendName_ThrowsArgumentNullException()
        {
            Action a = () => new ScanResult(null, new List<string>().AsReadOnly());
            a.ShouldThrow<ArgumentNullException>();
        }

        [TestMethod]
        public void ScanResult_NullBlogUrls_ThrowsArgumentNullException()
        {
            Action a = () => new ScanResult("Friend Name", null);
            a.ShouldThrow<ArgumentNullException>();
        }
    }
}
