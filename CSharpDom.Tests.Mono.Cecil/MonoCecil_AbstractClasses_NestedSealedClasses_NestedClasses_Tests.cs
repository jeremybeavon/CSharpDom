using CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.NestedClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_NestedSealedClasses_NestedClasses_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithNestedClassWith1AttributeUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNestedClassWith1Attribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithNestedClassWith1GenericParameterUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNestedClassWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithNestedClassWith1ImplementedInterfaceUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNestedClassWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithNestedClassWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNestedClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithNestedClassWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNestedClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithNestedClassWith2GenericParametersUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNestedClassWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithNestedClassWith2ImplementedInterfacesUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNestedClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithNestedClassWithBaseClassUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNestedClassWithBaseClass));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithNestedClassWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNestedClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithNestedClassWithGenericParameterClassConstraintUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNestedClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithNestedClassWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNestedClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithNestedClassWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNestedClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithNestedClassWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNestedClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithNestedClassWithGenericParameterStructConstraintUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNestedClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithInternalNestedClassUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithInternalNestedClass));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithPrivateNestedClassUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithPrivateNestedClass));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithProtectedNestedClassUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithProtectedNestedClass));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithProtectedInternalNestedClassUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithProtectedInternalNestedClass));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithPublicNestedClassUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithPublicNestedClass));
        }
    }
}
