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
            TestClass(typeof(ClassWithNestedAbstractClassWithInternalProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithNewProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewStaticPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithNewStaticProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewVirtualPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithNewVirtualProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithOverridePropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithOverrideProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithPrivatePropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithProtectedPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithProtectedProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithProtectedInternalPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithPublicPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithPublicProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithSealedOverridePropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithStaticPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithStaticProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithVirtualPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithVirtualProperty));
        }
    }
}
