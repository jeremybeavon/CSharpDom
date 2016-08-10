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
            TestClassAsync(typeof(ClassWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNewAutoPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNewAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNewStaticAutoPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNewVirtualAutoPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNewVirtualAutoProperty));
        }

        [TestMethod]
        public void TestClassWithOverrideAutoPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public void TestClassWithPrivateAutoPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestClassWithProtectedAutoPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public void TestClassWithProtectedInternalAutoPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public void TestClassWithPublicAutoPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithPublicAutoProperty));
        }

        [TestMethod]
        public void TestClassWithSealedOverrideAutoPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public void TestClassWithStaticAutoPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithStaticAutoProperty));
        }

        [TestMethod]
        public void TestClassWithVirtualAutoPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithVirtualAutoProperty));
        }
    }
}
