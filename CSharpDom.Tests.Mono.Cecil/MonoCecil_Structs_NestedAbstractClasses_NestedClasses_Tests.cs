using CSharpDom.TestTarget.Structs.NestedAbstractClasses.NestedClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedAbstractClasses_NestedClasses_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNestedClassWith1AttributeUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedClassWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNestedClassWith1GenericParameterUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedClassWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNestedClassWith1ImplementedInterfaceUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedClassWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNestedClassWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNestedClassWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNestedClassWith2GenericParametersUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedClassWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNestedClassWith2ImplementedInterfacesUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNestedClassWithBaseClassUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedClassWithBaseClass));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNestedClassWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNestedClassWithGenericParameterClassConstraintUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNestedClassWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNestedClassWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNestedClassWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNestedClassWithGenericParameterStructConstraintUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithInternalNestedClassUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithInternalNestedClass));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithPrivateNestedClassUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithPrivateNestedClass));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithProtectedNestedClassUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedNestedClass));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithProtectedInternalNestedClassUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedInternalNestedClass));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithPublicNestedClassUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithPublicNestedClass));
        }
    }
}
