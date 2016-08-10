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
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewAutoPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewStaticAutoPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewVirtualAutoPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewVirtualAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithOverrideAutoPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithPrivateAutoPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithProtectedAutoPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithProtectedInternalAutoPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithPublicAutoPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithPublicAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithSealedOverrideAutoPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithStaticAutoPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithStaticAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithVirtualAutoPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithVirtualAutoProperty));
        }
    }
}
