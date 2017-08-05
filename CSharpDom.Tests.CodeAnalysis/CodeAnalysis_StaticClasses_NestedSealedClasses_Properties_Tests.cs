using CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_StaticClasses_NestedSealedClasses_Properties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithInternalPropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithInternalProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNewPropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNewProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNewStaticPropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNewStaticProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithOverridePropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithOverrideProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithPrivatePropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithPrivateProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithProtectedPropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithProtectedProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithProtectedInternalPropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithPublicPropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithPublicProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithSealedOverridePropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithStaticPropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithStaticProperty));
        }
    }
}
