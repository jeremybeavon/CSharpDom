using CSharpDom.TestTarget.AbstractClasses.NestedInterfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_NestedInterfaces_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedInterfaceWith1AttributeUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedInterfaceWith1Attribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedInterfaceWith1GenericParameterUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedInterfaceWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedInterfaceWith1ImplementedInterfaceUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedInterfaceWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedInterfaceWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedInterfaceWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedInterfaceWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedInterfaceWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedInterfaceWith2GenericParametersUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedInterfaceWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedInterfaceWith2ImplementedInterfacesUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedInterfaceWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedInterfaceWithGenericParameterBaseClassConstraintUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedInterfaceWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedInterfaceWithGenericParameterClassConstraintUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedInterfaceWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedInterfaceWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedInterfaceWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedInterfaceWithGenericParameterInterfaceConstraintUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedInterfaceWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedInterfaceWithGenericParameterStructConstraintUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedInterfaceWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedInternalInterfaceUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedInternalInterface));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedPrivateInterfaceUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedPrivateInterface));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedProtectedInterfaceUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedProtectedInterface));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedProtectedInternalInterfaceUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedProtectedInternalInterface));
        }

        [TestMethod]
        public async Task TestAbstractClassWithPublicNestedInterfaceUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithPublicNestedInterface));
        }
    }
}
