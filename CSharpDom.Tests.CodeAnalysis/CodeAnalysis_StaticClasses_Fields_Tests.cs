using CSharpDom.TestTarget.StaticClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_StaticClasses_Fields_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStaticClassWithConstFieldUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithConstField));
        }

        [TestMethod]
        public async Task TestStaticClassWithInternalFieldUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithInternalField));
        }

        [TestMethod]
        public async Task TestStaticClassWithPrivateFieldUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithPrivateField));
        }

        [TestMethod]
        public async Task TestStaticClassWithPublicFieldUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithPublicField));
        }

        [TestMethod]
        public async Task TestStaticClassWithReadOnlyFieldUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestStaticClassWithVolatileFieldUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithVolatileField));
        }
    }
}
