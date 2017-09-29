using CSharpDom.TestTarget.Structs.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_Methods_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStructWithInternalMethodUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithInternalMethod));
        }

        [TestMethod]
        public void TestStructWithPrivateMethodUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithPrivateMethod));
        }

        [TestMethod]
        public void TestStructWithPublicMethodUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithPublicMethod));
        }

        [TestMethod]
        public void TestStructWithStaticMethodUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithStaticMethod));
        }
    }
}
