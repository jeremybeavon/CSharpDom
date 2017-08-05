using CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_NestedSealedClasses_Fields_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithConstFieldUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithConstField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithInternalFieldUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithInternalField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithNewFieldUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNewField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithNewStaticFieldUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNewStaticField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithNewStaticReadOnlyFieldUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithNewStaticVolatileFieldUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithNewVolatileFieldUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNewVolatileField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithPrivateFieldUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithPrivateField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithProtectedFieldUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithProtectedField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithProtectedInternalFieldUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithProtectedInternalField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithPublicFieldUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithPublicField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithReadOnlyFieldUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithStaticFieldUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithStaticField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithStaticReadOnlyFieldUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithStaticVolatileFieldUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithStaticVolatileField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithVolatileFieldUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithVolatileField));
        }
    }
}
