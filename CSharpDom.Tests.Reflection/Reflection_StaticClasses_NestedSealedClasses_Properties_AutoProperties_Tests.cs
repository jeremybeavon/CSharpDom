using CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_StaticClasses_NestedSealedClasses_Properties_AutoProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithInternalAutoPropertyUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithNewAutoPropertyUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNewAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithNewStaticAutoPropertyUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithOverrideAutoPropertyUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithPrivateAutoPropertyUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithProtectedAutoPropertyUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithProtectedInternalAutoPropertyUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithPublicAutoPropertyUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithPublicAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithSealedOverrideAutoPropertyUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithStaticAutoPropertyUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithStaticAutoProperty));
        }
    }
}
