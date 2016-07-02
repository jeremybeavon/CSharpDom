using CSharpDom.TestTarget.Delegates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Delegates_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestDelegateWith1AttributeUsingReflection()
        {
            await TestDelegatesAsync(typeof(DelegateWith1Attribute));
        }

        [TestMethod]
        public async Task TestDelegateWith1GenericParameterUsingReflection()
        {
            await TestDelegatesAsync(typeof(DelegateWith1GenericParameter<>));
        }

        [TestMethod]
        public async Task TestDelegateWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestDelegatesAsync(typeof(DelegateWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestDelegateWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestDelegatesAsync(typeof(DelegateWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestDelegateWith2GenericParametersUsingReflection()
        {
            await TestDelegatesAsync(typeof(DelegateWith2GenericParameters<,>));
        }

        [TestMethod]
        public async Task TestDelegateWithGenericParameterBaseClassConstraintUsingReflection()
        {
            await TestDelegatesAsync(typeof(DelegateWithGenericParameterBaseClassConstraint<>));
        }

        [TestMethod]
        public async Task TestDelegateWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestDelegatesAsync(typeof(DelegateWithGenericParameterClassAndEmptyConstructorConstraints<>));
        }

        [TestMethod]
        public async Task TestDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestDelegatesAsync(typeof(DelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints<>));
        }

        [TestMethod]
        public async Task TestDelegateWithGenericParameterClassConstraintUsingReflection()
        {
            await TestDelegatesAsync(typeof(DelegateWithGenericParameterClassConstraint<>));
        }

        [TestMethod]
        public async Task TestDelegateWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            await TestDelegatesAsync(typeof(DelegateWithGenericParameterEmptyConstructorConstraint<>));
        }

        [TestMethod]
        public async Task TestDelegateWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            await TestDelegatesAsync(typeof(DelegateWithGenericParameterGenericParameterConstraint<,>));
        }

        [TestMethod]
        public async Task TestDelegateWithGenericParameterInterfaceConstraintUsingReflection()
        {
            await TestDelegatesAsync(typeof(DelegateWithGenericParameterInterfaceConstraint<>));
        }

        [TestMethod]
        public async Task TestDelegateWithGenericParameterStructConstraintUsingReflection()
        {
            await TestDelegatesAsync(typeof(DelegateWithGenericParameterStructConstraint<>));
        }

        [TestMethod]
        public async Task TestInternalDelegateUsingReflection()
        {
            await TestDelegatesAsync(typeof(InternalDelegate));
        }

        [TestMethod]
        public async Task TestDelegateWithParametersWithAttributesUsingReflection()
        {
            await TestDelegatesAsync(typeof(DelegateWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestDelegateWithParametersWithModifiersUsingReflection()
        {
            await TestDelegatesAsync(typeof(DelegateWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestPublicDelegateUsingReflection()
        {
            await TestDelegatesAsync(typeof(PublicDelegate));
        }
    }
}
