using CSharpDom.TestTarget.Structs.NestedStaticClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedStaticClasses_Fields_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithConstFieldUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithConstField));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithInternalFieldUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithInternalField));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithPrivateFieldUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithPrivateField));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithPublicFieldUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithPublicField));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithReadOnlyFieldUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithVolatileFieldUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithVolatileField));
        }
    }
}
