using CSharpDom.TestTarget.Classes.NestedAbstractClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedAbstractClasses_Properties_AutoProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestClassWithNestedAbstractClassWithInternalAutoPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewAutoPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithNewAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewStaticAutoPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewVirtualAutoPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithNewVirtualAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithOverrideAutoPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithPrivateAutoPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithProtectedAutoPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithProtectedInternalAutoPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithPublicAutoPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithPublicAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithSealedOverrideAutoPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithStaticAutoPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithStaticAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithVirtualAutoPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithVirtualAutoProperty));
        }
    }
}
