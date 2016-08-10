using CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_StaticClasses_NestedAbstractClasses_Properties_AutoProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithInternalAutoPropertyUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithNewAutoPropertyUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNewAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithNewStaticAutoPropertyUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithNewVirtualAutoPropertyUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNewVirtualAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithOverrideAutoPropertyUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithPrivateAutoPropertyUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithProtectedAutoPropertyUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithProtectedInternalAutoPropertyUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithPublicAutoPropertyUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithPublicAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithSealedOverrideAutoPropertyUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithStaticAutoPropertyUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithStaticAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithVirtualAutoPropertyUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithVirtualAutoProperty));
        }
    }
}
