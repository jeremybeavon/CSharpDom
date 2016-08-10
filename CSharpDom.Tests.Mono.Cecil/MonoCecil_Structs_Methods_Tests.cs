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
            TestStructAsync(typeof(StructWithInternalMethod));
        }

        [TestMethod]
        public void TestStructWithPrivateMethodUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithPrivateMethod));
        }

        [TestMethod]
        public void TestStructWithPublicMethodUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithPublicMethod));
        }

        [TestMethod]
        public void TestStructWithStaticMethodUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithStaticMethod));
        }
    }
}
