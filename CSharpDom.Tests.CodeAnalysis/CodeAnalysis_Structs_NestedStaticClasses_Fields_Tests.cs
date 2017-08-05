using CSharpDom.TestTarget.Structs.NestedStaticClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedStaticClasses_Fields_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithConstFieldUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithConstField));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithInternalFieldUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithInternalField));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithPrivateFieldUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithPrivateField));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithPublicFieldUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithPublicField));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithReadOnlyFieldUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithVolatileFieldUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithVolatileField));
        }
    }
}
