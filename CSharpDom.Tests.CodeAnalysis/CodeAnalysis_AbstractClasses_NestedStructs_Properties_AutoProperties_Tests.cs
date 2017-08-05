using CSharpDom.TestTarget.AbstractClasses.NestedStructs.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_AbstractClasses_NestedStructs_Properties_AutoProperties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithInternalAutoPropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithPrivateAutoPropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithPrivateAutoProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithPublicAutoPropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithPublicAutoProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithStaticAutoPropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithStaticAutoProperty));
        }
    }
}
