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
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewAutoPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewStaticAutoPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewVirtualAutoPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewVirtualAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithOverrideAutoPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithPrivateAutoPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithProtectedAutoPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithProtectedInternalAutoPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithPublicAutoPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithPublicAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithSealedOverrideAutoPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithStaticAutoPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithStaticAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithVirtualAutoPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithVirtualAutoProperty));
        }
    }
}
