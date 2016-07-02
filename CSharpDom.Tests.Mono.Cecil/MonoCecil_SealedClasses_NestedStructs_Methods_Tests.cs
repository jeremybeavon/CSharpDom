using CSharpDom.TestTarget.SealedClasses.NestedStructs.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_SealedClasses_NestedStructs_Methods_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithMethodWith1AttributeUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithMethodWith1Attribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithMethodWith1GenericParameterUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithMethodWith1ReturnAttributeUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithMethodWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithMethodWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithMethodWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithMethodWith2GenericParametersUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithMethodWith2ReturnAttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithMethodWith2ReturnAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithMethodWith2ReturnAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithMethodWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithMethodWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithMethodWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithMethodWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithMethodWithGenericParameterClassConstraintUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithMethodWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithMethodWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithMethodWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithMethodWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithMethodWithGenericParameterStructConstraintUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithInternalMethodUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithInternalMethod));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithMethodWithParametersWithAttributesUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithMethodWithParametersWithModifiersUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithPrivateMethodUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithPrivateMethod));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithPublicMethodUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithPublicMethod));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithStaticMethodUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithStaticMethod));
        }
    }
}
