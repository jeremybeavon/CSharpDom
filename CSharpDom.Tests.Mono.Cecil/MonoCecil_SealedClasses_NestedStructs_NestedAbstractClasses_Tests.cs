using CSharpDom.TestTarget.SealedClasses.NestedStructs.NestedAbstractClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_SealedClasses_NestedStructs_NestedAbstractClasses_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithNestedAbstractClassWith1AttributeUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedAbstractClassWith1Attribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithNestedAbstractClassWith1GenericParameterUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedAbstractClassWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithNestedAbstractClassWith1ImplementedInterfaceUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedAbstractClassWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithNestedAbstractClassWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedAbstractClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithNestedAbstractClassWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedAbstractClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithNestedAbstractClassWith2GenericParametersUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedAbstractClassWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithNestedAbstractClassWith2ImplementedInterfacesUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedAbstractClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithNestedAbstractClassWithBaseClassUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedAbstractClassWithBaseClass));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithNestedAbstractClassWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedAbstractClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithNestedAbstractClassWithGenericParameterClassConstraintUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedAbstractClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithNestedAbstractClassWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedAbstractClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithNestedAbstractClassWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedAbstractClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithNestedAbstractClassWithGenericParameterStructConstraintUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedAbstractClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithInternalNestedAbstractClassUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithInternalNestedAbstractClass));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithPrivateNestedAbstractClassUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithPrivateNestedAbstractClass));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithPublicNestedAbstractClassUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithPublicNestedAbstractClass));
        }
    }
}
