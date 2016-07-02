using CSharpDom.TestTarget.AbstractClasses.NestedDelegates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_NestedDelegates_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedDelegateWith1AttributeUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedDelegateWith1Attribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedDelegateWith1GenericParameterUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedDelegateWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedDelegateWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedDelegateWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedDelegateWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedDelegateWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedDelegateWith2GenericParametersUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedDelegateWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedDelegateWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedDelegateWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedDelegateWithGenericParameterClassConstraintUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedDelegateWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedDelegateWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedDelegateWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedDelegateWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedDelegateWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedDelegateWithGenericParameterStructConstraintUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedDelegateWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithInternalNestedDelegateUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithInternalNestedDelegate));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedDelegateWithParametersWithAttributesUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedDelegateWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedDelegateWithParametersWithModifiersUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedDelegateWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestAbstractClassWithPrivateNestedDelegateUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithPrivateNestedDelegate));
        }

        [TestMethod]
        public async Task TestAbstractClassWithProtectedNestedDelegateUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithProtectedNestedDelegate));
        }

        [TestMethod]
        public async Task TestAbstractClassWithProtectedInternalNestedDelegateUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithProtectedInternalNestedDelegate));
        }

        [TestMethod]
        public async Task TestAbstractClassWithPublicNestedDelegateUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithPublicNestedDelegate));
        }
    }
}
