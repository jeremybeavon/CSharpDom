using CSharpDom.TestTarget.SealedClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_Properties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestSealedClassWithInternalPropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithInternalProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNewPropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNewProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNewStaticPropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNewStaticProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithOverridePropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithOverrideProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithPrivatePropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithPrivateProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithProtectedPropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithProtectedProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithProtectedInternalPropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithPublicPropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithPublicProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithSealedOverridePropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithStaticPropertyUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithStaticProperty));
        }
    }
}
