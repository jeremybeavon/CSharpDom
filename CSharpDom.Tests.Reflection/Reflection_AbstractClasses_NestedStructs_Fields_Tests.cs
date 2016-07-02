using CSharpDom.TestTarget.AbstractClasses.NestedStructs.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_NestedStructs_Fields_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithConstFieldUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithConstField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithInternalFieldUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithInternalField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithPrivateFieldUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithPrivateField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithPublicFieldUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithPublicField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithReadOnlyFieldUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithStaticFieldUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithStaticField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithStaticReadOnlyFieldUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithStaticVolatileFieldUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithStaticVolatileField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithVolatileFieldUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithVolatileField));
        }
    }
}
