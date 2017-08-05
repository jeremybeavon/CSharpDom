using CSharpDom.TestTarget.Classes.NestedAbstractClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedAbstractClasses_Properties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithInternalPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithInternalProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNewPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNewStaticPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewStaticProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNewVirtualPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewVirtualProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithOverridePropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithOverrideProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithPrivatePropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithPrivateProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithProtectedPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithProtectedInternalPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithPublicPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithPublicProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithSealedOverridePropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithStaticPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithStaticProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithVirtualPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithVirtualProperty));
        }
    }
}
