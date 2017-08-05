using CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_AbstractClasses_NestedStaticClasses_Properties_AutoProperties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithInternalAutoPropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithPrivateAutoPropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithPublicAutoPropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithPublicAutoProperty));
        }
    }
}
