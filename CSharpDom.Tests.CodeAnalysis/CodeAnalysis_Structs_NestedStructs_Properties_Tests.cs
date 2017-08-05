using CSharpDom.TestTarget.Structs.NestedStructs.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedStructs_Properties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStructWithNestedStructWithInternalPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithInternalProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithPrivatePropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithPrivateProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithPublicPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithPublicProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithStaticPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithStaticProperty));
        }
    }
}
