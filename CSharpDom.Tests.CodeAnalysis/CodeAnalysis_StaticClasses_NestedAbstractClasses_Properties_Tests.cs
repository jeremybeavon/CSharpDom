using CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_StaticClasses_NestedAbstractClasses_Properties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithInternalPropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithInternalProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithNewPropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNewProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithNewStaticPropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNewStaticProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithNewVirtualPropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNewVirtualProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithOverridePropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithOverrideProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithPrivatePropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithPrivateProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithProtectedPropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithProtectedProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithProtectedInternalPropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithPublicPropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithPublicProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithSealedOverridePropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithStaticPropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithStaticProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithVirtualPropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithVirtualProperty));
        }
    }
}
