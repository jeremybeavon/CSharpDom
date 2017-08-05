using CSharpDom.TestTarget.Classes.NestedSealedClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedSealedClasses_Fields_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithConstFieldUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithConstField));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithInternalFieldUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithInternalField));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNewFieldUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNewField));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNewStaticFieldUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNewStaticField));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNewStaticReadOnlyFieldUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNewStaticVolatileFieldUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNewVolatileFieldUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNewVolatileField));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithPrivateFieldUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithPrivateField));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithProtectedFieldUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedField));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithProtectedInternalFieldUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedInternalField));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithPublicFieldUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithPublicField));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithReadOnlyFieldUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithStaticFieldUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithStaticField));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithStaticReadOnlyFieldUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithStaticVolatileFieldUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithStaticVolatileField));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithVolatileFieldUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithVolatileField));
        }
    }
}
