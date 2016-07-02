using CSharpDom.TestTarget.Classes.NestedStructs.NestedDelegates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedStructs_NestedDelegates_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedDelegateWith1AttributeUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedDelegateWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedDelegateWith1GenericParameterUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedDelegateWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedDelegateWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedDelegateWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedDelegateWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedDelegateWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedDelegateWith2GenericParametersUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedDelegateWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedDelegateWithGenericParameterBaseClassConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedDelegateWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedClassWithNestedDelegateWithGenericParameterClassConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedClassWithNestedDelegateWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedDelegateWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedDelegateWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedDelegateWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedDelegateWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedDelegateWithGenericParameterInterfaceConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedDelegateWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedDelegateWithGenericParameterStructConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedDelegateWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithInternalNestedDelegateUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithInternalNestedDelegate));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedClassWithNestedDelegateWithParametersWithAttributesUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedClassWithNestedDelegateWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithNestedClassWithNestedDelegateWithParametersWithModifiersUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithNestedClassWithNestedDelegateWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithPrivateNestedDelegateUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithPrivateNestedDelegate));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithPublicNestedDelegateUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithPublicNestedDelegate));
        }
    }
}
