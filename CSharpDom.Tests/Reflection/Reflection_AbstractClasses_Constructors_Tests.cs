using CSharpDom.TestTarget.AbstractClasses.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_Constructors_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithConstructorWith1AttributeUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithConstructorWith1ParameterUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public async Task TestAbstractClassWithConstructorWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithConstructorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestAbstractClassWithConstructorWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithConstructorWith2ParametersUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public async Task TestAbstractClassWithInternalConstructorUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithInternalConstructor));
        }

        [TestMethod]
        public async Task TestAbstractClassWithConstructorWithParametersWithAttributesUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestAbstractClassWithConstructorWithParametersWithModifiersUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestAbstractClassWithPrivateConstructorUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithPrivateConstructor));
        }

        [TestMethod]
        public async Task TestAbstractClassWithProtectedConstructorUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithProtectedConstructor));
        }

        [TestMethod]
        public async Task TestAbstractClassWithProtectedInternalConstructorUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithProtectedInternalConstructor));
        }

        [TestMethod]
        public async Task TestAbstractClassWithPublicConstructorUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithPublicConstructor));
        }

        [TestMethod]
        public async Task TestAbstractClassWithEventWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }
    }
}
