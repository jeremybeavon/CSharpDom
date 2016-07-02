using CSharpDom.TestTarget.AbstractClasses.NestedStructs.NestedAbstractClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_NestedStructs_NestedAbstractClasses_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithNestedAbstractClassWith1AttributeUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithNestedAbstractClassWith1Attribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithNestedAbstractClassWith1GenericParameterUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithNestedAbstractClassWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithNestedAbstractClassWith1ImplementedInterfaceUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithNestedAbstractClassWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithNestedAbstractClassWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithNestedAbstractClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithNestedAbstractClassWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithNestedAbstractClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithNestedAbstractClassWith2GenericParametersUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithNestedAbstractClassWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithNestedAbstractClassWith2ImplementedInterfacesUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithNestedAbstractClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithNestedAbstractClassWithBaseClassUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithNestedAbstractClassWithBaseClass));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithNestedAbstractClassWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithNestedAbstractClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithNestedAbstractClassWithGenericParameterClassConstraintUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithNestedAbstractClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithNestedAbstractClassWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithNestedAbstractClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithNestedAbstractClassWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithNestedAbstractClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithNestedAbstractClassWithGenericParameterStructConstraintUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithNestedAbstractClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithInternalNestedAbstractClassUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithInternalNestedAbstractClass));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithPrivateNestedAbstractClassUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithPrivateNestedAbstractClass));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithPublicNestedAbstractClassUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithPublicNestedAbstractClass));
        }
    }
}
