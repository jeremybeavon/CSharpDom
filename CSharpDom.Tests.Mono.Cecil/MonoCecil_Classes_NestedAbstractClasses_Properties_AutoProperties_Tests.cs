using CSharpDom.TestTarget.Classes.NestedAbstractClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedAbstractClasses_Properties_AutoProperties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestClassWithNestedAbstractClassWithInternalAutoPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewAutoPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewStaticAutoPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewVirtualAutoPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewVirtualAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithOverrideAutoPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithPrivateAutoPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithProtectedAutoPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithProtectedInternalAutoPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithPublicAutoPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithPublicAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithSealedOverrideAutoPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithStaticAutoPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithStaticAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithVirtualAutoPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithVirtualAutoProperty));
        }
    }
}
