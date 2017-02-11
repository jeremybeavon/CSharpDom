using CSharpDom.TestTarget.AbstractClasses.NestedStructs.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_NestedStructs_Fields_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedStructWithConstFieldUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithConstField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithInternalFieldUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithInternalField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithPrivateFieldUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithPrivateField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithPublicFieldUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithPublicField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithReadOnlyFieldUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithReadOnlyField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithStaticFieldUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithStaticField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithStaticReadOnlyFieldUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithStaticVolatileFieldUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithStaticVolatileField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithVolatileFieldUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithVolatileField));
        }
    }
}
