using CSharpDom.TestTarget.AbstractClasses.NestedClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_AbstractClasses_NestedClasses_Properties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithInternalPropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithInternalProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithNewPropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithNewStaticPropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewStaticProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithNewVirtualPropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewVirtualProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithOverridePropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithOverrideProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithPrivatePropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithPrivateProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithProtectedPropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithProtectedProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithProtectedInternalPropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithPublicPropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithPublicProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithSealedOverridePropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithStaticPropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithStaticProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithVirtualPropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithVirtualProperty));
        }
    }
}
