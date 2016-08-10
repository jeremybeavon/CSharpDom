using CSharpDom.TestTarget.SealedClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_Properties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestSealedClassWithInternalPropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithInternalProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNewPropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNewProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNewStaticPropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNewStaticProperty));
        }

        [TestMethod]
        public void TestSealedClassWithOverridePropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithOverrideProperty));
        }

        [TestMethod]
        public void TestSealedClassWithPrivatePropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestSealedClassWithProtectedPropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithProtectedProperty));
        }

        [TestMethod]
        public void TestSealedClassWithProtectedInternalPropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public void TestSealedClassWithPublicPropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithPublicProperty));
        }

        [TestMethod]
        public void TestSealedClassWithSealedOverridePropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public void TestSealedClassWithStaticPropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithStaticProperty));
        }
    }
}
