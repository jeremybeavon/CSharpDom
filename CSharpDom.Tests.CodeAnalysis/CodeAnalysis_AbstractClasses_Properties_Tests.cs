using CSharpDom.TestTarget.AbstractClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_AbstractClasses_Properties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithInternalPropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithInternalProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNewPropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNewProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNewStaticPropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNewStaticProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNewVirtualPropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNewVirtualProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithOverridePropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithOverrideProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithPrivatePropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithPrivateProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithProtectedPropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithProtectedProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithProtectedInternalPropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithPublicPropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithPublicProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithSealedOverridePropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithStaticPropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithStaticProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithVirtualPropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithVirtualProperty));
        }
    }
}
