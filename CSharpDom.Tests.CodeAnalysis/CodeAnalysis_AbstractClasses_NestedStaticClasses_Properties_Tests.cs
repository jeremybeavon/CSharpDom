using CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_AbstractClasses_NestedStaticClasses_Properties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithInternalPropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithInternalProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithPrivatePropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithPrivateProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithPublicPropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithPublicProperty));
        }
    }
}
