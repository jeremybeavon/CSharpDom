using CSharpDom.TestTarget.Classes.NestedClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedClasses_Properties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestClassWithNestedClassWithInternalPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithInternalProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNewPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNewProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNewStaticPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNewStaticProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNewVirtualPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNewVirtualProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithOverridePropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithOverrideProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithPrivatePropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithPrivateProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithProtectedPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithProtectedProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithProtectedInternalPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithPublicPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithPublicProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithSealedOverridePropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithStaticPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithStaticProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithVirtualPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithVirtualProperty));
        }
    }
}
