using CSharpDom.TestTarget.StaticClasses.NestedClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_StaticClasses_NestedClasses_Properties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithInternalPropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithInternalProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNewPropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNewStaticPropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewStaticProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNewVirtualPropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewVirtualProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithOverridePropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithOverrideProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithPrivatePropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPrivateProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithProtectedPropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithProtectedInternalPropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithPublicPropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPublicProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithSealedOverridePropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithStaticPropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithStaticProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithVirtualPropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithVirtualProperty));
        }
    }
}
