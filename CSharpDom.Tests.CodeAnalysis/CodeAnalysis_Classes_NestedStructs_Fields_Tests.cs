using CSharpDom.TestTarget.Classes.NestedStructs.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedStructs_Fields_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestClassWithNestedStructWithConstFieldUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithConstField));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithInternalFieldUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithInternalField));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithPrivateFieldUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithPrivateField));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithPublicFieldUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithPublicField));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithReadOnlyFieldUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithStaticFieldUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithStaticField));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithStaticReadOnlyFieldUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithStaticVolatileFieldUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithStaticVolatileField));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithVolatileFieldUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithVolatileField));
        }
    }
}
