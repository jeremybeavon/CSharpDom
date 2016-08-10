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
            TestClassAsync(typeof(ClassWithNestedClassWithInternalProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNewProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewStaticPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNewStaticProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewVirtualPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNewVirtualProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithOverridePropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithOverrideProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPrivatePropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithProtectedProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedInternalPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPublicPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithPublicProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithSealedOverridePropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithStaticPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithStaticProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithVirtualPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithVirtualProperty));
        }
    }
}
