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
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithInternalProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewPropertyUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewStaticPropertyUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewStaticProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewVirtualPropertyUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewVirtualProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithOverridePropertyUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithOverrideProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPrivatePropertyUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedPropertyUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedInternalPropertyUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPublicPropertyUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPublicProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithSealedOverridePropertyUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithStaticPropertyUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithStaticProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithVirtualPropertyUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithVirtualProperty));
        }
    }
}
