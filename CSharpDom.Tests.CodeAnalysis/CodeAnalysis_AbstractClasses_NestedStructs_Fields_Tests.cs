using CSharpDom.TestTarget.AbstractClasses.NestedStructs.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_AbstractClasses_NestedStructs_Fields_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithConstFieldUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithConstField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithInternalFieldUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithInternalField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithPrivateFieldUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithPrivateField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithPublicFieldUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithPublicField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithReadOnlyFieldUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithStaticFieldUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithStaticField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithStaticReadOnlyFieldUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithStaticVolatileFieldUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithStaticVolatileField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithVolatileFieldUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithVolatileField));
        }
    }
}
