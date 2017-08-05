using CSharpDom.TestTarget.SealedClasses.NestedStaticClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_NestedStaticClasses_Properties_AutoProperties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithInternalAutoPropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithPrivateAutoPropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithPublicAutoPropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithPublicAutoProperty));
        }
    }
}
