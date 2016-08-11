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
            TestClassAsync(typeof(ClassWithInternalProperty));
        }

        [TestMethod]
        public void TestClassWithNewPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNewProperty));
        }

        [TestMethod]
        public void TestClassWithNewStaticPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNewStaticProperty));
        }

        //[TestMethod]
        //public void TestClassWithNewVirtualPropertyUsingMonoCecil()
        //{
        //    TestClassAsync(typeof(ClassWithNewVirtualProperty));
        //}

        [TestMethod]
        public void TestClassWithOverridePropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithOverrideProperty));
        }

        [TestMethod]
        public void TestClassWithPrivatePropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestClassWithProtectedPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithProtectedProperty));
        }

        [TestMethod]
        public void TestClassWithProtectedInternalPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public void TestClassWithPublicPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithPublicProperty));
        }

        //[TestMethod]
        //public void TestClassWithSealedOverridePropertyUsingMonoCecil()
        //{
        //    TestClassAsync(typeof(ClassWithSealedOverrideProperty));
        //}

        [TestMethod]
        public void TestClassWithStaticPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithStaticProperty));
        }

        [TestMethod]
        public void TestClassWithVirtualPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithVirtualProperty));
        }
    }
}
