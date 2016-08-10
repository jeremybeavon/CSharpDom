using CSharpDom.TestTarget.Classes.NestedSealedClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedSealedClasses_Properties_AutoProperties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestClassWithNestedSealedClassWithInternalAutoPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNewAutoPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithNewAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNewStaticAutoPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithOverrideAutoPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPrivateAutoPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithProtectedAutoPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithProtectedInternalAutoPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPublicAutoPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithPublicAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithSealedOverrideAutoPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithStaticAutoPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithStaticAutoProperty));
        }
    }
}
