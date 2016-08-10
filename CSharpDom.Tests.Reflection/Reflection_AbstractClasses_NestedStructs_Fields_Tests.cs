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
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithConstField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithInternalFieldUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithInternalField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithPrivateFieldUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithPrivateField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithPublicFieldUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithPublicField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithReadOnlyFieldUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithReadOnlyField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithStaticFieldUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithStaticField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithStaticReadOnlyFieldUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithStaticVolatileFieldUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithStaticVolatileField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithVolatileFieldUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithVolatileField));
        }
    }
}
