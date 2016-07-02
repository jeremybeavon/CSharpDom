using CSharpDom.TestTarget.AbstractClasses.NestedStructs.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_NestedStructs_Constructors_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithConstructorWith1AttributeUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithConstructorWith1Attribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithConstructorWith1ParameterUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithConstructorWith1Parameter));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithConstructorWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithConstructorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithConstructorWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithConstructorWith2ParametersUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithConstructorWith2Parameters));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithInternalConstructorUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithInternalConstructor));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithConstructorWithParametersWithAttributesUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithConstructorWithParametersWithModifiersUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithPrivateConstructorUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithPrivateConstructor));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithPublicConstructorUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithPublicConstructor));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithEventWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithEventPropertyWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithEventPropertyWith2AttributesIn2AttributeGroups));
        }
    }
}
