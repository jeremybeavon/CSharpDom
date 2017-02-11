using CSharpDom.TestTarget.Structs.NestedStructs.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedStructs_Properties_AutoProperties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStructWithNestedStructWithInternalAutoPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStructWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPrivateAutoPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStructWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPublicAutoPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStructWithPublicAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithStaticAutoPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStructWithStaticAutoProperty));
        }
    }
}
