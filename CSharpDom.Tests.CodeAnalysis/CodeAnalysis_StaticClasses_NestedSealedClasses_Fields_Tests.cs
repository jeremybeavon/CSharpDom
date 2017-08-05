using CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_StaticClasses_NestedSealedClasses_Fields_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithConstFieldUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithConstField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithInternalFieldUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithInternalField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNewFieldUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNewField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNewStaticFieldUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNewStaticField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNewStaticReadOnlyFieldUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNewStaticVolatileFieldUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNewVolatileFieldUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNewVolatileField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithPrivateFieldUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithPrivateField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithProtectedFieldUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithProtectedField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithProtectedInternalFieldUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithProtectedInternalField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithPublicFieldUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithPublicField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithReadOnlyFieldUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithStaticFieldUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithStaticField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithStaticReadOnlyFieldUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithStaticVolatileFieldUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithStaticVolatileField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithVolatileFieldUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithVolatileField));
        }
    }
}
