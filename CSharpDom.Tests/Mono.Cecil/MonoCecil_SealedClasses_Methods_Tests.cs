using CSharpDom.TestTarget.SealedClasses.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_SealedClasses_Methods_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestSealedClassWithMethodWith1AttributeUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithMethodWith1Attribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithMethodWith1GenericParameterUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestSealedClassWithMethodWith1ReturnAttributeUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithMethodWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithMethodWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithMethodWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithMethodWith2GenericParametersUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestSealedClassWithMethodWith2ReturnAttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithMethodWith2ReturnAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithMethodWith2ReturnAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithMethodWithGenericParameterBaseSealedClassConstraintUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithMethodWithGenericParameterBaseSealedClassConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithMethodWithGenericParameterSealedClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithMethodWithGenericParameterSealedClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestSealedClassWithMethodWithGenericParameterSealedClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithMethodWithGenericParameterSealedClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestSealedClassWithMethodWithGenericParameterSealedClassConstraintUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithMethodWithGenericParameterSealedClassConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithMethodWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithMethodWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithMethodWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithMethodWithGenericParameterStructConstraintUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithInternalMethodUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithInternalMethod));
        }

        [TestMethod]
        public async Task TestSealedClassWithNewMethodUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNewMethod));
        }

        [TestMethod]
        public async Task TestSealedClassWithNewStaticMethodUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNewStaticMethod));
        }

        [TestMethod]
        public async Task TestSealedClassWithOverrideMethodUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithOverrideMethod));
        }

        [TestMethod]
        public async Task TestSealedClassWithMethodWithParametersWithAttributesUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestSealedClassWithMethodWithParametersWithModifiersUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestSealedClassWithPrivateMethodUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithPrivateMethod));
        }

        [TestMethod]
        public async Task TestSealedClassWithProtectedMethodUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithProtectedMethod));
        }

        [TestMethod]
        public async Task TestSealedClassWithProtectedInternalMethodUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithProtectedInternalMethod));
        }

        [TestMethod]
        public async Task TestSealedClassWithPublicMethodUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithPublicMethod));
        }

        [TestMethod]
        public async Task TestSealedClassWithSealedOverrideMethodUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithSealedOverrideMethod));
        }

        [TestMethod]
        public async Task TestSealedClassWithStaticMethodUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithStaticMethod));
        }
    }
}
