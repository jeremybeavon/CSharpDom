using CSharpDom.TestTarget.Structs.NestedSealedClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedSealedClasses_Fields_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithConstFieldUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithConstField));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithInternalFieldUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithInternalField));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNewFieldUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNewField));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNewStaticFieldUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNewStaticField));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNewStaticReadOnlyFieldUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNewStaticVolatileFieldUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNewVolatileFieldUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNewVolatileField));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithPrivateFieldUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithPrivateField));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithProtectedFieldUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedField));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithProtectedInternalFieldUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedInternalField));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithPublicFieldUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithPublicField));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithReadOnlyFieldUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithStaticFieldUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithStaticField));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithStaticReadOnlyFieldUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithStaticVolatileFieldUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithStaticVolatileField));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithVolatileFieldUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithVolatileField));
        }
    }
}
