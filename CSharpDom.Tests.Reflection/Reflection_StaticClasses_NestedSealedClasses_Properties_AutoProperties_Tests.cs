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
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithNewAutoPropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithNewAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithNewStaticAutoPropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithOverrideAutoPropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithPrivateAutoPropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithProtectedAutoPropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithProtectedInternalAutoPropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithPublicAutoPropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithPublicAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithSealedOverrideAutoPropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithStaticAutoPropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithStaticAutoProperty));
        }
    }
}
