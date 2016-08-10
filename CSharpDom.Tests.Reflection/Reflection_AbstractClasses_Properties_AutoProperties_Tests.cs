using CSharpDom.TestTarget.AbstractClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_Properties_AutoProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestAbstractClassWithInternalAutoPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNewAutoPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNewAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNewStaticAutoPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNewVirtualAutoPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNewVirtualAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithOverrideAutoPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithPrivateAutoPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedAutoPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedInternalAutoPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithPublicAutoPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithPublicAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithSealedOverrideAutoPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithStaticAutoPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithStaticAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithVirtualAutoPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithVirtualAutoProperty));
        }
    }
}
