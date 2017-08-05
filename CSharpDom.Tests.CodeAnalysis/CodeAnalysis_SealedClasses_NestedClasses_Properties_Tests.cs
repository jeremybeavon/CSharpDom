using CSharpDom.TestTarget.SealedClasses.NestedClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_NestedClasses_Properties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithInternalPropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithInternalProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithNewPropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithNewStaticPropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewStaticProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithNewVirtualPropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewVirtualProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithOverridePropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithOverrideProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithPrivatePropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPrivateProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithProtectedPropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithProtectedProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithProtectedInternalPropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithPublicPropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPublicProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithSealedOverridePropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithStaticPropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithStaticProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithVirtualPropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithVirtualProperty));
        }
    }
}
