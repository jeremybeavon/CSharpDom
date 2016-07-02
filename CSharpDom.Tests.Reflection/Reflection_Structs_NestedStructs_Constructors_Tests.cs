using CSharpDom.TestTarget.Structs.NestedStructs.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedStructs_Constructors_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStructWithNestedStructWithConstructorWith1AttributeUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithConstructorWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithConstructorWith1ParameterUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithConstructorWith1Parameter));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithConstructorWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithConstructorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithConstructorWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithConstructorWith2ParametersUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithConstructorWith2Parameters));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithInternalConstructorUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithInternalConstructor));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithConstructorWithParametersWithAttributesUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithConstructorWithParametersWithModifiersUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithPrivateConstructorUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithPrivateConstructor));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithPublicConstructorUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithPublicConstructor));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithEventWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithEventPropertyWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithEventPropertyWith2AttributesIn2AttributeGroups));
        }
    }
}
