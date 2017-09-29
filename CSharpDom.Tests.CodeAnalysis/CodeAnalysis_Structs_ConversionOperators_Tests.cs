using CSharpDom.TestTarget.Structs.ConversionOperators;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_ConversionOperators_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStructWithExplicitConversionOperatorUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithExplicitConversionOperator));
        }

        [TestMethod]
        public void TestStructWithImplicitConversionOperatorUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithImplicitConversionOperator));
        }
    }
}
