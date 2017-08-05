using CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_StaticClasses_NestedAbstractClasses_Fields_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithConstFieldUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithConstField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithInternalFieldUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithInternalField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithNewFieldUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNewField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithNewStaticFieldUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNewStaticField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithNewStaticReadOnlyFieldUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithNewStaticVolatileFieldUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithNewVolatileFieldUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNewVolatileField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithPrivateFieldUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithPrivateField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithProtectedFieldUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithProtectedField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithProtectedInternalFieldUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithProtectedInternalField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithPublicFieldUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithPublicField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithReadOnlyFieldUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithStaticFieldUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithStaticField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithStaticReadOnlyFieldUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithStaticVolatileFieldUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithStaticVolatileField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithVolatileFieldUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithVolatileField));
        }
    }
}
