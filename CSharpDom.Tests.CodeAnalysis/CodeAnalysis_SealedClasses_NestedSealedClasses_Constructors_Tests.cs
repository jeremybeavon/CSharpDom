using CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_NestedSealedClasses_Constructors_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithConstructorWith1AttributeUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithConstructorWith1ParameterUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithConstructorWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithConstructorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithConstructorWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithConstructorWith2ParametersUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithInternalConstructorUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithInternalConstructor));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithConstructorWithParametersWithAttributesUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithConstructorWithParametersWithModifiersUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithPrivateConstructorUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithPrivateConstructor));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithProtectedConstructorUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithProtectedConstructor));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithProtectedInternalConstructorUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithProtectedInternalConstructor));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithPublicConstructorUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithPublicConstructor));
        }
    }
}
