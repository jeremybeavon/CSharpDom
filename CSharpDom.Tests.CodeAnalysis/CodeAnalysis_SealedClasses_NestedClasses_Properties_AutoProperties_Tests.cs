using CSharpDom.TestTarget.SealedClasses.NestedClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_NestedClasses_Properties_AutoProperties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithInternalAutoPropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithNewAutoPropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewAutoProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithNewStaticAutoPropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithNewVirtualAutoPropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewVirtualAutoProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithOverrideAutoPropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithPrivateAutoPropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithProtectedAutoPropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithProtectedInternalAutoPropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithPublicAutoPropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPublicAutoProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithSealedOverrideAutoPropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithStaticAutoPropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithStaticAutoProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithVirtualAutoPropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithVirtualAutoProperty));
        }
    }
}
