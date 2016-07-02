using CSharpDom.TestTarget.Structs.NestedClasses.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedClasses_Constructors_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestStructWithNestedClassWithConstructorWith1AttributeUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithConstructorWith1ParameterUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithConstructorWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithConstructorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithConstructorWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithConstructorWith2ParametersUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithInternalConstructorUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithInternalConstructor));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithConstructorWithParametersWithAttributesUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithConstructorWithParametersWithModifiersUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithPrivateConstructorUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithPrivateConstructor));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithProtectedConstructorUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithProtectedConstructor));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithProtectedInternalConstructorUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithProtectedInternalConstructor));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithPublicConstructorUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithPublicConstructor));
        }
    }
}
