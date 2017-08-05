using CSharpDom.TestTarget.Structs.NestedStructs.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedStructs_Constructors_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStructWithNestedStructWithConstructorWith1AttributeUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithConstructorWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithConstructorWith1ParameterUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithConstructorWith1Parameter));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithConstructorWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithConstructorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithConstructorWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithConstructorWith2ParametersUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithConstructorWith2Parameters));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithInternalConstructorUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithInternalConstructor));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithConstructorWithParametersWithAttributesUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithConstructorWithParametersWithModifiersUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithPrivateConstructorUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithPrivateConstructor));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithPublicConstructorUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithPublicConstructor));
        }
    }
}
