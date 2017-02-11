using CSharpDom.TestTarget.SealedClasses.NestedClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedClasses_Properties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedClassWithInternalPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithInternalProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithNewProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewStaticPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithNewStaticProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewVirtualPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithNewVirtualProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithOverridePropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithOverrideProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPrivatePropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithProtectedPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithProtectedProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithProtectedInternalPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPublicPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithPublicProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithSealedOverridePropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithStaticPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithStaticProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithVirtualPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithVirtualProperty));
        }
    }
}
