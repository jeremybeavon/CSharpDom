using CSharpDom.TestTarget.Classes.NestedStructs.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedStructs_Constructors_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestClassWithNestedStructWithConstructorWith1AttributeUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithConstructorWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithConstructorWith1ParameterUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithConstructorWith1Parameter));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithConstructorWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithConstructorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithConstructorWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithConstructorWith2ParametersUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithConstructorWith2Parameters));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithInternalConstructorUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithInternalConstructor));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithConstructorWithParametersWithAttributesUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithConstructorWithParametersWithModifiersUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithPrivateConstructorUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithPrivateConstructor));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithPublicConstructorUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithPublicConstructor));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithEventWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithEventPropertyWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithEventPropertyWith2AttributesIn2AttributeGroups));
        }
    }
}
