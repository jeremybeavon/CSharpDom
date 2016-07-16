using CSharpDom.TestTarget.Structs.NestedStructs.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedStructs_Methods_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStructWithNestedStructWithMethodWith1AttributeUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithMethodWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithMethodWith1GenericParameterUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithMethodWith1ReturnAttributeUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithMethodWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithMethodWith2GenericParametersUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithMethodWith2ReturnAttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithMethodWithGenericParameterBaseClassConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithMethodWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithMethodWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithMethodWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithMethodWithGenericParameterClassConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithMethodWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithMethodWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithMethodWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithMethodWithGenericParameterInterfaceConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithMethodWithGenericParameterStructConstraintUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithInternalMethodUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithInternalMethod));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithMethodWithParametersWithAttributesUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithMethodWithParametersWithModifiersUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithPrivateMethodUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithPrivateMethod));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithPublicMethodUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithPublicMethod));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithStaticMethodUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithStaticMethod));
        }
    }
}
