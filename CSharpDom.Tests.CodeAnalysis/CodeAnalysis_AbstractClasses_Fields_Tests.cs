using CSharpDom.TestTarget.AbstractClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_AbstractClasses_Fields_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithConstFieldUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithConstField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithInternalFieldUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithInternalField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNewFieldUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNewField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNewStaticFieldUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNewStaticField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNewStaticReadOnlyFieldUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNewStaticVolatileFieldUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNewVolatileFieldUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNewVolatileField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithPrivateFieldUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithPrivateField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithProtectedFieldUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithProtectedField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithProtectedInternalFieldUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithProtectedInternalField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithPublicFieldUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithPublicField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithReadOnlyFieldUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithStaticFieldUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithStaticField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithStaticReadOnlyFieldUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithStaticVolatileFieldUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithStaticVolatileField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithVolatileFieldUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithVolatileField));
        }
    }
}
