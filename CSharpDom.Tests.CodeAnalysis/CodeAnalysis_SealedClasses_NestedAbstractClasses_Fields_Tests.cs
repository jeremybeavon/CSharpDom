using CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_NestedAbstractClasses_Fields_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithConstFieldUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithConstField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithInternalFieldUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithInternalField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithNewFieldUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNewField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithNewStaticFieldUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNewStaticField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithNewStaticReadOnlyFieldUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithNewStaticVolatileFieldUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithNewVolatileFieldUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNewVolatileField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithPrivateFieldUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithPrivateField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithProtectedFieldUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithProtectedField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithProtectedInternalFieldUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithProtectedInternalField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithPublicFieldUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithPublicField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithReadOnlyFieldUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithStaticFieldUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithStaticField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithStaticReadOnlyFieldUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithStaticVolatileFieldUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithStaticVolatileField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithVolatileFieldUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithVolatileField));
        }
    }
}
