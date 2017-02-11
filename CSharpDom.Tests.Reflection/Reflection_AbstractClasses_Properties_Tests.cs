using CSharpDom.TestTarget.AbstractClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_Properties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestAbstractClassWithInternalPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithInternalProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNewPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNewProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNewStaticPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNewStaticProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNewVirtualPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNewVirtualProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithOverridePropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithOverrideProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithPrivatePropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithProtectedProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedInternalPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithPublicPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithPublicProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithSealedOverridePropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithStaticPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithStaticProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithVirtualPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithVirtualProperty));
        }
    }
}
