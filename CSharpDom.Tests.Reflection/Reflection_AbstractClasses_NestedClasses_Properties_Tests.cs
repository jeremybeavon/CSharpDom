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
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithInternalProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithNewProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewStaticPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithNewStaticProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewVirtualPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithNewVirtualProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithOverridePropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithOverrideProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithPrivatePropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithProtectedPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithProtectedProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithProtectedInternalPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithPublicPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithPublicProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithSealedOverridePropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithStaticPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithStaticProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithVirtualPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithVirtualProperty));
        }
    }
}
