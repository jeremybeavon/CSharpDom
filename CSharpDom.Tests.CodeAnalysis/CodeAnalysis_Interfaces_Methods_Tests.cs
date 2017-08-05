using CSharpDom.TestTarget.Interfaces.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Interfaces_Methods_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestIInterfaceWithMethodWith1GenericParameterUsingCodeAnalysis()
        {
            await TestInterfacesAsync(typeof(IInterfaceWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestIInterfaceWithMethodWith2GenericParametersUsingCodeAnalysis()
        {
            await TestInterfacesAsync(typeof(IInterfaceWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestIInterfaceWithMethodUsingCodeAnalysis()
        {
            await TestInterfacesAsync(typeof(IInterfaceWithMethod));
        }

        [TestMethod]
        public async Task TestIInterfaceWithMethodWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            await TestInterfacesAsync(typeof(IInterfaceWithMethodWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestIInterfaceWithMethodWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            await TestInterfacesAsync(typeof(IInterfaceWithMethodWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestIInterfaceWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            await TestInterfacesAsync(typeof(IInterfaceWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestIInterfaceWithMethodWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            await TestInterfacesAsync(typeof(IInterfaceWithMethodWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestIInterfaceWithMethodWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            await TestInterfacesAsync(typeof(IInterfaceWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestIInterfaceWithMethodWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            await TestInterfacesAsync(typeof(IInterfaceWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestIInterfaceWithMethodWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            await TestInterfacesAsync(typeof(IInterfaceWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestIInterfaceWithMethodWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            await TestInterfacesAsync(typeof(IInterfaceWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestIInterfaceWithMethodWithParametersWithModifiersUsingCodeAnalysis()
        {
            await TestInterfacesAsync(typeof(IInterfaceWithMethodWithParametersWithModifiers));
        }
    }
}
