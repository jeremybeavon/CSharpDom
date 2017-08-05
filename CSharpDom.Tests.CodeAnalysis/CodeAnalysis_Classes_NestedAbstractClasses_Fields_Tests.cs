using CSharpDom.TestTarget.Classes.NestedAbstractClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedAbstractClasses_Fields_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithConstFieldUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithConstField));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithInternalFieldUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithInternalField));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNewFieldUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewField));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNewStaticFieldUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewStaticField));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNewStaticReadOnlyFieldUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNewStaticVolatileFieldUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNewVolatileFieldUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewVolatileField));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithPrivateFieldUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithPrivateField));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithProtectedFieldUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedField));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithProtectedInternalFieldUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedInternalField));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithPublicFieldUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithPublicField));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithReadOnlyFieldUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithStaticFieldUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithStaticField));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithStaticReadOnlyFieldUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithStaticVolatileFieldUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithStaticVolatileField));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithVolatileFieldUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithVolatileField));
        }
    }
}
