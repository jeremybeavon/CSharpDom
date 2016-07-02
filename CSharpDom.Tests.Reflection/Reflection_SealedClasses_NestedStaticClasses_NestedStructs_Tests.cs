using CSharpDom.TestTarget.SealedClasses.NestedStaticClasses.NestedStructs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedStaticClasses_NestedStructs_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithNestedStructWith1AttributeUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedStructWith1Attribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithNestedStructWith1GenericParameterUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedStructWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithNestedStructWith1ImplementedInterfaceUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedStructWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithNestedStructWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedStructWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithNestedStructWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedStructWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithNestedStructWith2GenericParametersUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedStructWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithNestedStructWith2ImplementedInterfacesUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedStructWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithNestedStructWithGenericParameterBaseClassConstraintUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedStructWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithNestedStructWithGenericParameterClassConstraintUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedStructWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithNestedStructWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedStructWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithNestedStructWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedStructWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithNestedStructWithGenericParameterInterfaceConstraintUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedStructWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithNestedStructWithGenericParameterStructConstraintUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithNestedStructWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithInternalNestedStructUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithInternalNestedStruct));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithPrivateNestedStructUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithPrivateNestedStruct));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithProtectedNestedStructUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithProtectedNestedStruct));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithProtectedInternalNestedStructUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithProtectedInternalNestedStruct));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithPublicNestedStructUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithPublicNestedStruct));
        }
    }
}
