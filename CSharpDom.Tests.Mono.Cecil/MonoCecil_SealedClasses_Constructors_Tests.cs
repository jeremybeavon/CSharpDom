using CSharpDom.TestTarget.SealedClasses.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_SealedClasses_Constructors_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestSealedClassWithConstructorWith1AttributeUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithConstructorWith1ParameterUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public async Task TestSealedClassWithConstructorWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithConstructorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithConstructorWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithConstructorWith2ParametersUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public async Task TestSealedClassWithInternalConstructorUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithInternalConstructor));
        }

        [TestMethod]
        public async Task TestSealedClassWithConstructorWithParametersWithAttributesUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestSealedClassWithConstructorWithParametersWithModifiersUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestSealedClassWithPrivateConstructorUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithPrivateConstructor));
        }

        [TestMethod]
        public async Task TestSealedClassWithPublicConstructorUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithPublicConstructor));
        }

        [TestMethod]
        public async Task TestSealedClassWithEventWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }
    }
}
