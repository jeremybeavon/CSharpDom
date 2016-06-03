using CSharpDom.TestTarget.Structs.NestedStructs.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedStructs_Properties_AutoProperties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestStructWithNestedStructWithInternalAutoPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithPrivateAutoPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithPrivateAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithPublicAutoPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithPublicAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithStaticAutoPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithStaticAutoProperty));
        }
    }
}
