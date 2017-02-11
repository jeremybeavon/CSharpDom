using CSharpDom.TestTarget.Classes.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_Properties_AutoProperties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestClassWithInternalAutoPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNewAutoPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNewAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNewStaticAutoPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNewVirtualAutoPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNewVirtualAutoProperty));
        }

        [TestMethod]
        public void TestClassWithOverrideAutoPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public void TestClassWithPrivateAutoPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestClassWithProtectedAutoPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public void TestClassWithProtectedInternalAutoPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public void TestClassWithPublicAutoPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithPublicAutoProperty));
        }

        //[TestMethod]
        //public void TestClassWithSealedOverrideAutoPropertyUsingMonoCecil()
        //{
        //    TestClassAsync(typeof(ClassWithSealedOverrideAutoProperty));
        //}

        [TestMethod]
        public void TestClassWithStaticAutoPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithStaticAutoProperty));
        }

        [TestMethod]
        public void TestClassWithVirtualAutoPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithVirtualAutoProperty));
        }
    }
}
