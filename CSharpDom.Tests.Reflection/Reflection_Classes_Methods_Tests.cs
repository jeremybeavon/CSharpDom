using CSharpDom.TestTarget.Classes.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_Methods_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithMethodWith1AttributeUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithMethodWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithMethodWith1GenericParameterUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestClassWithMethodWith1ReturnAttributeUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public async Task TestClassWithMethodWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithMethodWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithMethodWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithMethodWith2GenericParametersUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestClassWithMethodWith2ReturnAttributesIn1AttributeGroupUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithMethodWith2ReturnAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithMethodWith2ReturnAttributesIn2AttributeGroupsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithMethodWithGenericParameterBaseClassConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithMethodWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithMethodWithGenericParameterClassConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithMethodWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithMethodWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestClassWithMethodWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestClassWithMethodWithGenericParameterInterfaceConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestClassWithMethodWithGenericParameterStructConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestClassWithInternalMethodUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithInternalMethod));
        }

        [TestMethod]
        public async Task TestClassWithNewMethodUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNewMethod));
        }

        [TestMethod]
        public async Task TestClassWithNewStaticMethodUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNewStaticMethod));
        }

        [TestMethod]
        public async Task TestClassWithNewVirtualMethodUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNewVirtualMethod));
        }

        [TestMethod]
        public async Task TestClassWithOverrideMethodUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithOverrideMethod));
        }

        [TestMethod]
        public async Task TestClassWithMethodWithParametersWithAttributesUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestClassWithMethodWithParametersWithModifiersUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestClassWithPrivateMethodUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithPrivateMethod));
        }

        [TestMethod]
        public async Task TestClassWithProtectedMethodUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithProtectedMethod));
        }

        [TestMethod]
        public async Task TestClassWithProtectedInternalMethodUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithProtectedInternalMethod));
        }

        [TestMethod]
        public async Task TestClassWithPublicMethodUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithPublicMethod));
        }

        [TestMethod]
        public async Task TestClassWithSealedOverrideMethodUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithSealedOverrideMethod));
        }

        [TestMethod]
        public async Task TestClassWithStaticMethodUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithStaticMethod));
        }

        [TestMethod]
        public async Task TestClassWithVirtualMethodUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithVirtualMethod));
        }
    }
}
