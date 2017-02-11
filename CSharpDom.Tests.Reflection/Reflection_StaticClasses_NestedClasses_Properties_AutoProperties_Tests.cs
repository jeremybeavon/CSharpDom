using CSharpDom.TestTarget.StaticClasses.NestedClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_StaticClasses_NestedClasses_Properties_AutoProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedClassWithInternalAutoPropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewAutoPropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithNewAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewStaticAutoPropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewVirtualAutoPropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithNewVirtualAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithOverrideAutoPropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPrivateAutoPropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedAutoPropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedInternalAutoPropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPublicAutoPropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithPublicAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithSealedOverrideAutoPropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithStaticAutoPropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithStaticAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithVirtualAutoPropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithVirtualAutoProperty));
        }
    }
}
