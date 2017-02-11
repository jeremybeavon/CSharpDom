using CSharpDom.TestTarget.Structs.NestedStaticClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedStaticClasses_Properties_AutoProperties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStructWithNestedStaticClassWithInternalAutoPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStaticClassWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithPrivateAutoPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStaticClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithPublicAutoPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStaticClassWithPublicAutoProperty));
        }
    }
}
