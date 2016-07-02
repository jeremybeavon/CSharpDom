using CSharpDom.TestTarget.AbstractClasses.NestedClasses.NestedSealedClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_NestedClasses_NestedSealedClasses_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithNestedSealedClassWith1AttributeUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNestedSealedClassWith1Attribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithNestedSealedClassWith1GenericParameterUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNestedSealedClassWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithNestedSealedClassWith1ImplementedInterfaceUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNestedSealedClassWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithNestedSealedClassWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNestedSealedClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithNestedSealedClassWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNestedSealedClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithNestedSealedClassWith2GenericParametersUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNestedSealedClassWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithNestedSealedClassWith2ImplementedInterfacesUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNestedSealedClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithNestedSealedClassWithBaseClassUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNestedSealedClassWithBaseClass));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithNestedSealedClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNestedSealedClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithNestedSealedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNestedSealedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithNestedSealedClassWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNestedSealedClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithNestedSealedClassWithGenericParameterClassConstraintUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNestedSealedClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithNestedSealedClassWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNestedSealedClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithNestedSealedClassWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNestedSealedClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithNestedSealedClassWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNestedSealedClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithNestedSealedClassWithGenericParameterStructConstraintUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNestedSealedClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithInternalNestedSealedClassUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithInternalNestedSealedClass));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithPrivateNestedSealedClassUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithPrivateNestedSealedClass));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithProtectedNestedSealedClassUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithProtectedNestedSealedClass));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithProtectedInternalNestedSealedClassUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithProtectedInternalNestedSealedClass));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithPublicNestedSealedClassUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithPublicNestedSealedClass));
        }
    }
}
