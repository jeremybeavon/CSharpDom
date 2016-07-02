using CSharpDom.TestTarget.SealedClasses.NestedClasses.NestedDelegates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedClasses_NestedDelegates_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithNestedDelegateWith1AttributeUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNestedDelegateWith1Attribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithNestedDelegateWith1GenericParameterUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNestedDelegateWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithNestedDelegateWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNestedDelegateWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithNestedDelegateWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNestedDelegateWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithNestedDelegateWith2GenericParametersUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNestedDelegateWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithNestedDelegateWithGenericParameterBaseClassConstraintUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNestedDelegateWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithNestedClassWithNestedDelegateWithGenericParameterClassConstraintUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNestedClassWithNestedDelegateWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithNestedDelegateWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNestedDelegateWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithNestedDelegateWithGenericParameterInterfaceConstraintUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNestedDelegateWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithNestedDelegateWithGenericParameterStructConstraintUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNestedDelegateWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithInternalNestedDelegateUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithInternalNestedDelegate));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithNestedClassWithNestedDelegateWithParametersWithAttributesUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNestedClassWithNestedDelegateWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithNestedClassWithNestedDelegateWithParametersWithModifiersUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNestedClassWithNestedDelegateWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithPrivateNestedDelegateUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPrivateNestedDelegate));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithProtectedNestedDelegateUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithProtectedNestedDelegate));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithProtectedInternalNestedDelegateUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithProtectedInternalNestedDelegate));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithPublicNestedDelegateUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPublicNestedDelegate));
        }
    }
}
