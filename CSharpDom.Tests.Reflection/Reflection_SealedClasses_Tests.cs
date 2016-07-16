using CSharpDom.TestTarget.SealedClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestSealedClassWith1AttributeUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWith1Attribute));
        }

        [TestMethod]
        public async Task TestSealedClassWith1GenericParameterUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWith1GenericParameter<>));
        }

        [TestMethod]
        public async Task TestSealedClassWith1ImplementedInterfaceUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestSealedClassWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWith2GenericParametersUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWith2GenericParameters<,>));
        }

        [TestMethod]
        public async Task TestSealedClassWith2ImplementedInterfacesUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestSealedClassWithBaseClassUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithBaseClass));
        }

        [TestMethod]
        public async Task TestSealedClassWithGenericParameterBaseClassConstraintUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithGenericParameterBaseClassConstraint<>));
        }

        [TestMethod]
        public async Task TestSealedClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithGenericParameterClassAndEmptyConstructorConstraints<>));
        }

        [TestMethod]
        public async Task TestSealedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints<>));
        }

        [TestMethod]
        public async Task TestSealedClassWithGenericParameterClassConstraintUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithGenericParameterClassConstraint<>));
        }

        [TestMethod]
        public async Task TestSealedClassWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithGenericParameterEmptyConstructorConstraint<>));
        }

        [TestMethod]
        public async Task TestSealedClassWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithGenericParameterGenericParameterConstraint<,>));
        }

        [TestMethod]
        public async Task TestSealedClassWithGenericParameterInterfaceConstraintUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithGenericParameterInterfaceConstraint<>));
        }

        [TestMethod]
        public async Task TestSealedClassWithGenericParameterStructConstraintUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithGenericParameterStructConstraint<>));
        }

        [TestMethod]
        public async Task TestInternalSealedClassUsingReflection()
        {
            await TestSealedClassAsync(typeof(InternalSealedClass));
        }

        [TestMethod]
        public async Task TestPublicSealedClassUsingReflection()
        {
            await TestSealedClassAsync(typeof(PublicSealedClass));
        }
    }
}
