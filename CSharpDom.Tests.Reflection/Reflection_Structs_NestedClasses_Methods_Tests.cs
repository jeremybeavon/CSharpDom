using CSharpDom.TestTarget.Structs.NestedClasses.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedClasses_Methods_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStructWithNestedClassWithMethodWith1AttributeUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithMethodWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithMethodWith1GenericParameterUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithMethodWith1ReturnAttributeUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithMethodWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithMethodWith2GenericParametersUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithMethodWith2ReturnAttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithMethodWithGenericParameterBaseClassConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithMethodWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithMethodWithGenericParameterClassConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithMethodWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithMethodWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithMethodWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithMethodWithGenericParameterInterfaceConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithMethodWithGenericParameterStructConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithInternalMethodUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithInternalMethod));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNewMethodUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNewMethod));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNewStaticMethodUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNewStaticMethod));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNewVirtualMethodUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNewVirtualMethod));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithOverrideMethodUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithOverrideMethod));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithMethodWithParametersWithAttributesUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithMethodWithParametersWithModifiersUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithPrivateMethodUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithPrivateMethod));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithProtectedMethodUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithProtectedMethod));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithProtectedInternalMethodUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithProtectedInternalMethod));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithPublicMethodUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithPublicMethod));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithSealedOverrideMethodUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithSealedOverrideMethod));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithStaticMethodUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithStaticMethod));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithVirtualMethodUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithVirtualMethod));
        }
    }
}
