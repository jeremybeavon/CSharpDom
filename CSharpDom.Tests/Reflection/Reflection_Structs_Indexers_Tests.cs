using CSharpDom.TestTarget.Structs.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_Indexers_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStructWithInternalIndexerUsingReflection()
        {
            await TestStructAsync(typeof(StructWithInternalIndexer));
        }
    }
}