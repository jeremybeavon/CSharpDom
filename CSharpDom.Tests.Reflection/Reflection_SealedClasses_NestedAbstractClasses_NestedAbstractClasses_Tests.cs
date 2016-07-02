using CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.NestedAbstractClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedAbstractClasses_NestedAbstractClasses_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithNestedAbstractClassWith1AttributeUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNestedAbstractClassWith1Attribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithNestedAbstractClassWith1GenericParameterUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNestedAbstractClassWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithNestedAbstractClassWith1ImplementedInterfaceUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNestedAbstractClassWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithNestedAbstractClassWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNestedAbstractClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithNestedAbstractClassWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNestedAbstractClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithNestedAbstractClassWith2GenericParametersUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNestedAbstractClassWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithNestedAbstractClassWith2ImplementedInterfacesUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNestedAbstractClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithNestedAbstractClassWithBaseClassUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNestedAbstractClassWithBaseClass));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterBaseClassConstraintUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterClassConstraintUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterInterfaceConstraintUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterStructConstraintUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithInternalNestedAbstractClassUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithInternalNestedAbstractClass));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithPrivateNestedAbstractClassUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithPrivateNestedAbstractClass));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithProtectedNestedAbstractClassUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithProtectedNestedAbstractClass));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithProtectedInternalNestedAbstractClassUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithProtectedInternalNestedAbstractClass));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithPublicNestedAbstractClassUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithPublicNestedAbstractClass));
        }
    }
}
