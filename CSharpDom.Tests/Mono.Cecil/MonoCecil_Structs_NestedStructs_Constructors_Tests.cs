using CSharpDom.TestTarget.Structs.NestedStructs.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedStructs_Constructors_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestStructWithNestedStructWithConstructorWith1AttributeUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithConstructorWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithConstructorWith1ParameterUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithConstructorWith1Parameter));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithConstructorWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithConstructorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithConstructorWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithConstructorWith2ParametersUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithConstructorWith2Parameters));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithInternalConstructorUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithInternalConstructor));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithConstructorWithParametersWithAttributesUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithConstructorWithParametersWithModifiersUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithPrivateConstructorUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithPrivateConstructor));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithPublicConstructorUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithPublicConstructor));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithEventWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithEventPropertyWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithEventPropertyWith2AttributesIn2AttributeGroups));
        }
    }
}
