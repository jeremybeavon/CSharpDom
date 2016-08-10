using CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_NestedSealedClasses_Properties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithInternalPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithInternalProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithNewPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNewProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithNewStaticPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNewStaticProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithOverridePropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithOverrideProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithPrivatePropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithProtectedPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithProtectedProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithProtectedInternalPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithPublicPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithPublicProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithSealedOverridePropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithStaticPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithStaticProperty));
        }
    }
}
