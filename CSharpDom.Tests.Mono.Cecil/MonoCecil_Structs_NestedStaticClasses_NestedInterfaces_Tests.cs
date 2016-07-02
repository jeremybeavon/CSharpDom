using CSharpDom.TestTarget.Structs.NestedStaticClasses.NestedInterfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedStaticClasses_NestedInterfaces_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedInterfaceWith1AttributeUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedInterfaceWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedInterfaceWith1GenericParameterUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedInterfaceWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedInterfaceWith1ImplementedInterfaceUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedInterfaceWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedInterfaceWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedInterfaceWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedInterfaceWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedInterfaceWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedInterfaceWith2GenericParametersUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedInterfaceWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedInterfaceWith2ImplementedInterfacesUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedInterfaceWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedInterfaceWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedInterfaceWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedInterfaceWithGenericParameterClassConstraintUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedInterfaceWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedInterfaceWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedInterfaceWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedInterfaceWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedInterfaceWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedInterfaceWithGenericParameterStructConstraintUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedInterfaceWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedInternalInterfaceUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedInternalInterface));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedPrivateInterfaceUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedPrivateInterface));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedProtectedInterfaceUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedProtectedInterface));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedProtectedInternalInterfaceUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedProtectedInternalInterface));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithPublicNestedInterfaceUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithPublicNestedInterface));
        }
    }
}
