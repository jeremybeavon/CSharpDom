using CSharpDom.TestTarget.SealedClasses.NestedStructs.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_NestedStructs_Properties_AutoProperties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithInternalAutoPropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithPrivateAutoPropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithPrivateAutoProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithPublicAutoPropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithPublicAutoProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithStaticAutoPropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithStaticAutoProperty));
        }
    }
}
