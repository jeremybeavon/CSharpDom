using CSharpDom.TestTarget.SealedClasses.NestedStructs.NestedDelegates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedStructs_NestedDelegates_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithNestedDelegateWith1AttributeUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedDelegateWith1Attribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithNestedDelegateWith1GenericParameterUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedDelegateWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithNestedDelegateWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedDelegateWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithNestedDelegateWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedDelegateWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithNestedDelegateWith2GenericParametersUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedDelegateWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithNestedDelegateWithGenericParameterBaseClassConstraintUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedDelegateWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithNestedClassWithNestedDelegateWithGenericParameterClassConstraintUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedClassWithNestedDelegateWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithNestedDelegateWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedDelegateWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithNestedDelegateWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedDelegateWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithNestedDelegateWithGenericParameterInterfaceConstraintUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedDelegateWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithNestedDelegateWithGenericParameterStructConstraintUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedDelegateWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithInternalNestedDelegateUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithInternalNestedDelegate));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithNestedClassWithNestedDelegateWithParametersWithAttributesUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedClassWithNestedDelegateWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithNestedClassWithNestedDelegateWithParametersWithModifiersUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedClassWithNestedDelegateWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithPrivateNestedDelegateUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithPrivateNestedDelegate));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithPublicNestedDelegateUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithPublicNestedDelegate));
        }
    }
}
