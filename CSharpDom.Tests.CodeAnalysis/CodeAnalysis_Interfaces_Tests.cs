using CSharpDom.TestTarget.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Interfaces_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestInterfaceWith1AttributeUsingCodeAnalysis()
        {
            await TestInterfacesAsync(typeof(InterfaceWith1Attribute));
        }

        [TestMethod]
        public async Task TestInterfaceWith1GenericParameterUsingCodeAnalysis()
        {
            await TestInterfacesAsync(typeof(InterfaceWith1GenericParameter<>));
        }

        [TestMethod]
        public async Task TestInterfaceWith1ImplementedInterfaceUsingCodeAnalysis()
        {
            await TestInterfacesAsync(typeof(InterfaceWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestInterfaceWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestInterfacesAsync(typeof(InterfaceWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestInterfaceWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestInterfacesAsync(typeof(InterfaceWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestInterfaceWith2GenericParametersUsingCodeAnalysis()
        {
            await TestInterfacesAsync(typeof(InterfaceWith2GenericParameters<,>));
        }

        [TestMethod]
        public async Task TestInterfaceWith2ImplementedInterfacesUsingCodeAnalysis()
        {
            await TestInterfacesAsync(typeof(InterfaceWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestInterfaceWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            await TestInterfacesAsync(typeof(InterfaceWithGenericParameterBaseClassConstraint<>));
        }

        [TestMethod]
        public async Task TestInterfaceWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            await TestInterfacesAsync(typeof(InterfaceWithGenericParameterClassAndEmptyConstructorConstraints<>));
        }

        [TestMethod]
        public async Task TestInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            await TestInterfacesAsync(typeof(InterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints<>));
        }

        [TestMethod]
        public async Task TestInterfaceWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            await TestInterfacesAsync(typeof(InterfaceWithGenericParameterClassConstraint<>));
        }

        [TestMethod]
        public async Task TestInterfaceWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            await TestInterfacesAsync(typeof(InterfaceWithGenericParameterEmptyConstructorConstraint<>));
        }

        [TestMethod]
        public async Task TestInterfaceWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            await TestInterfacesAsync(typeof(InterfaceWithGenericParameterGenericParameterConstraint<,>));
        }

        [TestMethod]
        public async Task TestInterfaceWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            await TestInterfacesAsync(typeof(InterfaceWithGenericParameterInterfaceConstraint<>));
        }

        [TestMethod]
        public async Task TestInterfaceWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            await TestInterfacesAsync(typeof(InterfaceWithGenericParameterStructConstraint<>));
        }

        [TestMethod]
        public async Task TestInternalInterfaceUsingCodeAnalysis()
        {
            await TestInterfacesAsync(typeof(InternalInterface));
        }

        [TestMethod]
        public async Task TestPublicInterfaceUsingCodeAnalysis()
        {
            await TestInterfacesAsync(typeof(PublicInterface));
        }
    }
}
