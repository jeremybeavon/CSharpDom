using CSharpDom.TestTarget.Structs.NestedClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedClasses_Fields_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStructWithNestedClassWithConstFieldUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithConstField));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithInternalFieldUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithInternalField));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNewFieldUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNewField));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNewStaticFieldUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNewStaticField));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNewStaticReadOnlyFieldUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNewStaticVolatileFieldUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNewVolatileFieldUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNewVolatileField));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithPrivateFieldUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithPrivateField));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithProtectedFieldUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithProtectedField));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithProtectedInternalFieldUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithProtectedInternalField));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithPublicFieldUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithPublicField));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithReadOnlyFieldUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithStaticFieldUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithStaticField));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithStaticReadOnlyFieldUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithStaticVolatileFieldUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithStaticVolatileField));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithVolatileFieldUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithVolatileField));
        }
    }
}
