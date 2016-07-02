using CSharpDom.TestTarget.SealedClasses.NestedClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedClasses_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedClassWith1AttributeUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWith1Attribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWith1GenericParameterUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWith1ImplementedInterfaceUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWith2GenericParametersUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWith2ImplementedInterfacesUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithBaseClassUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithBaseClass));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithGenericParameterBaseClassConstraintUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithGenericParameterClassConstraintUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithGenericParameterInterfaceConstraintUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithGenericParameterStructConstraintUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithInternalNestedClassUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithInternalNestedClass));
        }

        [TestMethod]
        public async Task TestSealedClassWithPrivateNestedClassUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithPrivateNestedClass));
        }

        [TestMethod]
        public async Task TestSealedClassWithProtectedNestedClassUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithProtectedNestedClass));
        }

        [TestMethod]
        public async Task TestSealedClassWithProtectedInternalNestedClassUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithProtectedInternalNestedClass));
        }

        [TestMethod]
        public async Task TestSealedClassWithPublicNestedClassUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithPublicNestedClass));
        }
    }
}
