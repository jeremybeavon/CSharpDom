using CSharpDom.TestTarget.AbstractClasses.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_Methods_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithMethodWith1AttributeUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithMethodWith1Attribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithMethodWith1GenericParameterUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestAbstractClassWithMethodWith1ReturnAttributeUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithMethodWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithMethodWith2GenericParametersUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestAbstractClassWithMethodWith2ReturnAttributesIn2AttributeGroupsUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithMethodWithGenericParameterBaseClassConstraintUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithMethodWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestAbstractClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestAbstractClassWithMethodWithGenericParameterClassConstraintUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithMethodWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithMethodWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithMethodWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithMethodWithGenericParameterInterfaceConstraintUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithMethodWithGenericParameterStructConstraintUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithInternalMethodUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithInternalMethod));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNewMethodUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNewMethod));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNewStaticMethodUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNewStaticMethod));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNewVirtualMethodUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNewVirtualMethod));
        }

        [TestMethod]
        public async Task TestAbstractClassWithOverrideMethodUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithOverrideMethod));
        }

        [TestMethod]
        public async Task TestAbstractClassWithMethodWithParametersWithAttributesUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestAbstractClassWithMethodWithParametersWithModifiersUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestAbstractClassWithPrivateMethodUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithPrivateMethod));
        }

        [TestMethod]
        public async Task TestAbstractClassWithProtectedMethodUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithProtectedMethod));
        }

        [TestMethod]
        public async Task TestAbstractClassWithProtectedInternalMethodUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithProtectedInternalMethod));
        }

        [TestMethod]
        public async Task TestAbstractClassWithPublicMethodUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithPublicMethod));
        }

        [TestMethod]
        public async Task TestAbstractClassWithSealedOverrideMethodUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithSealedOverrideMethod));
        }

        [TestMethod]
        public async Task TestAbstractClassWithStaticMethodUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithStaticMethod));
        }

        [TestMethod]
        public async Task TestAbstractClassWithVirtualMethodUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithVirtualMethod));
        }
    }
}
