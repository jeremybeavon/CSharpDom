using CSharpDom.TestTarget.Structs.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_Indexers_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStructWithInternalIndexerUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithInternalIndexer));
        }

        [TestMethod]
        public void TestStructWithPrivateIndexerUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithPrivateIndexer));
        }

        [TestMethod]
        public void TestStructWithPublicIndexerUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithPublicIndexer));
        }
    }
}
