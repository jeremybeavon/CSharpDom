using CSharpDom.TestTarget.StaticClasses.NestedStaticClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_StaticClasses_NestedStaticClasses_Fields_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithConstFieldUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithConstField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithInternalFieldUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithInternalField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithPrivateFieldUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithPrivateField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithPublicFieldUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithPublicField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithReadOnlyFieldUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithVolatileFieldUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithVolatileField));
        }
    }
}
