using CSharpDom.TestTarget.Structs.NestedAbstractClasses.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedAbstractClasses_Constructors_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithConstructorWith1AttributeUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithConstructorWith1ParameterUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithConstructorWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithConstructorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithConstructorWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithConstructorWith2ParametersUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithInternalConstructorUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithInternalConstructor));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithConstructorWithParametersWithAttributesUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithConstructorWithParametersWithModifiersUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithPrivateConstructorUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithPrivateConstructor));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithProtectedConstructorUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedConstructor));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithProtectedInternalConstructorUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedInternalConstructor));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithPublicConstructorUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithPublicConstructor));
        }
    }
}
