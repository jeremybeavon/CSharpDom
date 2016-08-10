using CSharpDom.TestTarget.Structs.NestedStructs.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedStructs_Properties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStructWithNestedStructWithInternalPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithInternalProperty));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPrivatePropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithPrivateProperty));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPublicPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithPublicProperty));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithStaticPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithStaticProperty));
        }
    }
}
