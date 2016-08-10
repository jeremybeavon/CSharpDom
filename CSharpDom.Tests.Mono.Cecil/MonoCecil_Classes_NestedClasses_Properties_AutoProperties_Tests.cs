using CSharpDom.TestTarget.Classes.NestedClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedClasses_Properties_AutoProperties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestClassWithNestedClassWithInternalAutoPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewAutoPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNewAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewStaticAutoPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewVirtualAutoPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNewVirtualAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithOverrideAutoPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPrivateAutoPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedAutoPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedInternalAutoPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPublicAutoPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithPublicAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithSealedOverrideAutoPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithStaticAutoPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithStaticAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithVirtualAutoPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithVirtualAutoProperty));
        }
    }
}
