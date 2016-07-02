using CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses.NestedInterfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_NestedStaticClasses_NestedInterfaces_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithNestedInterfaceWith1AttributeUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedInterfaceWith1Attribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithNestedInterfaceWith1GenericParameterUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedInterfaceWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithNestedInterfaceWith1ImplementedInterfaceUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedInterfaceWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithNestedInterfaceWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedInterfaceWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithNestedInterfaceWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedInterfaceWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithNestedInterfaceWith2GenericParametersUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedInterfaceWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithNestedInterfaceWith2ImplementedInterfacesUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedInterfaceWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterClassConstraintUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterStructConstraintUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedInterfaceWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithNestedInternalInterfaceUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedInternalInterface));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithNestedPrivateInterfaceUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedPrivateInterface));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithNestedProtectedInterfaceUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedProtectedInterface));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithNestedProtectedInternalInterfaceUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedProtectedInternalInterface));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithPublicNestedInterfaceUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithPublicNestedInterface));
        }
    }
}
