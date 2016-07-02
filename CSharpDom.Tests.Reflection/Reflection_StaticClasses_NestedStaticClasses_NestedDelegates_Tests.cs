using CSharpDom.TestTarget.StaticClasses.NestedStaticClasses.NestedDelegates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_StaticClasses_NestedStaticClasses_NestedDelegates_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithNestedDelegateWith1AttributeUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedDelegateWith1Attribute));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithNestedDelegateWith1GenericParameterUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedDelegateWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithNestedDelegateWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedDelegateWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithNestedDelegateWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedDelegateWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithNestedDelegateWith2GenericParametersUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedDelegateWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithNestedDelegateWithGenericParameterBaseClassConstraintUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedDelegateWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithNestedClassWithNestedDelegateWithGenericParameterClassConstraintUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedClassWithNestedDelegateWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithNestedDelegateWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedDelegateWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithNestedDelegateWithGenericParameterInterfaceConstraintUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedDelegateWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithNestedDelegateWithGenericParameterStructConstraintUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedDelegateWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithInternalNestedDelegateUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithInternalNestedDelegate));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithNestedClassWithNestedDelegateWithParametersWithAttributesUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedClassWithNestedDelegateWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithNestedClassWithNestedDelegateWithParametersWithModifiersUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedClassWithNestedDelegateWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithPrivateNestedDelegateUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithPrivateNestedDelegate));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithProtectedNestedDelegateUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithProtectedNestedDelegate));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithProtectedInternalNestedDelegateUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithProtectedInternalNestedDelegate));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithPublicNestedDelegateUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithPublicNestedDelegate));
        }
    }
}
