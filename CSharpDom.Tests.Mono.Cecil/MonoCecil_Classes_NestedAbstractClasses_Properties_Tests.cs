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
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithInternalProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewStaticPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewStaticProperty));
        }

        //[TestMethod]
        //public void TestClassWithNestedAbstractClassWithNewVirtualPropertyUsingMonoCecil()
        //{
        //    TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewVirtualProperty));
        //}

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithOverridePropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithOverrideProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithPrivatePropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithProtectedPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithProtectedInternalPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithPublicPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithPublicProperty));
        }

        //[TestMethod]
        //public void TestClassWithNestedAbstractClassWithSealedOverridePropertyUsingMonoCecil()
        //{
        //    TestClassAsync(typeof(ClassWithNestedAbstractClassWithSealedOverrideProperty));
        //}

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithStaticPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithStaticProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithVirtualPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithVirtualProperty));
        }
    }
}
