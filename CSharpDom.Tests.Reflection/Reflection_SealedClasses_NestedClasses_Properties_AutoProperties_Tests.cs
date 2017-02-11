using CSharpDom.TestTarget.SealedClasses.NestedClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedClasses_Properties_AutoProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedClassWithInternalAutoPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewAutoPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithNewAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewStaticAutoPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewVirtualAutoPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithNewVirtualAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithOverrideAutoPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPrivateAutoPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithProtectedAutoPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithProtectedInternalAutoPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPublicAutoPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithPublicAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithSealedOverrideAutoPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithStaticAutoPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithStaticAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithVirtualAutoPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithVirtualAutoProperty));
        }
    }
}
