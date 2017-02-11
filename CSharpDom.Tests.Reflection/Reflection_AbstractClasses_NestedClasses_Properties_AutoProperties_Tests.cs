using CSharpDom.TestTarget.AbstractClasses.NestedClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_NestedClasses_Properties_AutoProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedClassWithInternalAutoPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewAutoPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithNewAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewStaticAutoPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewVirtualAutoPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithNewVirtualAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithOverrideAutoPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithPrivateAutoPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithProtectedAutoPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithProtectedInternalAutoPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithPublicAutoPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithPublicAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithSealedOverrideAutoPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithStaticAutoPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithStaticAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithVirtualAutoPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithVirtualAutoProperty));
        }
    }
}
