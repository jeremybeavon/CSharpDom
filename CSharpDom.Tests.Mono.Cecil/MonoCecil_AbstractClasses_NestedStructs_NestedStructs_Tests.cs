using CSharpDom.TestTarget.AbstractClasses.NestedStructs.NestedStructs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_NestedStructs_NestedStructs_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithNestedStructWith1AttributeUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithNestedStructWith1Attribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithNestedStructWith1GenericParameterUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithNestedStructWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithNestedStructWith1ImplementedInterfaceUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithNestedStructWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithNestedStructWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithNestedStructWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithNestedStructWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithNestedStructWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithNestedStructWith2GenericParametersUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithNestedStructWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithNestedStructWith2ImplementedInterfacesUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithNestedStructWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithNestedStructWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithNestedStructWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithNestedStructWithGenericParameterClassConstraintUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithNestedStructWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithNestedStructWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithNestedStructWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithNestedStructWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithNestedStructWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithNestedStructWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithNestedStructWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithNestedStructWithGenericParameterStructConstraintUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithNestedStructWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithInternalNestedStructUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithInternalNestedStruct));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithPrivateNestedStructUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithPrivateNestedStruct));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithPublicNestedStructUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithPublicNestedStruct));
        }
    }
}
