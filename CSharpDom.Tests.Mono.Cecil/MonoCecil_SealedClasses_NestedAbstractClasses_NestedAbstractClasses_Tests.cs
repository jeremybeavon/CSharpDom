using CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.NestedAbstractClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_SealedClasses_NestedAbstractClasses_NestedAbstractClasses_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithNestedAbstractClassWith1AttributeUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNestedAbstractClassWith1Attribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithNestedAbstractClassWith1GenericParameterUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNestedAbstractClassWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithNestedAbstractClassWith1ImplementedInterfaceUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNestedAbstractClassWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithNestedAbstractClassWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNestedAbstractClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithNestedAbstractClassWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNestedAbstractClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithNestedAbstractClassWith2GenericParametersUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNestedAbstractClassWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithNestedAbstractClassWith2ImplementedInterfacesUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNestedAbstractClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithNestedAbstractClassWithBaseClassUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNestedAbstractClassWithBaseClass));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterClassConstraintUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterStructConstraintUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithInternalNestedAbstractClassUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithInternalNestedAbstractClass));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithPrivateNestedAbstractClassUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithPrivateNestedAbstractClass));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithProtectedNestedAbstractClassUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithProtectedNestedAbstractClass));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithProtectedInternalNestedAbstractClassUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithProtectedInternalNestedAbstractClass));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithPublicNestedAbstractClassUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithPublicNestedAbstractClass));
        }
    }
}
