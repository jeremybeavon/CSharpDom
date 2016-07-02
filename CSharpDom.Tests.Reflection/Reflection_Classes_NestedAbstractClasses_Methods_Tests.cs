using CSharpDom.TestTarget.Classes.NestedAbstractClasses.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedAbstractClasses_Methods_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithMethodWith1AttributeUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithMethodWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithMethodWith1GenericParameterUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithMethodWith1ReturnAttributeUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithMethodWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithMethodWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithMethodWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithMethodWith2GenericParametersUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithMethodWith2ReturnAttributesIn1AttributeGroupUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithMethodWith2ReturnAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithMethodWith2ReturnAttributesIn2AttributeGroupsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithMethodWithGenericParameterBaseClassConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithMethodWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithMethodWithGenericParameterClassConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithMethodWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithMethodWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithMethodWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithMethodWithGenericParameterInterfaceConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithMethodWithGenericParameterStructConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithInternalMethodUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithInternalMethod));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNewMethodUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewMethod));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNewStaticMethodUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewStaticMethod));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNewVirtualMethodUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewVirtualMethod));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithOverrideMethodUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithOverrideMethod));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithMethodWithParametersWithAttributesUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithMethodWithParametersWithModifiersUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithPrivateMethodUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithPrivateMethod));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithProtectedMethodUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedMethod));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithProtectedInternalMethodUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedInternalMethod));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithPublicMethodUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithPublicMethod));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithSealedOverrideMethodUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithSealedOverrideMethod));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithStaticMethodUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithStaticMethod));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithVirtualMethodUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithVirtualMethod));
        }
    }
}
