using CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_SealedClasses_NestedAbstractClasses_Methods_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithMethodWith1AttributeUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithMethodWith1Attribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithMethodWith1GenericParameterUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithMethodWith1ReturnAttributeUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithMethodWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithMethodWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithMethodWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithMethodWith2GenericParametersUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithMethodWith2ReturnAttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithMethodWith2ReturnAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithMethodWith2ReturnAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithMethodWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithMethodWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithMethodWithGenericParameterClassConstraintUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithMethodWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithMethodWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithMethodWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithMethodWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithMethodWithGenericParameterStructConstraintUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithInternalMethodUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithInternalMethod));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithNewMethodUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNewMethod));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithNewStaticMethodUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNewStaticMethod));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithNewVirtualMethodUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNewVirtualMethod));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithOverrideMethodUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithOverrideMethod));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithMethodWithParametersWithAttributesUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithMethodWithParametersWithModifiersUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithPrivateMethodUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithPrivateMethod));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithProtectedMethodUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithProtectedMethod));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithProtectedInternalMethodUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithProtectedInternalMethod));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithPublicMethodUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithPublicMethod));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithSealedOverrideMethodUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithSealedOverrideMethod));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithStaticMethodUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithStaticMethod));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithVirtualMethodUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithVirtualMethod));
        }
    }
}
