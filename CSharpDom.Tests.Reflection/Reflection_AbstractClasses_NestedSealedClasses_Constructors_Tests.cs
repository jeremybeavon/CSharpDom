using CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_NestedSealedClasses_Constructors_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithConstructorWith1AttributeUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithConstructorWith1ParameterUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithConstructorWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithConstructorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithConstructorWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithConstructorWith2ParametersUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithInternalConstructorUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithInternalConstructor));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithConstructorWithParametersWithAttributesUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithConstructorWithParametersWithModifiersUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithPrivateConstructorUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithPrivateConstructor));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithProtectedConstructorUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithProtectedConstructor));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithProtectedInternalConstructorUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithProtectedInternalConstructor));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithPublicConstructorUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithPublicConstructor));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithEventWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }
    }
}
