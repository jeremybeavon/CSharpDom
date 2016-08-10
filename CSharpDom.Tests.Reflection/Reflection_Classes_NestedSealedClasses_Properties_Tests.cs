using CSharpDom.TestTarget.Classes.NestedSealedClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedSealedClasses_Properties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestClassWithNestedSealedClassWithInternalPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithInternalProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNewPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithNewProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNewStaticPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithNewStaticProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithOverridePropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithOverrideProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPrivatePropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithProtectedPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithProtectedInternalPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPublicPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithPublicProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithSealedOverridePropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithStaticPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithStaticProperty));
        }
    }
}
