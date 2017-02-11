using CSharpDom.TestTarget.Classes.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_Properties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestClassWithInternalPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithInternalProperty));
        }

        [TestMethod]
        public void TestClassWithNewPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNewProperty));
        }

        [TestMethod]
        public void TestClassWithNewStaticPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNewStaticProperty));
        }

        //[TestMethod]
        //public void TestClassWithNewVirtualPropertyUsingMonoCecil()
        //{
        //    TestClassAsync(typeof(ClassWithNewVirtualProperty));
        //}

        [TestMethod]
        public void TestClassWithOverridePropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithOverrideProperty));
        }

        [TestMethod]
        public void TestClassWithPrivatePropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestClassWithProtectedPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithProtectedProperty));
        }

        [TestMethod]
        public void TestClassWithProtectedInternalPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public void TestClassWithPublicPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithPublicProperty));
        }

        //[TestMethod]
        //public void TestClassWithSealedOverridePropertyUsingMonoCecil()
        //{
        //    TestClassAsync(typeof(ClassWithSealedOverrideProperty));
        //}

        [TestMethod]
        public void TestClassWithStaticPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithStaticProperty));
        }

        [TestMethod]
        public void TestClassWithVirtualPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithVirtualProperty));
        }
    }
}
