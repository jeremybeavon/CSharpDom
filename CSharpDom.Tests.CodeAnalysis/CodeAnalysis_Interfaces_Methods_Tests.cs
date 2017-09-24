using CSharpDom.TestTarget.Interfaces.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Interfaces_Methods_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestInterfaceWithMethodWith1GenericParameterUsingCodeAnalysis()
        {
            await TestInterfacesAsync(typeof(IInterfaceWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestInterfaceWithMethodWith2GenericParametersUsingCodeAnalysis()
        {
            await TestInterfacesAsync(typeof(IInterfaceWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestInterfaceWithMethodUsingCodeAnalysis()
        {
            await TestInterfacesAsync(typeof(IInterfaceWithMethod));
        }

        [TestMethod]
        public async Task TestInterfaceWithMethodWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            await TestInterfacesAsync(typeof(IInterfaceWithMethodWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestInterfaceWithMethodWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            await TestInterfacesAsync(typeof(IInterfaceWithMethodWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestInterfaceWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            await TestInterfacesAsync(typeof(IInterfaceWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestInterfaceWithMethodWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            await TestInterfacesAsync(typeof(IInterfaceWithMethodWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestInterfaceWithMethodWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            await TestInterfacesAsync(typeof(IInterfaceWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestInterfaceWithMethodWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            await TestInterfacesAsync(typeof(IInterfaceWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestInterfaceWithMethodWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            await TestInterfacesAsync(typeof(IInterfaceWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestInterfaceWithMethodWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            await TestInterfacesAsync(typeof(IInterfaceWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestInterfaceWithMethodWithParametersWithModifiersUsingCodeAnalysis()
        {
            await TestInterfacesAsync(typeof(IInterfaceWithMethodWithParametersWithModifiers));
        }
    }
}
