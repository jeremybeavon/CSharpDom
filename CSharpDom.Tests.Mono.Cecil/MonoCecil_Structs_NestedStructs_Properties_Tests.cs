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
            TestStruct(typeof(StructWithNestedStructWithInternalProperty));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPrivatePropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStructWithPrivateProperty));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPublicPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStructWithPublicProperty));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithStaticPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStructWithStaticProperty));
        }
    }
}
