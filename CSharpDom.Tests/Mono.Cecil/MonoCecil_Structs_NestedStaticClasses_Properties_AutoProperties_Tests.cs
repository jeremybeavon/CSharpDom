using CSharpDom.TestTarget.Structs.NestedStaticClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedStaticClasses_Properties_AutoProperties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithInternalAutoPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithPrivateAutoPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithPublicAutoPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithPublicAutoProperty));
        }
    }
}
