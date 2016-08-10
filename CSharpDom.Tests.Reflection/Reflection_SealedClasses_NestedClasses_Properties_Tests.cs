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
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithInternalProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewPropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewStaticPropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewStaticProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewVirtualPropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewVirtualProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithOverridePropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithOverrideProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPrivatePropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithProtectedPropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithProtectedProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithProtectedInternalPropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPublicPropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPublicProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithSealedOverridePropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithStaticPropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithStaticProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithVirtualPropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithVirtualProperty));
        }
    }
}
