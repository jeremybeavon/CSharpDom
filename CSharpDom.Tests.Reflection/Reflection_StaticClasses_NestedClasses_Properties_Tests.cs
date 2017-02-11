using CSharpDom.TestTarget.StaticClasses.NestedClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_StaticClasses_NestedClasses_Properties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedClassWithInternalPropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithInternalProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewPropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithNewProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewStaticPropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithNewStaticProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewVirtualPropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithNewVirtualProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithOverridePropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithOverrideProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPrivatePropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedPropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithProtectedProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedInternalPropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPublicPropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithPublicProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithSealedOverridePropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithStaticPropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithStaticProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithVirtualPropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithVirtualProperty));
        }
    }
}
