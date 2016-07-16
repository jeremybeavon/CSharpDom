using CSharpDom.TestTarget.AbstractClasses.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_Constructors_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithConstructorWith1AttributeUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithConstructorWith1ParameterUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public async Task TestAbstractClassWithConstructorWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithConstructorWith2ParametersUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public async Task TestAbstractClassWithInternalConstructorUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithInternalConstructor));
        }

        [TestMethod]
        public async Task TestAbstractClassWithConstructorWithParametersWithAttributesUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestAbstractClassWithConstructorWithParametersWithModifiersUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestAbstractClassWithPrivateConstructorUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithPrivateConstructor));
        }

        [TestMethod]
        public async Task TestAbstractClassWithProtectedConstructorUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithProtectedConstructor));
        }

        [TestMethod]
        public async Task TestAbstractClassWithProtectedInternalConstructorUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithProtectedInternalConstructor));
        }

        [TestMethod]
        public async Task TestAbstractClassWithPublicConstructorUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithPublicConstructor));
        }
    }
}
