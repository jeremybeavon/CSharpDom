using CSharpDom.TestTarget.Classes.NestedClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedClasses_Properties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestClassWithNestedClassWithInternalPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithInternalProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithNewProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewStaticPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithNewStaticProperty));
        }

        //[TestMethod]
        //public void TestClassWithNestedClassWithNewVirtualPropertyUsingMonoCecil()
        //{
        //    TestClassAsync(typeof(ClassWithNestedClassWithNewVirtualProperty));
        //}

        [TestMethod]
        public void TestClassWithNestedClassWithOverridePropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithOverrideProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPrivatePropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithProtectedProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedInternalPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPublicPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithPublicProperty));
        }

        //[TestMethod]
        //public void TestClassWithNestedClassWithSealedOverridePropertyUsingMonoCecil()
        //{
        //    TestClassAsync(typeof(ClassWithNestedClassWithSealedOverrideProperty));
        //}

        [TestMethod]
        public void TestClassWithNestedClassWithStaticPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithStaticProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithVirtualPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithVirtualProperty));
        }
    }
}
