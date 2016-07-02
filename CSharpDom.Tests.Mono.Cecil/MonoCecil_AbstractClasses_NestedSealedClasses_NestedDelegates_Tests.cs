using CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.NestedDelegates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_NestedSealedClasses_NestedDelegates_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithNestedDelegateWith1AttributeUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNestedDelegateWith1Attribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithNestedDelegateWith1GenericParameterUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNestedDelegateWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithNestedDelegateWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNestedDelegateWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithNestedDelegateWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNestedDelegateWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithNestedDelegateWith2GenericParametersUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNestedDelegateWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithNestedDelegateWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNestedDelegateWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithNestedClassWithNestedDelegateWithGenericParameterClassConstraintUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNestedClassWithNestedDelegateWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithNestedDelegateWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNestedDelegateWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithNestedDelegateWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNestedDelegateWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithNestedDelegateWithGenericParameterStructConstraintUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNestedDelegateWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithInternalNestedDelegateUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithInternalNestedDelegate));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithNestedClassWithNestedDelegateWithParametersWithAttributesUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNestedClassWithNestedDelegateWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithNestedClassWithNestedDelegateWithParametersWithModifiersUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNestedClassWithNestedDelegateWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithPrivateNestedDelegateUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithPrivateNestedDelegate));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithProtectedNestedDelegateUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithProtectedNestedDelegate));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithProtectedInternalNestedDelegateUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithProtectedInternalNestedDelegate));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithPublicNestedDelegateUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithPublicNestedDelegate));
        }
    }
}
