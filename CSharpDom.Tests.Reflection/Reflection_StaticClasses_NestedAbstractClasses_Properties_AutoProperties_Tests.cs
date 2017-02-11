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
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithNewAutoPropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithNewAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithNewStaticAutoPropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithNewVirtualAutoPropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithNewVirtualAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithOverrideAutoPropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithPrivateAutoPropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithProtectedAutoPropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithProtectedInternalAutoPropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithPublicAutoPropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithPublicAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithSealedOverrideAutoPropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithStaticAutoPropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithStaticAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithVirtualAutoPropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithVirtualAutoProperty));
        }
    }
}
