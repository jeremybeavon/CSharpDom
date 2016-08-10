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
            TestClassAsync(typeof(ClassWithNestedClassWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewAutoPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNewAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewStaticAutoPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewVirtualAutoPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNewVirtualAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithOverrideAutoPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPrivateAutoPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedAutoPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedInternalAutoPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPublicAutoPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithPublicAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithSealedOverrideAutoPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithStaticAutoPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithStaticAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithVirtualAutoPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithVirtualAutoProperty));
        }
    }
}
