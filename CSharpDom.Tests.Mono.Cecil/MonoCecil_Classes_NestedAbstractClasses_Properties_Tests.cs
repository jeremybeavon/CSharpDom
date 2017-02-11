using CSharpDom.TestTarget.Classes.NestedAbstractClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedAbstractClasses_Properties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestClassWithNestedAbstractClassWithInternalPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithInternalProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithNewProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewStaticPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithNewStaticProperty));
        }

        //[TestMethod]
        //public void TestClassWithNestedAbstractClassWithNewVirtualPropertyUsingMonoCecil()
        //{
        //    TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewVirtualProperty));
        //}

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithOverridePropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithOverrideProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithPrivatePropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithProtectedPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithProtectedProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithProtectedInternalPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithPublicPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithPublicProperty));
        }

        //[TestMethod]
        //public void TestClassWithNestedAbstractClassWithSealedOverridePropertyUsingMonoCecil()
        //{
        //    TestClassAsync(typeof(ClassWithNestedAbstractClassWithSealedOverrideProperty));
        //}

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithStaticPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithStaticProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithVirtualPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithVirtualProperty));
        }
    }
}
