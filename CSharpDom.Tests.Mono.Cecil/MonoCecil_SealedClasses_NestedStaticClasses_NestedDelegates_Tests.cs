using CSharpDom.TestTarget.SealedClasses.NestedStaticClasses.NestedDelegates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_SealedClasses_NestedStaticClasses_NestedDelegates_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithNestedDelegateWith1AttributeUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedDelegateWith1Attribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithNestedDelegateWith1GenericParameterUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedDelegateWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithNestedDelegateWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedDelegateWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithNestedDelegateWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedDelegateWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithNestedDelegateWith2GenericParametersUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedDelegateWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithNestedDelegateWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedDelegateWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithNestedClassWithNestedDelegateWithGenericParameterClassConstraintUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedClassWithNestedDelegateWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithNestedDelegateWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedDelegateWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithNestedDelegateWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedDelegateWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithNestedDelegateWithGenericParameterStructConstraintUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedDelegateWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithInternalNestedDelegateUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithInternalNestedDelegate));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithNestedClassWithNestedDelegateWithParametersWithAttributesUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedClassWithNestedDelegateWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithNestedClassWithNestedDelegateWithParametersWithModifiersUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedClassWithNestedDelegateWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithPrivateNestedDelegateUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithPrivateNestedDelegate));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithProtectedNestedDelegateUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithProtectedNestedDelegate));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithProtectedInternalNestedDelegateUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithProtectedInternalNestedDelegate));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithPublicNestedDelegateUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithPublicNestedDelegate));
        }
    }
}
