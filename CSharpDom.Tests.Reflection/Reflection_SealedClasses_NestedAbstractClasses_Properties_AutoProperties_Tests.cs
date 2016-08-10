using CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedAbstractClasses_Properties_AutoProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithInternalAutoPropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithNewAutoPropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNewAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithNewStaticAutoPropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithNewVirtualAutoPropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNewVirtualAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithOverrideAutoPropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithPrivateAutoPropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithProtectedAutoPropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithProtectedInternalAutoPropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithPublicAutoPropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithPublicAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithSealedOverrideAutoPropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithStaticAutoPropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithStaticAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithVirtualAutoPropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithVirtualAutoProperty));
        }
    }
}
