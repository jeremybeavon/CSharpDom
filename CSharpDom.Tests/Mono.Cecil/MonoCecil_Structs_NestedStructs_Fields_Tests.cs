using CSharpDom.TestTarget.Structs.NestedStructs.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedStructs_Fields_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestStructWithNestedStructWithConstFieldUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithConstField));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithInternalFieldUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithInternalField));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithPrivateFieldUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithPrivateField));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithPublicFieldUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithPublicField));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithReadOnlyFieldUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithStaticFieldUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithStaticField));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithStaticReadOnlyFieldUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithStaticVolatileFieldUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithStaticVolatileField));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithVolatileFieldUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithVolatileField));
        }
    }
}
