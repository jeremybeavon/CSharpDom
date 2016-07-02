using CSharpDom.TestTarget.Structs.NestedClasses.NestedAbstractClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedClasses_NestedAbstractClasses_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedAbstractClassWith1AttributeUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedAbstractClassWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedAbstractClassWith1GenericParameterUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedAbstractClassWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedAbstractClassWith1ImplementedInterfaceUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedAbstractClassWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedAbstractClassWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedAbstractClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedAbstractClassWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedAbstractClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedAbstractClassWith2GenericParametersUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedAbstractClassWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedAbstractClassWith2ImplementedInterfacesUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedAbstractClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedAbstractClassWithBaseClassUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedAbstractClassWithBaseClass));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedAbstractClassWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedAbstractClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedAbstractClassWithGenericParameterClassConstraintUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedAbstractClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedAbstractClassWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedAbstractClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedAbstractClassWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedAbstractClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedAbstractClassWithGenericParameterStructConstraintUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedAbstractClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithInternalNestedAbstractClassUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithInternalNestedAbstractClass));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithPrivateNestedAbstractClassUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithPrivateNestedAbstractClass));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithProtectedNestedAbstractClassUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithProtectedNestedAbstractClass));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithProtectedInternalNestedAbstractClassUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithProtectedInternalNestedAbstractClass));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithPublicNestedAbstractClassUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithPublicNestedAbstractClass));
        }
    }
}
