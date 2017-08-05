using CSharpDom.TestTarget.Classes.NestedSealedClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedSealedClasses_Properties_AutoProperties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithInternalAutoPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNewAutoPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNewAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNewStaticAutoPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithOverrideAutoPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithPrivateAutoPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithProtectedAutoPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithProtectedInternalAutoPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithPublicAutoPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithPublicAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithSealedOverrideAutoPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithStaticAutoPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithStaticAutoProperty));
        }
    }
}
