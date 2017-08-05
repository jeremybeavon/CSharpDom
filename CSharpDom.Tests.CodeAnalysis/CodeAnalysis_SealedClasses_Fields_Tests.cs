using CSharpDom.TestTarget.SealedClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_Fields_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestSealedClassWithConstFieldUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithConstField));
        }

        [TestMethod]
        public async Task TestSealedClassWithInternalFieldUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithInternalField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNewFieldUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNewField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNewStaticFieldUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNewStaticField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNewStaticReadOnlyFieldUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNewStaticVolatileFieldUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNewVolatileFieldUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNewVolatileField));
        }

        [TestMethod]
        public async Task TestSealedClassWithPrivateFieldUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithPrivateField));
        }

        [TestMethod]
        public async Task TestSealedClassWithProtectedFieldUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithProtectedField));
        }

        [TestMethod]
        public async Task TestSealedClassWithProtectedInternalFieldUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithProtectedInternalField));
        }

        [TestMethod]
        public async Task TestSealedClassWithPublicFieldUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithPublicField));
        }

        [TestMethod]
        public async Task TestSealedClassWithReadOnlyFieldUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestSealedClassWithStaticFieldUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithStaticField));
        }

        [TestMethod]
        public async Task TestSealedClassWithStaticReadOnlyFieldUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestSealedClassWithStaticVolatileFieldUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithStaticVolatileField));
        }

        [TestMethod]
        public async Task TestSealedClassWithVolatileFieldUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithVolatileField));
        }
    }
}
