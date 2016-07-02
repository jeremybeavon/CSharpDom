using CSharpDom.TestTarget.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Interfaces_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestInterfaceWith1AttributeUsingReflection()
        {
            await TestInterfacesAsync(typeof(InterfaceWith1Attribute));
        }

        [TestMethod]
        public async Task TestInterfaceWith1GenericParameterUsingReflection()
        {
            await TestInterfacesAsync(typeof(InterfaceWith1GenericParameter<>));
        }

        [TestMethod]
        public async Task TestInterfaceWith1ImplementedInterfaceUsingReflection()
        {
            await TestInterfacesAsync(typeof(InterfaceWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestInterfaceWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestInterfacesAsync(typeof(InterfaceWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestInterfaceWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestInterfacesAsync(typeof(InterfaceWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestInterfaceWith2GenericParametersUsingReflection()
        {
            await TestInterfacesAsync(typeof(InterfaceWith2GenericParameters<,>));
        }

        [TestMethod]
        public async Task TestInterfaceWith2ImplementedInterfacesUsingReflection()
        {
            await TestInterfacesAsync(typeof(InterfaceWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestInterfaceWithGenericParameterBaseClassConstraintUsingReflection()
        {
            await TestInterfacesAsync(typeof(InterfaceWithGenericParameterBaseClassConstraint<>));
        }

        [TestMethod]
        public async Task TestInterfaceWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestInterfacesAsync(typeof(InterfaceWithGenericParameterClassAndEmptyConstructorConstraints<>));
        }

        [TestMethod]
        public async Task TestInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestInterfacesAsync(typeof(InterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints<>));
        }

        [TestMethod]
        public async Task TestInterfaceWithGenericParameterClassConstraintUsingReflection()
        {
            await TestInterfacesAsync(typeof(InterfaceWithGenericParameterClassConstraint<>));
        }

        [TestMethod]
        public async Task TestInterfaceWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            await TestInterfacesAsync(typeof(InterfaceWithGenericParameterEmptyConstructorConstraint<>));
        }

        [TestMethod]
        public async Task TestInterfaceWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            await TestInterfacesAsync(typeof(InterfaceWithGenericParameterGenericParameterConstraint<,>));
        }

        [TestMethod]
        public async Task TestInterfaceWithGenericParameterInterfaceConstraintUsingReflection()
        {
            await TestInterfacesAsync(typeof(InterfaceWithGenericParameterInterfaceConstraint<>));
        }

        [TestMethod]
        public async Task TestInterfaceWithGenericParameterStructConstraintUsingReflection()
        {
            await TestInterfacesAsync(typeof(InterfaceWithGenericParameterStructConstraint<>));
        }

        [TestMethod]
        public async Task TestInternalInterfaceUsingReflection()
        {
            await TestInterfacesAsync(typeof(InternalInterface));
        }

        [TestMethod]
        public async Task TestPublicInterfaceUsingReflection()
        {
            await TestInterfacesAsync(typeof(PublicInterface));
        }
    }
}
