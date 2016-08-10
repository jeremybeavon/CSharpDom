using CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_SealedClasses_NestedAbstractClasses_Properties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithInternalPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithInternalProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithNewPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNewProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithNewStaticPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNewStaticProperty));
        }

        //[TestMethod]
        //public void TestSealedClassWithNestedAbstractClassWithNewVirtualPropertyUsingMonoCecil()
        //{
        //    TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNewVirtualProperty));
        //}

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithOverridePropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithOverrideProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithPrivatePropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithProtectedPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithProtectedProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithProtectedInternalPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithPublicPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithPublicProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithSealedOverridePropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithStaticPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithStaticProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithVirtualPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithVirtualProperty));
        }
    }
}
