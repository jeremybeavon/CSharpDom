using CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_NestedAbstractClasses_Constructors_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithConstructorWith1AttributeUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithConstructorWith1ParameterUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithConstructorWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithConstructorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithConstructorWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithConstructorWith2ParametersUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithInternalConstructorUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithInternalConstructor));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithConstructorWithParametersWithAttributesUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithConstructorWithParametersWithModifiersUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithPrivateConstructorUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithPrivateConstructor));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithProtectedConstructorUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithProtectedConstructor));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithProtectedInternalConstructorUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithProtectedInternalConstructor));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithPublicConstructorUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithPublicConstructor));
        }
    }
}
