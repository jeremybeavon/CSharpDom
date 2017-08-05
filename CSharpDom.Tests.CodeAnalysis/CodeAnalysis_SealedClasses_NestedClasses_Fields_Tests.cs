using CSharpDom.TestTarget.SealedClasses.NestedClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_NestedClasses_Fields_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithConstFieldUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithConstField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithInternalFieldUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithInternalField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithNewFieldUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithNewStaticFieldUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewStaticField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithNewStaticReadOnlyFieldUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithNewStaticVolatileFieldUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithNewVolatileFieldUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewVolatileField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithPrivateFieldUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPrivateField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithProtectedFieldUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithProtectedField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithProtectedInternalFieldUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithProtectedInternalField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithPublicFieldUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPublicField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithReadOnlyFieldUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithStaticFieldUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithStaticField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithStaticReadOnlyFieldUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithStaticVolatileFieldUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithStaticVolatileField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithVolatileFieldUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithVolatileField));
        }
    }
}
