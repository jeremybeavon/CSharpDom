using CSharpDom.TestTarget.Structs.NestedAbstractClasses.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedAbstractClasses_Constructors_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithConstructorWith1AttributeUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithConstructorWith1ParameterUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithConstructorWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithConstructorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithConstructorWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithConstructorWith2ParametersUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithInternalConstructorUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithInternalConstructor));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithConstructorWithParametersWithAttributesUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithConstructorWithParametersWithModifiersUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithPrivateConstructorUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithPrivateConstructor));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithProtectedConstructorUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedConstructor));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithProtectedInternalConstructorUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedInternalConstructor));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithPublicConstructorUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithPublicConstructor));
        }
    }
}
