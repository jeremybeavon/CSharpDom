using CSharpDom.TestTarget.Classes.NestedAbstractClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedAbstractClasses_Properties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestClassWithNestedAbstractClassWithInternalPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithInternalProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewStaticPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewStaticProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewVirtualPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewVirtualProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithOverridePropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithOverrideProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithPrivatePropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithProtectedPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithProtectedInternalPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithPublicPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithPublicProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithSealedOverridePropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithStaticPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithStaticProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithVirtualPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithVirtualProperty));
        }
    }
}
