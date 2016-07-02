using CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_StaticClasses_NestedSealedClasses_Constructors_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithConstructorWith1AttributeUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithConstructorWith1ParameterUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithConstructorWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithConstructorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithConstructorWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithConstructorWith2ParametersUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithInternalConstructorUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithInternalConstructor));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithConstructorWithParametersWithAttributesUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithConstructorWithParametersWithModifiersUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithPrivateConstructorUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithPrivateConstructor));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithProtectedConstructorUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithProtectedConstructor));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithProtectedInternalConstructorUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithProtectedInternalConstructor));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithPublicConstructorUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithPublicConstructor));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithEventWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }
    }
}
