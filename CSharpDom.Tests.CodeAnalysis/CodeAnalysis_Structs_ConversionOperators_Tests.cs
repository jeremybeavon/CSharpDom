using CSharpDom.TestTarget.Structs.ConversionOperators;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_ConversionOperators_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStructWithExplicitConversionOperatorUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithExplicitConversionOperator));
        }

        [TestMethod]
        public async Task TestStructWithImplicitConversionOperatorUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithImplicitConversionOperator));
        }
    }
}
