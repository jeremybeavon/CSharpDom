using CSharpDom.TestTarget.SealedClasses.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_Constructors_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestSealedClassWithConstructorWith1AttributeUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithConstructorWith1ParameterUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public async Task TestSealedClassWithConstructorWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithConstructorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithConstructorWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithConstructorWith2ParametersUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public async Task TestSealedClassWithInternalConstructorUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithInternalConstructor));
        }

        [TestMethod]
        public async Task TestSealedClassWithConstructorWithParametersWithAttributesUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestSealedClassWithConstructorWithParametersWithModifiersUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestSealedClassWithPrivateConstructorUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithPrivateConstructor));
        }

        [TestMethod]
        public async Task TestSealedClassWithPublicConstructorUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithPublicConstructor));
        }
    }
}
