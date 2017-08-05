using CSharpDom.TestTarget.SealedClasses.NestedClasses.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_NestedClasses_Constructors_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithConstructorWith1AttributeUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithConstructorWith1ParameterUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithConstructorWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithConstructorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithConstructorWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithConstructorWith2ParametersUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithInternalConstructorUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithInternalConstructor));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithConstructorWithParametersWithAttributesUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithConstructorWithParametersWithModifiersUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithPrivateConstructorUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPrivateConstructor));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithProtectedConstructorUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithProtectedConstructor));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithProtectedInternalConstructorUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithProtectedInternalConstructor));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithPublicConstructorUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPublicConstructor));
        }
    }
}
