using CSharpDom.TestTarget.Classes.NestedStructs.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedStructs_Methods_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithNestedStructWithMethodWith1AttributeUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithMethodWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithMethodWith1GenericParameterUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithMethodWith1ReturnAttributeUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithMethodWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithMethodWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithMethodWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithMethodWith2GenericParametersUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithMethodWith2ReturnAttributesIn1AttributeGroupUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithMethodWith2ReturnAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithMethodWith2ReturnAttributesIn2AttributeGroupsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithMethodWithGenericParameterBaseClassConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithMethodWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithMethodWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithMethodWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithMethodWithGenericParameterClassConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithMethodWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithMethodWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithMethodWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithMethodWithGenericParameterInterfaceConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithMethodWithGenericParameterStructConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithInternalMethodUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithInternalMethod));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithMethodWithParametersWithAttributesUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithMethodWithParametersWithModifiersUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithPrivateMethodUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithPrivateMethod));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithPublicMethodUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithPublicMethod));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithStaticMethodUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithStaticMethod));
        }
    }
}
