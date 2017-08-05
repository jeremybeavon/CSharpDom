using CSharpDom.TestTarget.StaticClasses.NestedStaticClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_StaticClasses_NestedStaticClasses_Properties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithInternalPropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithInternalProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithPrivatePropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithPrivateProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithPublicPropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithPublicProperty));
        }
    }
}
