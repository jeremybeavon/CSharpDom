using CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_NestedStaticClasses_Fields_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithConstFieldUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStaticClassWithConstField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithInternalFieldUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStaticClassWithInternalField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithPrivateFieldUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStaticClassWithPrivateField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithPublicFieldUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStaticClassWithPublicField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithReadOnlyFieldUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStaticClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithVolatileFieldUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStaticClassWithVolatileField));
        }
    }
}
