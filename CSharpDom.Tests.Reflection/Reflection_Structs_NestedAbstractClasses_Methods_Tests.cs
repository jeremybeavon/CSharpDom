using CSharpDom.TestTarget.Structs.NestedAbstractClasses.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedAbstractClasses_Methods_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithMethodWith1AttributeUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithMethodWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithMethodWith1GenericParameterUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithMethodWith1ReturnAttributeUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithMethodWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithMethodWith2GenericParametersUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithMethodWith2ReturnAttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithMethodWithGenericParameterBaseClassConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithMethodWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithMethodWithGenericParameterClassConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithMethodWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithMethodWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithMethodWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithMethodWithGenericParameterInterfaceConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithMethodWithGenericParameterStructConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithInternalMethodUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithInternalMethod));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNewMethodUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNewMethod));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNewStaticMethodUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNewStaticMethod));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNewVirtualMethodUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNewVirtualMethod));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithOverrideMethodUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithOverrideMethod));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithMethodWithParametersWithAttributesUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithMethodWithParametersWithModifiersUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithPrivateMethodUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithPrivateMethod));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithProtectedMethodUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedMethod));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithProtectedInternalMethodUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedInternalMethod));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithPublicMethodUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithPublicMethod));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithSealedOverrideMethodUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithSealedOverrideMethod));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithStaticMethodUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithStaticMethod));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithVirtualMethodUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithVirtualMethod));
        }
    }
}
