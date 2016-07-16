using CSharpDom.TestTarget.Structs.NestedSealedClasses.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedSealedClasses_Constructors_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithConstructorWith1AttributeUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithConstructorWith1ParameterUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithConstructorWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithConstructorWith2ParametersUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithInternalConstructorUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithInternalConstructor));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithConstructorWithParametersWithAttributesUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithConstructorWithParametersWithModifiersUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithPrivateConstructorUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithPrivateConstructor));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithProtectedConstructorUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedConstructor));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithProtectedInternalConstructorUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedInternalConstructor));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithPublicConstructorUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithPublicConstructor));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithEventWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }
    }
}
