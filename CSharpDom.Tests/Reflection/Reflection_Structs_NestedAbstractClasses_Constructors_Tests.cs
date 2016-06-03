using CSharpDom.TestTarget.Structs.NestedAbstractClasses.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedAbstractClasses_Constructors_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithConstructorWith1AttributeUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithConstructorWith1ParameterUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithConstructorWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithConstructorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithConstructorWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithConstructorWith2ParametersUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithInternalConstructorUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithInternalConstructor));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithConstructorWithParametersWithAttributesUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithConstructorWithParametersWithModifiersUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithPrivateConstructorUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithPrivateConstructor));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithProtectedConstructorUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedConstructor));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithProtectedInternalConstructorUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedInternalConstructor));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithPublicConstructorUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithPublicConstructor));
        }
    }
}
