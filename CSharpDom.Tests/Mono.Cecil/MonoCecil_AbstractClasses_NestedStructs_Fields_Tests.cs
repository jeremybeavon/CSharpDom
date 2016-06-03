using CSharpDom.TestTarget.AbstractClasses.NestedStructs.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_NestedStructs_Fields_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithConstFieldUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithConstField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithInternalFieldUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithInternalField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithPrivateFieldUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithPrivateField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithPublicFieldUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithPublicField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithReadOnlyFieldUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithStaticFieldUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithStaticField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithStaticReadOnlyFieldUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithStaticVolatileFieldUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithStaticVolatileField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithVolatileFieldUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithVolatileField));
        }
    }
}
