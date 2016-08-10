using CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedSealedClasses_Properties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithInternalPropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithInternalProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithNewPropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNewProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithNewStaticPropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNewStaticProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithOverridePropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithOverrideProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithPrivatePropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithProtectedPropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithProtectedProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithProtectedInternalPropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithPublicPropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithPublicProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithSealedOverridePropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithStaticPropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithStaticProperty));
        }
    }
}
