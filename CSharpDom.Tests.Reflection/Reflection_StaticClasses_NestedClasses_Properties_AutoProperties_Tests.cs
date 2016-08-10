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
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewAutoPropertyUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewStaticAutoPropertyUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewVirtualAutoPropertyUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewVirtualAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithOverrideAutoPropertyUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPrivateAutoPropertyUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedAutoPropertyUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedInternalAutoPropertyUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPublicAutoPropertyUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPublicAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithSealedOverrideAutoPropertyUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithStaticAutoPropertyUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithStaticAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithVirtualAutoPropertyUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithVirtualAutoProperty));
        }
    }
}
