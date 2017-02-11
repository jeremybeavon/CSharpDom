using CSharpDom.TestTarget.Structs.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_Methods_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStructWithInternalMethodUsingMonoCecil()
        {
            TestStruct(typeof(StructWithInternalMethod));
        }

        [TestMethod]
        public void TestStructWithPrivateMethodUsingMonoCecil()
        {
            TestStruct(typeof(StructWithPrivateMethod));
        }

        [TestMethod]
        public void TestStructWithPublicMethodUsingMonoCecil()
        {
            TestStruct(typeof(StructWithPublicMethod));
        }

        [TestMethod]
        public void TestStructWithStaticMethodUsingMonoCecil()
        {
            TestStruct(typeof(StructWithStaticMethod));
        }
    }
}
