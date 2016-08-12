using CSharpDom.TestTarget.Structs.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_Indexers_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStructWithPrivateIndexerUsingReflection()
        {
            TestStructAsync(typeof(StructWithPrivateIndexer));
        }

        [TestMethod]
        public void TestStructWithPublicIndexerUsingReflection()
        {
            TestStructAsync(typeof(StructWithPublicIndexer));
        }

        [TestMethod]
        public void TestStructWithInternalIndexerUsingReflection()
        {
            TestStructAsync(typeof(StructWithInternalIndexer));
        }
    }
}
