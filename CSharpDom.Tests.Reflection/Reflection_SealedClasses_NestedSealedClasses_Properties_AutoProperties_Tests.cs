using CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedSealedClasses_Properties_AutoProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithInternalAutoPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithNewAutoPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithNewAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithNewStaticAutoPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithOverrideAutoPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithPrivateAutoPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithProtectedAutoPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithProtectedInternalAutoPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithPublicAutoPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithPublicAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithSealedOverrideAutoPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithStaticAutoPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithStaticAutoProperty));
        }
    }
}
