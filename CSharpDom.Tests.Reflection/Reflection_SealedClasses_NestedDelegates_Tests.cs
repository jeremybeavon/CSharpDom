using CSharpDom.TestTarget.SealedClasses.NestedDelegates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedDelegates_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedDelegateWith1AttributeUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedDelegateWith1Attribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedDelegateWith1GenericParameterUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedDelegateWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedDelegateWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedDelegateWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedDelegateWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedDelegateWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedDelegateWith2GenericParametersUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedDelegateWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedDelegateWithGenericParameterBaseClassConstraintUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedDelegateWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedDelegateWithGenericParameterClassConstraintUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedDelegateWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedDelegateWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedDelegateWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedDelegateWithGenericParameterInterfaceConstraintUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedDelegateWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedDelegateWithGenericParameterStructConstraintUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedDelegateWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithInternalNestedDelegateUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithInternalNestedDelegate));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedDelegateWithParametersWithAttributesUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedDelegateWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedDelegateWithParametersWithModifiersUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedDelegateWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestSealedClassWithPrivateNestedDelegateUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithPrivateNestedDelegate));
        }

        [TestMethod]
        public async Task TestSealedClassWithProtectedNestedDelegateUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithProtectedNestedDelegate));
        }

        [TestMethod]
        public async Task TestSealedClassWithProtectedInternalNestedDelegateUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithProtectedInternalNestedDelegate));
        }

        [TestMethod]
        public async Task TestSealedClassWithPublicNestedDelegateUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithPublicNestedDelegate));
        }
    }
}
