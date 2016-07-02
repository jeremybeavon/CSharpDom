using CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.NestedStructs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedSealedClasses_NestedStructs_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithNestedStructWith1AttributeUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNestedStructWith1Attribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithNestedStructWith1GenericParameterUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNestedStructWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithNestedStructWith1ImplementedInterfaceUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNestedStructWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithNestedStructWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNestedStructWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithNestedStructWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNestedStructWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithNestedStructWith2GenericParametersUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNestedStructWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithNestedStructWith2ImplementedInterfacesUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNestedStructWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithNestedStructWithGenericParameterBaseClassConstraintUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNestedStructWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithNestedStructWithGenericParameterClassConstraintUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNestedStructWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithNestedStructWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNestedStructWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithNestedStructWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNestedStructWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithNestedStructWithGenericParameterInterfaceConstraintUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNestedStructWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithNestedStructWithGenericParameterStructConstraintUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNestedStructWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithInternalNestedStructUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithInternalNestedStruct));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithPrivateNestedStructUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithPrivateNestedStruct));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithProtectedNestedStructUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithProtectedNestedStruct));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithProtectedInternalNestedStructUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithProtectedInternalNestedStruct));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithPublicNestedStructUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithPublicNestedStruct));
        }
    }
}
