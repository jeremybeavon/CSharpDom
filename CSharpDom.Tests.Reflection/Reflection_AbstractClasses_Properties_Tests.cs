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
            TestAbstractClassAsync(typeof(AbstractClassWithInternalProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNewPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNewProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNewStaticPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNewStaticProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNewVirtualPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNewVirtualProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithOverridePropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithOverrideProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithPrivatePropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithProtectedProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedInternalPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithPublicPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithPublicProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithSealedOverridePropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithStaticPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithStaticProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithVirtualPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithVirtualProperty));
        }
    }
}
