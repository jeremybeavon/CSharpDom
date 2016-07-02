using CSharpDom.TestTarget.SealedClasses.NestedStaticClasses.NestedDelegates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedStaticClasses_NestedDelegates_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithNestedDelegateWith1AttributeUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedDelegateWith1Attribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithNestedDelegateWith1GenericParameterUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedDelegateWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithNestedDelegateWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedDelegateWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithNestedDelegateWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedDelegateWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithNestedDelegateWith2GenericParametersUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedDelegateWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithNestedDelegateWithGenericParameterBaseClassConstraintUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedDelegateWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithNestedClassWithNestedDelegateWithGenericParameterClassConstraintUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedClassWithNestedDelegateWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithNestedDelegateWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedDelegateWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithNestedDelegateWithGenericParameterInterfaceConstraintUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedDelegateWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithNestedDelegateWithGenericParameterStructConstraintUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedDelegateWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithInternalNestedDelegateUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithInternalNestedDelegate));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithNestedClassWithNestedDelegateWithParametersWithAttributesUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedClassWithNestedDelegateWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithNestedClassWithNestedDelegateWithParametersWithModifiersUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedClassWithNestedDelegateWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithPrivateNestedDelegateUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithPrivateNestedDelegate));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithProtectedNestedDelegateUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithProtectedNestedDelegate));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithProtectedInternalNestedDelegateUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithProtectedInternalNestedDelegate));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithPublicNestedDelegateUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithPublicNestedDelegate));
        }
    }
}
