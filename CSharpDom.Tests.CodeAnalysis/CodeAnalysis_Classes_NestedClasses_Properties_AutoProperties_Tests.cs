using CSharpDom.TestTarget.Classes.NestedClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedClasses_Properties_AutoProperties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestClassWithNestedClassWithInternalAutoPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNewAutoPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNewAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNewStaticAutoPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNewVirtualAutoPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNewVirtualAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithOverrideAutoPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithPrivateAutoPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithProtectedAutoPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithProtectedInternalAutoPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithPublicAutoPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithPublicAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithSealedOverrideAutoPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithStaticAutoPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithStaticAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithVirtualAutoPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithVirtualAutoProperty));
        }
    }
}
