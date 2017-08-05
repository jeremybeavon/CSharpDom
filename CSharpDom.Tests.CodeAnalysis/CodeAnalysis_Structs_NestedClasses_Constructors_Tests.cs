using CSharpDom.TestTarget.Structs.NestedClasses.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedClasses_Constructors_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStructWithNestedClassWithConstructorWith1AttributeUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithConstructorWith1ParameterUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithConstructorWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithConstructorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithConstructorWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithConstructorWith2ParametersUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithInternalConstructorUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithInternalConstructor));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithConstructorWithParametersWithAttributesUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithConstructorWithParametersWithModifiersUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithPrivateConstructorUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithPrivateConstructor));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithProtectedConstructorUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithProtectedConstructor));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithProtectedInternalConstructorUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithProtectedInternalConstructor));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithPublicConstructorUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithPublicConstructor));
        }
    }
}
