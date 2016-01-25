using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpDom.Tests
{
    [TestClass]
    public class UnitTest1
    {
        public event EventHandler event1;

        public event EventHandler event2
        {
            add { }
            remove { }
        }

        [TestMethod]
        public void TestMethod1()
        {
            
        }
    }
}