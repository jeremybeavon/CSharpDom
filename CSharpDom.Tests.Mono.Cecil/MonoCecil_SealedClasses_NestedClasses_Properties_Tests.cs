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
            TestSealedClass(typeof(SealedClassWithNestedClassWithInternalProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewPropertyUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithNewProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewStaticPropertyUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithNewStaticProperty));
        }

        //[TestMethod]
        //public void TestSealedClassWithNestedClassWithNewVirtualPropertyUsingMonoCecil()
        //{
        //    TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewVirtualProperty));
        //}

        [TestMethod]
        public void TestSealedClassWithNestedClassWithOverridePropertyUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithOverrideProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPrivatePropertyUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithProtectedPropertyUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithProtectedProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithProtectedInternalPropertyUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPublicPropertyUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithPublicProperty));
        }

        //[TestMethod]
        //public void TestSealedClassWithNestedClassWithSealedOverridePropertyUsingMonoCecil()
        //{
        //    TestSealedClassAsync(typeof(SealedClassWithNestedClassWithSealedOverrideProperty));
        //}

        [TestMethod]
        public void TestSealedClassWithNestedClassWithStaticPropertyUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithStaticProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithVirtualPropertyUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithVirtualProperty));
        }
    }
}
