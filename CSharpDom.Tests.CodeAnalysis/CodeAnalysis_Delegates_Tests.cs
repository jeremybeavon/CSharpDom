using CSharpDom.TestTarget.Delegates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Delegates_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestDelegateWith1AttributeUsingCodeAnalysis()
        {
            await TestDelegatesAsync(typeof(DelegateWith1Attribute));
        }

        [TestMethod]
        public async Task TestDelegateWith1GenericParameterUsingCodeAnalysis()
        {
            await TestDelegatesAsync(typeof(DelegateWith1GenericParameter<>));
        }

        [TestMethod]
        public async Task TestDelegateWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestDelegatesAsync(typeof(DelegateWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestDelegateWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestDelegatesAsync(typeof(DelegateWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestDelegateWith2GenericParametersUsingCodeAnalysis()
        {
            await TestDelegatesAsync(typeof(DelegateWith2GenericParameters<,>));
        }

        [TestMethod]
        public async Task TestDelegateWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            await TestDelegatesAsync(typeof(DelegateWithGenericParameterBaseClassConstraint<>));
        }

        [TestMethod]
        public async Task TestDelegateWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            await TestDelegatesAsync(typeof(DelegateWithGenericParameterClassAndEmptyConstructorConstraints<>));
        }

        [TestMethod]
        public async Task TestDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            await TestDelegatesAsync(typeof(DelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints<>));
        }

        [TestMethod]
        public async Task TestDelegateWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            await TestDelegatesAsync(typeof(DelegateWithGenericParameterClassConstraint<>));
        }

        [TestMethod]
        public async Task TestDelegateWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            await TestDelegatesAsync(typeof(DelegateWithGenericParameterEmptyConstructorConstraint<>));
        }

        [TestMethod]
        public async Task TestDelegateWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            await TestDelegatesAsync(typeof(DelegateWithGenericParameterGenericParameterConstraint<,>));
        }

        [TestMethod]
        public async Task TestDelegateWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            await TestDelegatesAsync(typeof(DelegateWithGenericParameterInterfaceConstraint<>));
        }

        [TestMethod]
        public async Task TestDelegateWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            await TestDelegatesAsync(typeof(DelegateWithGenericParameterStructConstraint<>));
        }

        [TestMethod]
        public async Task TestInternalDelegateUsingCodeAnalysis()
        {
            await TestDelegatesAsync(typeof(InternalDelegate));
        }

        [TestMethod]
        public async Task TestDelegateWithParametersWithAttributesUsingCodeAnalysis()
        {
            await TestDelegatesAsync(typeof(DelegateWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestDelegateWithParametersWithModifiersUsingCodeAnalysis()
        {
            await TestDelegatesAsync(typeof(DelegateWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestPublicDelegateUsingCodeAnalysis()
        {
            await TestDelegatesAsync(typeof(PublicDelegate));
        }
    }
}
