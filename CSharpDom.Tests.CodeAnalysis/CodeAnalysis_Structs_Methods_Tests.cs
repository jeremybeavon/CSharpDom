using CSharpDom.TestTarget.Structs.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_Methods_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStructWithInternalMethodUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithInternalMethod));
        }

        [TestMethod]
        public async Task TestStructWithPrivateMethodUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithPrivateMethod));
        }

        [TestMethod]
        public async Task TestStructWithPublicMethodUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithPublicMethod));
        }

        [TestMethod]
        public async Task TestStructWithStaticMethodUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithStaticMethod));
        }
    }
}
