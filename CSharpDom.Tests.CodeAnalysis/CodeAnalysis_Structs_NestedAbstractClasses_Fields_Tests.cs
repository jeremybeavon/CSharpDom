using CSharpDom.TestTarget.Structs.NestedAbstractClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedAbstractClasses_Fields_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithConstFieldUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithConstField));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithInternalFieldUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithInternalField));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNewFieldUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNewField));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNewStaticFieldUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNewStaticField));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNewStaticReadOnlyFieldUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNewStaticVolatileFieldUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNewVolatileFieldUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNewVolatileField));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithPrivateFieldUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithPrivateField));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithProtectedFieldUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedField));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithProtectedInternalFieldUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedInternalField));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithPublicFieldUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithPublicField));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithReadOnlyFieldUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithStaticFieldUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithStaticField));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithStaticReadOnlyFieldUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithStaticVolatileFieldUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithStaticVolatileField));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithVolatileFieldUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithVolatileField));
        }
    }
}
