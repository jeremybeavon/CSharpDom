using CSharpDom.TestTarget.Structs.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_Properties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStructWithInternalPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithInternalProperty));
        }

        [TestMethod]
        public async Task TestStructWithPrivatePropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithPrivateProperty));
        }

        [TestMethod]
        public async Task TestStructWithPublicPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithPublicProperty));
        }

        [TestMethod]
        public async Task TestStructWithStaticPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithStaticProperty));
        }
    }
}
