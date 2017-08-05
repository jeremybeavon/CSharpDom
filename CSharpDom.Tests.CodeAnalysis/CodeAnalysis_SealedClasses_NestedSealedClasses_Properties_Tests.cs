using CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_NestedSealedClasses_Properties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithInternalPropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithInternalProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithNewPropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNewProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithNewStaticPropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNewStaticProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithOverridePropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithOverrideProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithPrivatePropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithPrivateProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithProtectedPropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithProtectedProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithProtectedInternalPropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithPublicPropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithPublicProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithSealedOverridePropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithStaticPropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithStaticProperty));
        }
    }
}
