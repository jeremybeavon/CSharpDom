using CSharpDom.TestTarget.Structs.NestedStructs.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedStructs_Properties_AutoProperties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStructWithNestedStructWithInternalAutoPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithPrivateAutoPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithPrivateAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithPublicAutoPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithPublicAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithStaticAutoPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithStaticAutoProperty));
        }
    }
}
