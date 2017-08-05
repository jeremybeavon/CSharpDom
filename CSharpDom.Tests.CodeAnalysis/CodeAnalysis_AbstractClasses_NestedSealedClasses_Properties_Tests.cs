using CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_AbstractClasses_NestedSealedClasses_Properties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithInternalPropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithInternalProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithNewPropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNewProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithNewStaticPropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNewStaticProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithOverridePropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithOverrideProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithPrivatePropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithPrivateProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithProtectedPropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithProtectedProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithProtectedInternalPropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithPublicPropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithPublicProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithSealedOverridePropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithStaticPropertyUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithStaticProperty));
        }
    }
}
