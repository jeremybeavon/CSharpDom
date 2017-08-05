using CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_NestedAbstractClasses_Properties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithInternalPropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithInternalProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithNewPropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNewProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithNewStaticPropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNewStaticProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithNewVirtualPropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNewVirtualProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithOverridePropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithOverrideProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithPrivatePropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithPrivateProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithProtectedPropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithProtectedProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithProtectedInternalPropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithPublicPropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithPublicProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithSealedOverridePropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithStaticPropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithStaticProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithVirtualPropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithVirtualProperty));
        }
    }
}
