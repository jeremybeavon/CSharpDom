using CSharpDom.TestTarget.Structs.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_Indexers_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStructWithPrivateIndexerUsingMonoCecil()
        {
            TestStruct(typeof(StructWithPrivateIndexer));
        }

        [TestMethod]
        public void TestStructWithPublicIndexerUsingMonoCecil()
        {
            TestStruct(typeof(StructWithPublicIndexer));
        }

        [TestMethod]
        public void TestStructWithInternalIndexerUsingMonoCecil()
        {
            TestStruct(typeof(StructWithInternalIndexer));
        }
    }
}
