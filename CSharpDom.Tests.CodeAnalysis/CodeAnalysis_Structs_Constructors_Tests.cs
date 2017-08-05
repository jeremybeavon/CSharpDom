using CSharpDom.TestTarget.Structs.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_Constructors_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStructWithConstructorWith1AttributeUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithConstructorWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithConstructorWith1ParameterUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithConstructorWith1Parameter));
        }

        [TestMethod]
        public async Task TestStructWithConstructorWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithConstructorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithConstructorWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithConstructorWith2ParametersUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithConstructorWith2Parameters));
        }

        [TestMethod]
        public async Task TestStructWithInternalConstructorUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithInternalConstructor));
        }

        [TestMethod]
        public async Task TestStructWithConstructorWithParametersWithAttributesUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestStructWithConstructorWithParametersWithModifiersUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestStructWithPrivateConstructorUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithPrivateConstructor));
        }

        [TestMethod]
        public async Task TestStructWithPublicConstructorUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithPublicConstructor));
        }
    }
}
