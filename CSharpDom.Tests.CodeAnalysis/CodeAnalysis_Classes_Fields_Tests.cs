using CSharpDom.TestTarget.Classes.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_Fields_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestClassWithConstFieldUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithConstField));
        }

        [TestMethod]
        public async Task TestClassWithInternalFieldUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithInternalField));
        }

        [TestMethod]
        public async Task TestClassWithNewFieldUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNewField));
        }

        [TestMethod]
        public async Task TestClassWithNewStaticFieldUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNewStaticField));
        }

        [TestMethod]
        public async Task TestClassWithNewStaticReadOnlyFieldUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestClassWithNewStaticVolatileFieldUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public async Task TestClassWithNewVolatileFieldUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNewVolatileField));
        }

        [TestMethod]
        public async Task TestClassWithPrivateFieldUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithPrivateField));
        }

        [TestMethod]
        public async Task TestClassWithProtectedFieldUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithProtectedField));
        }

        [TestMethod]
        public async Task TestClassWithProtectedInternalFieldUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithProtectedInternalField));
        }

        [TestMethod]
        public async Task TestClassWithPublicFieldUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithPublicField));
        }

        [TestMethod]
        public async Task TestClassWithReadOnlyFieldUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestClassWithStaticFieldUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithStaticField));
        }

        [TestMethod]
        public async Task TestClassWithStaticReadOnlyFieldUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestClassWithStaticVolatileFieldUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithStaticVolatileField));
        }

        [TestMethod]
        public async Task TestClassWithVolatileFieldUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithVolatileField));
        }
    }
}
