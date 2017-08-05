using CSharpDom.TestTarget.Structs.NestedStaticClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedStaticClasses_Properties_AutoProperties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithInternalAutoPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithPrivateAutoPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithPublicAutoPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithPublicAutoProperty));
        }
    }
}
