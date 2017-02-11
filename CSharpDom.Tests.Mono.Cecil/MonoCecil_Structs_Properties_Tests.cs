using CSharpDom.TestTarget.Structs.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_Properties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStructWithInternalPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithInternalProperty));
        }

        [TestMethod]
        public void TestStructWithPrivatePropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithPrivateProperty));
        }

        [TestMethod]
        public void TestStructWithPublicPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithPublicProperty));
        }

        [TestMethod]
        public void TestStructWithStaticPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithStaticProperty));
        }
    }
}
