using CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_SealedClasses_NestedSealedClasses_Properties_AutoProperties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithInternalAutoPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithNewAutoPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNewAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithNewStaticAutoPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithOverrideAutoPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithPrivateAutoPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithProtectedAutoPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithProtectedInternalAutoPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithPublicAutoPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithPublicAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithSealedOverrideAutoPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithStaticAutoPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithStaticAutoProperty));
        }
    }
}
