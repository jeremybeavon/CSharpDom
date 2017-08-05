using CSharpDom.TestTarget.Structs.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_Indexers_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStructWithInternalIndexerUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithInternalIndexer));
        }

        [TestMethod]
        public async Task TestStructWithPrivateIndexerUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithPrivateIndexer));
        }

        [TestMethod]
        public async Task TestStructWithPublicIndexerUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithPublicIndexer));
        }
    }
}
