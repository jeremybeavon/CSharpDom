using CSharpDom.TestTarget.Classes.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_Properties_AutoProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestClassWithInternalAutoPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNewAutoPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNewAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNewStaticAutoPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNewVirtualAutoPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNewVirtualAutoProperty));
        }

        [TestMethod]
        public void TestClassWithOverrideAutoPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public void TestClassWithPrivateAutoPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestClassWithProtectedAutoPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public void TestClassWithProtectedInternalAutoPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public void TestClassWithPublicAutoPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithPublicAutoProperty));
        }

        [TestMethod]
        public void TestClassWithSealedOverrideAutoPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public void TestClassWithStaticAutoPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithStaticAutoProperty));
        }

        [TestMethod]
        public void TestClassWithVirtualAutoPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithVirtualAutoProperty));
        }
    }
}
