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
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithInternalProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithNewPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithNewProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithNewStaticPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithNewStaticProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithOverridePropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithOverrideProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithPrivatePropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithProtectedPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithProtectedProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithProtectedInternalPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithPublicPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithPublicProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithSealedOverridePropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithStaticPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithStaticProperty));
        }
    }
}
