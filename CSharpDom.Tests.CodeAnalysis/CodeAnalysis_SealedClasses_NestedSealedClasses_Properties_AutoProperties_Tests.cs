using CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_NestedSealedClasses_Properties_AutoProperties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithInternalAutoPropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithNewAutoPropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNewAutoProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithNewStaticAutoPropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithOverrideAutoPropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithPrivateAutoPropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithProtectedAutoPropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithProtectedInternalAutoPropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithPublicAutoPropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithPublicAutoProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithSealedOverrideAutoPropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithStaticAutoPropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithStaticAutoProperty));
        }
    }
}
