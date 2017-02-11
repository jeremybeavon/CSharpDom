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
            TestStruct(typeof(StructWithPrivateIndexer));
        }

        [TestMethod]
        public void TestStructWithPublicIndexerUsingReflection()
        {
            TestStruct(typeof(StructWithPublicIndexer));
        }

        [TestMethod]
        public void TestStructWithInternalIndexerUsingReflection()
        {
            TestStruct(typeof(StructWithInternalIndexer));
        }
    }
}
