using CSharpDom.TestTarget.Classes.NestedClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedClasses_Properties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestClassWithNestedClassWithInternalPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithInternalProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithNewProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewStaticPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithNewStaticProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewVirtualPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithNewVirtualProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithOverridePropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithOverrideProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPrivatePropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithProtectedProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedInternalPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPublicPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithPublicProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithSealedOverridePropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithStaticPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithStaticProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithVirtualPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithVirtualProperty));
        }
    }
}
