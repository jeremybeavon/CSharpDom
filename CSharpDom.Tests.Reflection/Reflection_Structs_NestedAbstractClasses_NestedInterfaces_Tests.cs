using CSharpDom.TestTarget.Structs.NestedAbstractClasses.NestedInterfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedAbstractClasses_NestedInterfaces_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNestedInterfaceWith1AttributeUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedInterfaceWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNestedInterfaceWith1GenericParameterUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedInterfaceWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNestedInterfaceWith1ImplementedInterfaceUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedInterfaceWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNestedInterfaceWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedInterfaceWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNestedInterfaceWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedInterfaceWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNestedInterfaceWith2GenericParametersUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedInterfaceWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNestedInterfaceWith2ImplementedInterfacesUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedInterfaceWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNestedInterfaceWithGenericParameterBaseClassConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedInterfaceWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNestedInterfaceWithGenericParameterClassConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedInterfaceWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNestedInterfaceWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedInterfaceWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNestedInterfaceWithGenericParameterInterfaceConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedInterfaceWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNestedInterfaceWithGenericParameterStructConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedInterfaceWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNestedInternalInterfaceUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedInternalInterface));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNestedPrivateInterfaceUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedPrivateInterface));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNestedProtectedInterfaceUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedProtectedInterface));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNestedProtectedInternalInterfaceUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedProtectedInternalInterface));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithPublicNestedInterfaceUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithPublicNestedInterface));
        }
    }
}
