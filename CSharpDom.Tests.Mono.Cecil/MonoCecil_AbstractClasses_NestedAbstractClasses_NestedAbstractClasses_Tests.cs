using CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.NestedAbstractClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_NestedAbstractClasses_NestedAbstractClasses_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithNestedAbstractClassWith1AttributeUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNestedAbstractClassWith1Attribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithNestedAbstractClassWith1GenericParameterUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNestedAbstractClassWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithNestedAbstractClassWith1ImplementedInterfaceUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNestedAbstractClassWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithNestedAbstractClassWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNestedAbstractClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithNestedAbstractClassWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNestedAbstractClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithNestedAbstractClassWith2GenericParametersUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNestedAbstractClassWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithNestedAbstractClassWith2ImplementedInterfacesUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNestedAbstractClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithNestedAbstractClassWithBaseClassUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNestedAbstractClassWithBaseClass));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterClassConstraintUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterStructConstraintUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithInternalNestedAbstractClassUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithInternalNestedAbstractClass));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithPrivateNestedAbstractClassUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithPrivateNestedAbstractClass));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithProtectedNestedAbstractClassUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithProtectedNestedAbstractClass));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithProtectedInternalNestedAbstractClassUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithProtectedInternalNestedAbstractClass));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithPublicNestedAbstractClassUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithPublicNestedAbstractClass));
        }
    }
}
