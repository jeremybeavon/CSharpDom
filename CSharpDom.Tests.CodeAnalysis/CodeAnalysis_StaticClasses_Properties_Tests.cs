using CSharpDom.TestTarget.StaticClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_StaticClasses_Properties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStaticClassWithInternalPropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithInternalProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithPrivatePropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithPrivateProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithPublicPropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithPublicProperty));
        }
    }
}
