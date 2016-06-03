using CSharpDom.TestTarget.Delegates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Delegates_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestDelegateWith1AttributeUsingMonoCecil()
        {
            await TestDelegatesAsync(typeof(DelegateWith1Attribute));
        }

        [TestMethod]
        public async Task TestDelegateWith1GenericParameterUsingMonoCecil()
        {
            await TestDelegatesAsync(typeof(DelegateWith1GenericParameter<>));
        }

        [TestMethod]
        public async Task TestDelegateWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestDelegatesAsync(typeof(DelegateWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestDelegateWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestDelegatesAsync(typeof(DelegateWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestDelegateWith2GenericParametersUsingMonoCecil()
        {
            await TestDelegatesAsync(typeof(DelegateWith2GenericParameters<,>));
        }

        [TestMethod]
        public async Task TestDelegateWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            await TestDelegatesAsync(typeof(DelegateWithGenericParameterBaseClassConstraint<>));
        }

        [TestMethod]
        public async Task TestDelegateWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestDelegatesAsync(typeof(DelegateWithGenericParameterClassAndEmptyConstructorConstraints<>));
        }

        [TestMethod]
        public async Task TestDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestDelegatesAsync(typeof(DelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints<>));
        }

        [TestMethod]
        public async Task TestDelegateWithGenericParameterClassConstraintUsingMonoCecil()
        {
            await TestDelegatesAsync(typeof(DelegateWithGenericParameterClassConstraint<>));
        }

        [TestMethod]
        public async Task TestDelegateWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            await TestDelegatesAsync(typeof(DelegateWithGenericParameterEmptyConstructorConstraint<>));
        }

        [TestMethod]
        public async Task TestDelegateWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            await TestDelegatesAsync(typeof(DelegateWithGenericParameterGenericParameterConstraint<,>));
        }

        [TestMethod]
        public async Task TestDelegateWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            await TestDelegatesAsync(typeof(DelegateWithGenericParameterInterfaceConstraint<>));
        }

        [TestMethod]
        public async Task TestDelegateWithGenericParameterStructConstraintUsingMonoCecil()
        {
            await TestDelegatesAsync(typeof(DelegateWithGenericParameterStructConstraint<>));
        }

        [TestMethod]
        public async Task TestInternalDelegateUsingMonoCecil()
        {
            await TestDelegatesAsync(typeof(InternalDelegate));
        }

        [TestMethod]
        public async Task TestDelegateWithParametersWithAttributesUsingMonoCecil()
        {
            await TestDelegatesAsync(typeof(DelegateWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestDelegateWithParametersWithModifiersUsingMonoCecil()
        {
            await TestDelegatesAsync(typeof(DelegateWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestPublicDelegateUsingMonoCecil()
        {
            await TestDelegatesAsync(typeof(PublicDelegate));
        }
    }
}
