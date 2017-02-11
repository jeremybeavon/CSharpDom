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
            TestSealedClass(typeof(SealedClassWithInternalProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNewPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNewProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNewStaticPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNewStaticProperty));
        }

        [TestMethod]
        public void TestSealedClassWithOverridePropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithOverrideProperty));
        }

        [TestMethod]
        public void TestSealedClassWithPrivatePropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestSealedClassWithProtectedPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithProtectedProperty));
        }

        [TestMethod]
        public void TestSealedClassWithProtectedInternalPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public void TestSealedClassWithPublicPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithPublicProperty));
        }

        [TestMethod]
        public void TestSealedClassWithSealedOverridePropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public void TestSealedClassWithStaticPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithStaticProperty));
        }
    }
}
