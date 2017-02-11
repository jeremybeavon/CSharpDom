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
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithInternalProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithNewPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithNewProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithNewStaticPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithNewStaticProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithOverridePropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithOverrideProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithPrivatePropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithProtectedPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithProtectedProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithProtectedInternalPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithPublicPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithPublicProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithSealedOverridePropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithStaticPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithStaticProperty));
        }
    }
}
