using CSharpDom.TestTarget.Classes.NestedClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedClasses_Fields_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestClassWithNestedClassWithConstFieldUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithConstField));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithInternalFieldUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithInternalField));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNewFieldUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNewField));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNewStaticFieldUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNewStaticField));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNewStaticReadOnlyFieldUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNewStaticVolatileFieldUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNewVolatileFieldUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNewVolatileField));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithPrivateFieldUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithPrivateField));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithProtectedFieldUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithProtectedField));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithProtectedInternalFieldUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithProtectedInternalField));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithPublicFieldUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithPublicField));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithReadOnlyFieldUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithStaticFieldUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithStaticField));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithStaticReadOnlyFieldUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithStaticVolatileFieldUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithStaticVolatileField));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithVolatileFieldUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithVolatileField));
        }
    }
}
