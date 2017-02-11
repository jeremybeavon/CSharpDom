using CSharpDom.TestTarget.Classes.NestedClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedClasses_Properties_AutoProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestClassWithNestedClassWithInternalAutoPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewAutoPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithNewAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewStaticAutoPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewVirtualAutoPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithNewVirtualAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithOverrideAutoPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPrivateAutoPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedAutoPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedInternalAutoPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPublicAutoPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithPublicAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithSealedOverrideAutoPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithStaticAutoPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithStaticAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithVirtualAutoPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithVirtualAutoProperty));
        }
    }
}
