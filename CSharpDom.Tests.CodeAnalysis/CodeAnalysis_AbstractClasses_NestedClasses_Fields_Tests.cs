using CSharpDom.TestTarget.AbstractClasses.NestedClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_AbstractClasses_NestedClasses_Fields_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithConstFieldUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithConstField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithInternalFieldUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithInternalField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithNewFieldUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithNewStaticFieldUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewStaticField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithNewStaticReadOnlyFieldUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithNewStaticVolatileFieldUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithNewVolatileFieldUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewVolatileField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithPrivateFieldUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithPrivateField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithProtectedFieldUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithProtectedField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithProtectedInternalFieldUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithProtectedInternalField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithPublicFieldUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithPublicField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithReadOnlyFieldUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithStaticFieldUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithStaticField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithStaticReadOnlyFieldUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithStaticVolatileFieldUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithStaticVolatileField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithVolatileFieldUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithVolatileField));
        }
    }
}
