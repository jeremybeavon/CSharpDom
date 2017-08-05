using CSharpDom.TestTarget.SealedClasses.NestedStructs.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_NestedStructs_Fields_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithConstFieldUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithConstField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithInternalFieldUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithInternalField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithPrivateFieldUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithPrivateField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithPublicFieldUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithPublicField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithReadOnlyFieldUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithStaticFieldUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithStaticField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithStaticReadOnlyFieldUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithStaticVolatileFieldUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithStaticVolatileField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithVolatileFieldUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithVolatileField));
        }
    }
}
