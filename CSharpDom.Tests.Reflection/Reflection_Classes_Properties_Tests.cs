using CSharpDom.TestTarget.Classes.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_Properties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestClassWithInternalPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithInternalProperty));
        }

        [TestMethod]
        public void TestClassWithNewPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNewProperty));
        }

        [TestMethod]
        public void TestClassWithNewStaticPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNewStaticProperty));
        }

        [TestMethod]
        public void TestClassWithNewVirtualPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNewVirtualProperty));
        }

        [TestMethod]
        public void TestClassWithOverridePropertyUsingReflection()
        {
            TestClass(typeof(ClassWithOverrideProperty));
        }

        [TestMethod]
        public void TestClassWithPrivatePropertyUsingReflection()
        {
            TestClass(typeof(ClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestClassWithProtectedPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithProtectedProperty));
        }

        [TestMethod]
        public void TestClassWithProtectedInternalPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public void TestClassWithPublicPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithPublicProperty));
        }

        [TestMethod]
        public void TestClassWithSealedOverridePropertyUsingReflection()
        {
            TestClass(typeof(ClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public void TestClassWithStaticPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithStaticProperty));
        }

        [TestMethod]
        public void TestClassWithVirtualPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithVirtualProperty));
        }
    }
}
