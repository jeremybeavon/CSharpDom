using CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_AbstractClasses_NestedSealedClasses_Fields_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithConstFieldUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithConstField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithInternalFieldUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithInternalField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithNewFieldUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNewField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithNewStaticFieldUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNewStaticField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithNewStaticReadOnlyFieldUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithNewStaticVolatileFieldUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithNewVolatileFieldUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNewVolatileField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithPrivateFieldUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithPrivateField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithProtectedFieldUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithProtectedField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithProtectedInternalFieldUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithProtectedInternalField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithPublicFieldUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithPublicField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithReadOnlyFieldUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithStaticFieldUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithStaticField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithStaticReadOnlyFieldUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithStaticVolatileFieldUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithStaticVolatileField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithVolatileFieldUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithVolatileField));
        }
    }
}
