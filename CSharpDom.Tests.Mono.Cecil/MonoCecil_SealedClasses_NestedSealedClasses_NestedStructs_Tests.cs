using CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.NestedStructs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_SealedClasses_NestedSealedClasses_NestedStructs_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithNestedStructWith1AttributeUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNestedStructWith1Attribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithNestedStructWith1GenericParameterUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNestedStructWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithNestedStructWith1ImplementedInterfaceUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNestedStructWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithNestedStructWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNestedStructWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithNestedStructWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNestedStructWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithNestedStructWith2GenericParametersUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNestedStructWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithNestedStructWith2ImplementedInterfacesUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNestedStructWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithNestedStructWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNestedStructWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithNestedStructWithGenericParameterClassConstraintUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNestedStructWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithNestedStructWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNestedStructWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithNestedStructWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNestedStructWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithNestedStructWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNestedStructWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithNestedStructWithGenericParameterStructConstraintUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNestedStructWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithInternalNestedStructUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithInternalNestedStruct));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithPrivateNestedStructUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithPrivateNestedStruct));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithProtectedNestedStructUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithProtectedNestedStruct));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithProtectedInternalNestedStructUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithProtectedInternalNestedStruct));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithPublicNestedStructUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithPublicNestedStruct));
        }
    }
}
