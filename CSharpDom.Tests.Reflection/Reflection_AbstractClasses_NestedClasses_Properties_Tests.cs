using CSharpDom.TestTarget.AbstractClasses.NestedClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_NestedClasses_Properties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedClassWithInternalPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithInternalProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewStaticPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewStaticProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewVirtualPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewVirtualProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithOverridePropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithOverrideProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithPrivatePropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithProtectedPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithProtectedProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithProtectedInternalPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithPublicPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithPublicProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithSealedOverridePropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithStaticPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithStaticProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithVirtualPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithVirtualProperty));
        }
    }
}
