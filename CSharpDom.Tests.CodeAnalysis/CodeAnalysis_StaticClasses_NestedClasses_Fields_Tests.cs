using CSharpDom.TestTarget.StaticClasses.NestedClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_StaticClasses_NestedClasses_Fields_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithConstFieldUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithConstField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithInternalFieldUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithInternalField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNewFieldUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNewStaticFieldUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewStaticField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNewStaticReadOnlyFieldUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNewStaticVolatileFieldUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNewVolatileFieldUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewVolatileField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithPrivateFieldUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPrivateField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithProtectedFieldUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithProtectedInternalFieldUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedInternalField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithPublicFieldUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPublicField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithReadOnlyFieldUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithStaticFieldUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithStaticField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithStaticReadOnlyFieldUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithStaticVolatileFieldUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithStaticVolatileField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithVolatileFieldUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithVolatileField));
        }
    }
}
