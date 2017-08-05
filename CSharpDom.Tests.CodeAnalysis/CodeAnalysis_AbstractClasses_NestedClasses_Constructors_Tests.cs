using CSharpDom.TestTarget.AbstractClasses.NestedClasses.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_AbstractClasses_NestedClasses_Constructors_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithConstructorWith1AttributeUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithConstructorWith1ParameterUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithConstructorWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithConstructorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithConstructorWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithConstructorWith2ParametersUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithInternalConstructorUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithInternalConstructor));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithConstructorWithParametersWithAttributesUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithConstructorWithParametersWithModifiersUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithPrivateConstructorUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithPrivateConstructor));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithProtectedConstructorUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithProtectedConstructor));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithProtectedInternalConstructorUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithProtectedInternalConstructor));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithPublicConstructorUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithPublicConstructor));
        }
    }
}
