using CSharpDom.TestTarget.AbstractClasses.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_Methods_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithMethodWith1AttributeUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithMethodWith1Attribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithMethodWith1GenericParameterUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestAbstractClassWithMethodWith1ReturnAttributeUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithMethodWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithMethodWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestAbstractClassWithMethodWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithMethodWith2GenericParametersUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestAbstractClassWithMethodWith2ReturnAttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithMethodWith2ReturnAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestAbstractClassWithMethodWith2ReturnAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithMethodWithGenericParameterBaseAbstractClassConstraintUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithMethodWithGenericParameterBaseAbstractClassConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithMethodWithGenericParameterAbstractClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithMethodWithGenericParameterAbstractClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestAbstractClassWithMethodWithGenericParameterAbstractClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithMethodWithGenericParameterAbstractClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestAbstractClassWithMethodWithGenericParameterAbstractClassConstraintUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithMethodWithGenericParameterAbstractClassConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithMethodWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithMethodWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithMethodWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithMethodWithGenericParameterStructConstraintUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithInternalMethodUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithInternalMethod));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNewMethodUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNewMethod));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNewStaticMethodUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNewStaticMethod));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNewVirtualMethodUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNewVirtualMethod));
        }

        [TestMethod]
        public async Task TestAbstractClassWithOverrideMethodUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithOverrideMethod));
        }

        [TestMethod]
        public async Task TestAbstractClassWithMethodWithParametersWithAttributesUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestAbstractClassWithMethodWithParametersWithModifiersUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestAbstractClassWithPrivateMethodUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithPrivateMethod));
        }

        [TestMethod]
        public async Task TestAbstractClassWithProtectedMethodUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithProtectedMethod));
        }

        [TestMethod]
        public async Task TestAbstractClassWithProtectedInternalMethodUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithProtectedInternalMethod));
        }

        [TestMethod]
        public async Task TestAbstractClassWithPublicMethodUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithPublicMethod));
        }

        [TestMethod]
        public async Task TestAbstractClassWithSealedOverrideMethodUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithSealedOverrideMethod));
        }

        [TestMethod]
        public async Task TestAbstractClassWithStaticMethodUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithStaticMethod));
        }

        [TestMethod]
        public async Task TestAbstractClassWithVirtualMethodUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithVirtualMethod));
        }
    }
}
