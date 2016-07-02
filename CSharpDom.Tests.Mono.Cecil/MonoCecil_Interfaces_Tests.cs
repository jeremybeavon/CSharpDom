using CSharpDom.TestTarget.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Interfaces_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestInterfaceWith1AttributeUsingMonoCecil()
        {
            await TestInterfacesAsync(typeof(InterfaceWith1Attribute));
        }

        [TestMethod]
        public async Task TestInterfaceWith1GenericParameterUsingMonoCecil()
        {
            await TestInterfacesAsync(typeof(InterfaceWith1GenericParameter<>));
        }

        [TestMethod]
        public async Task TestInterfaceWith1ImplementedInterfaceUsingMonoCecil()
        {
            await TestInterfacesAsync(typeof(InterfaceWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestInterfaceWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestInterfacesAsync(typeof(InterfaceWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestInterfaceWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestInterfacesAsync(typeof(InterfaceWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestInterfaceWith2GenericParametersUsingMonoCecil()
        {
            await TestInterfacesAsync(typeof(InterfaceWith2GenericParameters<,>));
        }

        [TestMethod]
        public async Task TestInterfaceWith2ImplementedInterfacesUsingMonoCecil()
        {
            await TestInterfacesAsync(typeof(InterfaceWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestInterfaceWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            await TestInterfacesAsync(typeof(InterfaceWithGenericParameterBaseClassConstraint<>));
        }

        [TestMethod]
        public async Task TestInterfaceWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestInterfacesAsync(typeof(InterfaceWithGenericParameterClassAndEmptyConstructorConstraints<>));
        }

        [TestMethod]
        public async Task TestInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestInterfacesAsync(typeof(InterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints<>));
        }

        [TestMethod]
        public async Task TestInterfaceWithGenericParameterClassConstraintUsingMonoCecil()
        {
            await TestInterfacesAsync(typeof(InterfaceWithGenericParameterClassConstraint<>));
        }

        [TestMethod]
        public async Task TestInterfaceWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            await TestInterfacesAsync(typeof(InterfaceWithGenericParameterEmptyConstructorConstraint<>));
        }

        [TestMethod]
        public async Task TestInterfaceWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            await TestInterfacesAsync(typeof(InterfaceWithGenericParameterGenericParameterConstraint<,>));
        }

        [TestMethod]
        public async Task TestInterfaceWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            await TestInterfacesAsync(typeof(InterfaceWithGenericParameterInterfaceConstraint<>));
        }

        [TestMethod]
        public async Task TestInterfaceWithGenericParameterStructConstraintUsingMonoCecil()
        {
            await TestInterfacesAsync(typeof(InterfaceWithGenericParameterStructConstraint<>));
        }

        [TestMethod]
        public async Task TestInternalInterfaceUsingMonoCecil()
        {
            await TestInterfacesAsync(typeof(InternalInterface));
        }

        [TestMethod]
        public async Task TestPublicInterfaceUsingMonoCecil()
        {
            await TestInterfacesAsync(typeof(PublicInterface));
        }
    }
}
