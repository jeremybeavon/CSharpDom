using CSharpDom.TestTarget.Structs.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_Methods_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestStructWithInternalMethodUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithInternalMethod));
        }

        [TestMethod]
        public async Task TestStructWithPrivateMethodUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithPrivateMethod));
        }

        [TestMethod]
        public async Task TestStructWithPublicMethodUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithPublicMethod));
        }

        [TestMethod]
        public async Task TestStructWithStaticMethodUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithStaticMethod));
        }
    }
}
