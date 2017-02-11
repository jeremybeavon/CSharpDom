using CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_SealedClasses_NestedSealedClasses_Properties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithInternalPropertyUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithInternalProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithNewPropertyUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithNewProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithNewStaticPropertyUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithNewStaticProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithOverridePropertyUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithOverrideProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithPrivatePropertyUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithProtectedPropertyUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithProtectedProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithProtectedInternalPropertyUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithPublicPropertyUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithPublicProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithSealedOverridePropertyUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithStaticPropertyUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithStaticProperty));
        }
    }
}
