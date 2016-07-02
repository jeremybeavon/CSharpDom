using CSharpDom.TestTarget.Classes.NestedClasses.NestedDelegates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedClasses_NestedDelegates_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedDelegateWith1AttributeUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedDelegateWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedDelegateWith1GenericParameterUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedDelegateWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedDelegateWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedDelegateWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedDelegateWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedDelegateWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedDelegateWith2GenericParametersUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedDelegateWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedDelegateWithGenericParameterBaseClassConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedDelegateWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedClassWithNestedDelegateWithGenericParameterClassConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedClassWithNestedDelegateWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedDelegateWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedDelegateWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedDelegateWithGenericParameterInterfaceConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedDelegateWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedDelegateWithGenericParameterStructConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedDelegateWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithInternalNestedDelegateUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithInternalNestedDelegate));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedClassWithNestedDelegateWithParametersWithAttributesUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedClassWithNestedDelegateWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedClassWithNestedDelegateWithParametersWithModifiersUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedClassWithNestedDelegateWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithPrivateNestedDelegateUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithPrivateNestedDelegate));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithProtectedNestedDelegateUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithProtectedNestedDelegate));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithProtectedInternalNestedDelegateUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithProtectedInternalNestedDelegate));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithPublicNestedDelegateUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithPublicNestedDelegate));
        }
    }
}
