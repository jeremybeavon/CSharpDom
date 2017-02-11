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
            TestSealedClass(typeof(SealedClassWithNestedClassWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewAutoPropertyUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithNewAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewStaticAutoPropertyUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewVirtualAutoPropertyUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithNewVirtualAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithOverrideAutoPropertyUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPrivateAutoPropertyUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithProtectedAutoPropertyUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithProtectedInternalAutoPropertyUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPublicAutoPropertyUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithPublicAutoProperty));
        }

        //[TestMethod]
        //public void TestSealedClassWithNestedClassWithSealedOverrideAutoPropertyUsingMonoCecil()
        //{
        //    TestSealedClassAsync(typeof(SealedClassWithNestedClassWithSealedOverrideAutoProperty));
        //}

        [TestMethod]
        public void TestSealedClassWithNestedClassWithStaticAutoPropertyUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithStaticAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithVirtualAutoPropertyUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithVirtualAutoProperty));
        }
    }
}
