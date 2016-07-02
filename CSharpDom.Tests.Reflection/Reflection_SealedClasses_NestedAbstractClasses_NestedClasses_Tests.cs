using CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.NestedClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedAbstractClasses_NestedClasses_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithNestedClassWith1AttributeUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNestedClassWith1Attribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithNestedClassWith1GenericParameterUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNestedClassWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithNestedClassWith1ImplementedInterfaceUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNestedClassWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithNestedClassWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNestedClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithNestedClassWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNestedClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithNestedClassWith2GenericParametersUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNestedClassWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithNestedClassWith2ImplementedInterfacesUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNestedClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithNestedClassWithBaseClassUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNestedClassWithBaseClass));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithNestedClassWithGenericParameterBaseClassConstraintUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNestedClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithNestedClassWithGenericParameterClassConstraintUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNestedClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithNestedClassWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNestedClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithNestedClassWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNestedClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithNestedClassWithGenericParameterInterfaceConstraintUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNestedClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithNestedClassWithGenericParameterStructConstraintUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNestedClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithInternalNestedClassUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithInternalNestedClass));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithPrivateNestedClassUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithPrivateNestedClass));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithProtectedNestedClassUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithProtectedNestedClass));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithProtectedInternalNestedClassUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithProtectedInternalNestedClass));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithPublicNestedClassUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithPublicNestedClass));
        }
    }
}
