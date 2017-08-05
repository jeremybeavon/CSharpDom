using CSharpDom.TestTarget.AbstractClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_AbstractClasses_Properties_AutoProperties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithInternalAutoPropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNewAutoPropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNewAutoProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNewStaticAutoPropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNewVirtualAutoPropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNewVirtualAutoProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithOverrideAutoPropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithPrivateAutoPropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithProtectedAutoPropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithProtectedInternalAutoPropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithPublicAutoPropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithPublicAutoProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithSealedOverrideAutoPropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithStaticAutoPropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithStaticAutoProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithVirtualAutoPropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithVirtualAutoProperty));
        }
    }
}
