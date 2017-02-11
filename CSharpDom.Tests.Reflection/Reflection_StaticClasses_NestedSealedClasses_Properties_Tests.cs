using CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_StaticClasses_NestedSealedClasses_Properties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithInternalPropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithInternalProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithNewPropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithNewProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithNewStaticPropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithNewStaticProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithOverridePropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithOverrideProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithPrivatePropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithProtectedPropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithProtectedProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithProtectedInternalPropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithPublicPropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithPublicProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithSealedOverridePropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithStaticPropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithStaticProperty));
        }
    }
}
