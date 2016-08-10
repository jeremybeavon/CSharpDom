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
            TestSealedClassAsync(typeof(SealedClassWithInternalProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNewPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNewProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNewStaticPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNewStaticProperty));
        }

        [TestMethod]
        public void TestSealedClassWithOverridePropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithOverrideProperty));
        }

        [TestMethod]
        public void TestSealedClassWithPrivatePropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestSealedClassWithProtectedPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithProtectedProperty));
        }

        [TestMethod]
        public void TestSealedClassWithProtectedInternalPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public void TestSealedClassWithPublicPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithPublicProperty));
        }

        [TestMethod]
        public void TestSealedClassWithSealedOverridePropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public void TestSealedClassWithStaticPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithStaticProperty));
        }
    }
}
