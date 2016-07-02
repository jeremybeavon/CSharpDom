using CSharpDom.TestTarget.Structs.NestedStructs.NestedAbstractClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedStructs_NestedAbstractClasses_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestStructWithNestedStructWithNestedAbstractClassWith1AttributeUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithNestedAbstractClassWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithNestedAbstractClassWith1GenericParameterUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithNestedAbstractClassWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithNestedAbstractClassWith1ImplementedInterfaceUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithNestedAbstractClassWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithNestedAbstractClassWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithNestedAbstractClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithNestedAbstractClassWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithNestedAbstractClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithNestedAbstractClassWith2GenericParametersUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithNestedAbstractClassWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithNestedAbstractClassWith2ImplementedInterfacesUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithNestedAbstractClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithNestedAbstractClassWithBaseClassUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithNestedAbstractClassWithBaseClass));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithNestedAbstractClassWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithNestedAbstractClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithNestedAbstractClassWithGenericParameterClassConstraintUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithNestedAbstractClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithNestedAbstractClassWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithNestedAbstractClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithNestedAbstractClassWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithNestedAbstractClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithNestedAbstractClassWithGenericParameterStructConstraintUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithNestedAbstractClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithInternalNestedAbstractClassUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithInternalNestedAbstractClass));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithPrivateNestedAbstractClassUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithPrivateNestedAbstractClass));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithPublicNestedAbstractClassUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithPublicNestedAbstractClass));
        }
    }
}
