using CSharpDom.TestTarget.Classes.NestedStaticClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedStaticClasses_Fields_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithConstFieldUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithConstField));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithInternalFieldUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithInternalField));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithPrivateFieldUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithPrivateField));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithPublicFieldUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithPublicField));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithReadOnlyFieldUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithVolatileFieldUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithVolatileField));
        }
    }
}
