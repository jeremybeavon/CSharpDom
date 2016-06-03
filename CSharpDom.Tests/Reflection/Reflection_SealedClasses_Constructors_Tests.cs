using CSharpDom.TestTarget.SealedClasses.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_Constructors_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestSealedClassWithConstructorWith1AttributeUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithConstructorWith1ParameterUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public async Task TestSealedClassWithConstructorWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithConstructorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithConstructorWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithConstructorWith2ParametersUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public async Task TestSealedClassWithInternalConstructorUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithInternalConstructor));
        }

        [TestMethod]
        public async Task TestSealedClassWithConstructorWithParametersWithAttributesUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestSealedClassWithConstructorWithParametersWithModifiersUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestSealedClassWithPrivateConstructorUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithPrivateConstructor));
        }

        [TestMethod]
        public async Task TestSealedClassWithPublicConstructorUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithPublicConstructor));
        }

        [TestMethod]
        public async Task TestSealedClassWithEventWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }
    }
}
