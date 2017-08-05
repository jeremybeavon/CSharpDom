using CSharpDom.TestTarget.Structs.NestedStructs.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedStructs_Fields_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStructWithNestedStructWithConstFieldUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithConstField));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithInternalFieldUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithInternalField));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithPrivateFieldUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithPrivateField));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithPublicFieldUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithPublicField));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithReadOnlyFieldUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithStaticFieldUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithStaticField));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithStaticReadOnlyFieldUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithStaticVolatileFieldUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithStaticVolatileField));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithVolatileFieldUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithVolatileField));
        }
    }
}
