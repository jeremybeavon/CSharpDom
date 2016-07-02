using CSharpDom.TestTarget.Structs.NestedStructs.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedStructs_Properties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestStructWithNestedStructWithInternalPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithInternalProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithPrivatePropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithPrivateProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithPublicPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithPublicProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithStaticPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithStaticProperty));
        }
    }
}
