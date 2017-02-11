using CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_NestedAbstractClasses_Properties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithInternalPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedAbstractClassWithInternalProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithNewPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedAbstractClassWithNewProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithNewStaticPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedAbstractClassWithNewStaticProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithNewVirtualPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedAbstractClassWithNewVirtualProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithOverridePropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedAbstractClassWithOverrideProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithPrivatePropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedAbstractClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithProtectedPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedAbstractClassWithProtectedProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithProtectedInternalPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedAbstractClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithPublicPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedAbstractClassWithPublicProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithSealedOverridePropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedAbstractClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithStaticPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedAbstractClassWithStaticProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithVirtualPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedAbstractClassWithVirtualProperty));
        }
    }
}
