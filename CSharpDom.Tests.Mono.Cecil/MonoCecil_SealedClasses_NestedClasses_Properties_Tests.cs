using CSharpDom.TestTarget.SealedClasses.NestedClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_SealedClasses_NestedClasses_Properties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedClassWithInternalPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithInternalProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewStaticPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewStaticProperty));
        }

        //[TestMethod]
        //public void TestSealedClassWithNestedClassWithNewVirtualPropertyUsingMonoCecil()
        //{
        //    TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewVirtualProperty));
        //}

        [TestMethod]
        public void TestSealedClassWithNestedClassWithOverridePropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithOverrideProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPrivatePropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithProtectedPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithProtectedProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithProtectedInternalPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPublicPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPublicProperty));
        }

        //[TestMethod]
        //public void TestSealedClassWithNestedClassWithSealedOverridePropertyUsingMonoCecil()
        //{
        //    TestSealedClassAsync(typeof(SealedClassWithNestedClassWithSealedOverrideProperty));
        //}

        [TestMethod]
        public void TestSealedClassWithNestedClassWithStaticPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithStaticProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithVirtualPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithVirtualProperty));
        }
    }
}
