using CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.NestedClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_SealedClasses_NestedSealedClasses_NestedClasses_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithNestedClassWith1AttributeUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNestedClassWith1Attribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithNestedClassWith1GenericParameterUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNestedClassWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithNestedClassWith1ImplementedInterfaceUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNestedClassWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithNestedClassWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNestedClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithNestedClassWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNestedClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithNestedClassWith2GenericParametersUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNestedClassWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithNestedClassWith2ImplementedInterfacesUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNestedClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithNestedClassWithBaseClassUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNestedClassWithBaseClass));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithNestedClassWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNestedClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithNestedClassWithGenericParameterClassConstraintUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNestedClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithNestedClassWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNestedClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithNestedClassWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNestedClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithNestedClassWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNestedClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithNestedClassWithGenericParameterStructConstraintUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNestedClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithInternalNestedClassUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithInternalNestedClass));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithPrivateNestedClassUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithPrivateNestedClass));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithProtectedNestedClassUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithProtectedNestedClass));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithProtectedInternalNestedClassUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithProtectedInternalNestedClass));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithPublicNestedClassUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithPublicNestedClass));
        }
    }
}
