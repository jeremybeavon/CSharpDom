using CSharpDom.TestTarget.StaticClasses.NestedClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_StaticClasses_NestedClasses_Properties_AutoProperties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithInternalAutoPropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNewAutoPropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewAutoProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNewStaticAutoPropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNewVirtualAutoPropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewVirtualAutoProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithOverrideAutoPropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithPrivateAutoPropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithProtectedAutoPropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithProtectedInternalAutoPropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithPublicAutoPropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPublicAutoProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithSealedOverrideAutoPropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithStaticAutoPropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithStaticAutoProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithVirtualAutoPropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithVirtualAutoProperty));
        }
    }
}
