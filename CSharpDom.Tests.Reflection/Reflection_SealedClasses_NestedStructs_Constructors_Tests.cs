using CSharpDom.TestTarget.SealedClasses.NestedStructs.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedStructs_Constructors_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithConstructorWith1AttributeUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithConstructorWith1Attribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithConstructorWith1ParameterUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithConstructorWith1Parameter));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithConstructorWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithConstructorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithConstructorWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithConstructorWith2ParametersUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithConstructorWith2Parameters));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithInternalConstructorUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithInternalConstructor));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithConstructorWithParametersWithAttributesUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithConstructorWithParametersWithModifiersUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithPrivateConstructorUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithPrivateConstructor));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithPublicConstructorUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithPublicConstructor));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithEventWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithEventPropertyWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithEventPropertyWith2AttributesIn2AttributeGroups));
        }
    }
}
