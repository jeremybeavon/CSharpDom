using CSharpDom.TestTarget.SealedClasses.NestedClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_SealedClasses_NestedClasses_Properties_AutoProperties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedClassWithInternalAutoPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewAutoPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewStaticAutoPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewVirtualAutoPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewVirtualAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithOverrideAutoPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPrivateAutoPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithProtectedAutoPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithProtectedInternalAutoPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPublicAutoPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPublicAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithSealedOverrideAutoPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithStaticAutoPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithStaticAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithVirtualAutoPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithVirtualAutoProperty));
        }
    }
}
