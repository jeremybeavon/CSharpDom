using CSharpDom.TestTarget.SealedClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_SealedClasses_Properties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestSealedClassWithInternalPropertyUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithInternalProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNewPropertyUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNewProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNewStaticPropertyUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNewStaticProperty));
        }

        [TestMethod]
        public void TestSealedClassWithOverridePropertyUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithOverrideProperty));
        }

        [TestMethod]
        public void TestSealedClassWithPrivatePropertyUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestSealedClassWithProtectedPropertyUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithProtectedProperty));
        }

        [TestMethod]
        public void TestSealedClassWithProtectedInternalPropertyUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public void TestSealedClassWithPublicPropertyUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithPublicProperty));
        }

        [TestMethod]
        public void TestSealedClassWithSealedOverridePropertyUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public void TestSealedClassWithStaticPropertyUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithStaticProperty));
        }
    }
}
