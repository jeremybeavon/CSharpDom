using CSharpDom.TestTarget.StaticClasses.NestedClasses.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_StaticClasses_NestedClasses_Methods_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithMethodWith1AttributeUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithMethodWith1Attribute));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithMethodWith1GenericParameterUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithMethodWith1ReturnAttributeUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithMethodWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithMethodWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithMethodWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithMethodWith2GenericParametersUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithMethodWith2ReturnAttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithMethodWith2ReturnAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithMethodWith2ReturnAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithMethodWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithMethodWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithMethodWithGenericParameterClassConstraintUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithMethodWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithMethodWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithMethodWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithMethodWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithMethodWithGenericParameterStructConstraintUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithInternalMethodUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithInternalMethod));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNewMethodUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewMethod));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNewStaticMethodUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewStaticMethod));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNewVirtualMethodUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewVirtualMethod));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithOverrideMethodUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithOverrideMethod));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithMethodWithParametersWithAttributesUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithMethodWithParametersWithModifiersUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithPrivateMethodUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPrivateMethod));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithProtectedMethodUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedMethod));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithProtectedInternalMethodUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedInternalMethod));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithPublicMethodUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPublicMethod));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithSealedOverrideMethodUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithSealedOverrideMethod));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithStaticMethodUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithStaticMethod));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithVirtualMethodUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithVirtualMethod));
        }
    }
}
