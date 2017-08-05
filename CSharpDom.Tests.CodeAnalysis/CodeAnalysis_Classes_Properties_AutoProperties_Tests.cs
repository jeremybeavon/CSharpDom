using CSharpDom.TestTarget.Classes.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_Properties_AutoProperties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestClassWithInternalAutoPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNewAutoPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNewAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNewStaticAutoPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNewVirtualAutoPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNewVirtualAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithOverrideAutoPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithPrivateAutoPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithProtectedAutoPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithProtectedInternalAutoPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithPublicAutoPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithPublicAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithSealedOverrideAutoPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithStaticAutoPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithStaticAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithVirtualAutoPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithVirtualAutoProperty));
        }
    }
}
