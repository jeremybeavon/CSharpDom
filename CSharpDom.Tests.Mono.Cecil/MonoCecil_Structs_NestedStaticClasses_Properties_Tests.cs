using CSharpDom.TestTarget.Structs.NestedStaticClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedStaticClasses_Properties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStructWithNestedStaticClassWithInternalPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStaticClassWithInternalProperty));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithPrivatePropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStaticClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithPublicPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStaticClassWithPublicProperty));
        }
    }
}
