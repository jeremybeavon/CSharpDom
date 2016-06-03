using CSharpDom.TestTarget.Classes.NestedDelegates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedDelegates_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithNestedDelegateWith1AttributeUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedDelegateWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedDelegateWith1GenericParameterUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedDelegateWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestClassWithNestedDelegateWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedDelegateWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedDelegateWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedDelegateWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedDelegateWith2GenericParametersUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedDelegateWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestClassWithNestedDelegateWithGenericParameterBaseClassConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedDelegateWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithNestedDelegateWithGenericParameterClassConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedDelegateWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedDelegateWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedDelegateWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedDelegateWithGenericParameterInterfaceConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedDelegateWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedDelegateWithGenericParameterStructConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedDelegateWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestClassWithProtectedNestedDelegateUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithProtectedNestedDelegate));
        }

        [TestMethod]
        public async Task TestClassWithPrivateNestedDelegateUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithPrivateNestedDelegate));
        }

        [TestMethod]
        public async Task TestClassWithProtectedInternalNestedDelegateUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithProtectedInternalNestedDelegate));
        }

        [TestMethod]
        public async Task TestClassWithInternalNestedDelegateUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithInternalNestedDelegate));
        }

        [TestMethod]
        public async Task TestClassWithNestedDelegateWithParametersWithAttributesUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedDelegateWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestClassWithNestedDelegateWithParametersWithModifiersUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedDelegateWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestClassWithPublicNestedDelegateUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithPublicNestedDelegate));
        }
    }
}
