using CSharpDom.TestTarget.SealedClasses.NestedStaticClasses.NestedStaticClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedStaticClasses_NestedStaticClasses_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithNestedStaticClassWith1AttributeUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedStaticClassWith1Attribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithNestedStaticClassWith1GenericParameterUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedStaticClassWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithNestedStaticClassWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedStaticClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithNestedStaticClassWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedStaticClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithNestedStaticClassWith2GenericParametersUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedStaticClassWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterBaseClassConstraintUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterClassConstraintUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterInterfaceConstraintUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterStructConstraintUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithInternalNestedStaticClassUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithInternalNestedStaticClass));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithPrivateNestedStaticClassUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithPrivateNestedStaticClass));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithProtectedNestedStaticClassUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithProtectedNestedStaticClass));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithProtectedInternalNestedStaticClassUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithProtectedInternalNestedStaticClass));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithPublicNestedStaticClassUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithPublicNestedStaticClass));
        }
    }
}
