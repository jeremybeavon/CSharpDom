using CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_StaticClasses_NestedSealedClasses_Properties_AutoProperties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithInternalAutoPropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNewAutoPropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNewAutoProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNewStaticAutoPropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithOverrideAutoPropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithPrivateAutoPropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithProtectedAutoPropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithProtectedInternalAutoPropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithPublicAutoPropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithPublicAutoProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithSealedOverrideAutoPropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithStaticAutoPropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithStaticAutoProperty));
        }
    }
}
