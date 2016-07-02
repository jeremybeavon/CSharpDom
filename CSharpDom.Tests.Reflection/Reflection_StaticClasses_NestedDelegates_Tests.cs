using CSharpDom.TestTarget.StaticClasses.NestedDelegates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_StaticClasses_NestedDelegates_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStaticClassWithNestedDelegateWith1AttributeUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedDelegateWith1Attribute));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedDelegateWith1GenericParameterUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedDelegateWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedDelegateWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedDelegateWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedDelegateWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedDelegateWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedDelegateWith2GenericParametersUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedDelegateWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedDelegateWithGenericParameterBaseClassConstraintUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedDelegateWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedDelegateWithGenericParameterClassConstraintUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedDelegateWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedDelegateWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedDelegateWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedDelegateWithGenericParameterInterfaceConstraintUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedDelegateWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedDelegateWithGenericParameterStructConstraintUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedDelegateWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithInternalNestedDelegateUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithInternalNestedDelegate));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedDelegateWithParametersWithAttributesUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedDelegateWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedDelegateWithParametersWithModifiersUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedDelegateWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestStaticClassWithPrivateNestedDelegateUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithPrivateNestedDelegate));
        }

        [TestMethod]
        public async Task TestStaticClassWithProtectedNestedDelegateUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithProtectedNestedDelegate));
        }

        [TestMethod]
        public async Task TestStaticClassWithProtectedInternalNestedDelegateUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithProtectedInternalNestedDelegate));
        }

        [TestMethod]
        public async Task TestStaticClassWithPublicNestedDelegateUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithPublicNestedDelegate));
        }
    }
}
