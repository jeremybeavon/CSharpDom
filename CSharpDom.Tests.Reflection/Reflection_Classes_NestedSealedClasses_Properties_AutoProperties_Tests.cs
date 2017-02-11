using CSharpDom.TestTarget.Classes.NestedSealedClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedSealedClasses_Properties_AutoProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestClassWithNestedSealedClassWithInternalAutoPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNewAutoPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithNewAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNewStaticAutoPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithOverrideAutoPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPrivateAutoPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithProtectedAutoPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithProtectedInternalAutoPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPublicAutoPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithPublicAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithSealedOverrideAutoPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithStaticAutoPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithStaticAutoProperty));
        }
    }
}
