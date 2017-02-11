using CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_StaticClasses_NestedAbstractClasses_Properties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithInternalPropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithInternalProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithNewPropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithNewProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithNewStaticPropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithNewStaticProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithNewVirtualPropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithNewVirtualProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithOverridePropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithOverrideProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithPrivatePropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithProtectedPropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithProtectedProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithProtectedInternalPropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithPublicPropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithPublicProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithSealedOverridePropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithStaticPropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithStaticProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithVirtualPropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithVirtualProperty));
        }
    }
}
