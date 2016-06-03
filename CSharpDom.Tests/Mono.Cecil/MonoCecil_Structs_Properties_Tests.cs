using CSharpDom.TestTarget.Structs.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_Properties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestStructWithInternalPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithInternalProperty));
        }

        [TestMethod]
        public async Task TestStructWithPrivatePropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithPrivateProperty));
        }

        [TestMethod]
        public async Task TestStructWithPublicPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithPublicProperty));
        }

        [TestMethod]
        public async Task TestStructWithStaticPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithStaticProperty));
        }
    }
}
