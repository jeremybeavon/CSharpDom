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
            TestClassAsync(typeof(ClassWithInternalProperty));
        }

        [TestMethod]
        public void TestClassWithNewPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNewProperty));
        }

        [TestMethod]
        public void TestClassWithNewStaticPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNewStaticProperty));
        }

        [TestMethod]
        public void TestClassWithNewVirtualPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNewVirtualProperty));
        }

        [TestMethod]
        public void TestClassWithOverridePropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithOverrideProperty));
        }

        [TestMethod]
        public void TestClassWithPrivatePropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestClassWithProtectedPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithProtectedProperty));
        }

        [TestMethod]
        public void TestClassWithProtectedInternalPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public void TestClassWithPublicPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithPublicProperty));
        }

        [TestMethod]
        public void TestClassWithSealedOverridePropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public void TestClassWithStaticPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithStaticProperty));
        }

        [TestMethod]
        public void TestClassWithVirtualPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithVirtualProperty));
        }
    }
}
