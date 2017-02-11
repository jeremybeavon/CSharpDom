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
            TestAbstractClass(typeof(AbstractClassWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNewAutoPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNewAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNewStaticAutoPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNewVirtualAutoPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNewVirtualAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithOverrideAutoPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithPrivateAutoPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedAutoPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedInternalAutoPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithPublicAutoPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithPublicAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithSealedOverrideAutoPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithStaticAutoPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithStaticAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithVirtualAutoPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithVirtualAutoProperty));
        }
    }
}
