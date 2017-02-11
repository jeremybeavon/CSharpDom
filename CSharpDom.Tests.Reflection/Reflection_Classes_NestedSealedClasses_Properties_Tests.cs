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
            TestClass(typeof(ClassWithNestedSealedClassWithInternalProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNewPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithNewProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNewStaticPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithNewStaticProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithOverridePropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithOverrideProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPrivatePropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithProtectedPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithProtectedProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithProtectedInternalPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPublicPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithPublicProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithSealedOverridePropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithStaticPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithStaticProperty));
        }
    }
}
