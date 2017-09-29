using CSharpDom.TestTarget.Interfaces.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Interfaces_Methods_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestInterfaceWithMethodWith1GenericParameterUsingCodeAnalysis()
        {
            TestInterfacesAsync(typeof(IInterfaceWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public void TestInterfaceWithMethodWith2GenericParametersUsingCodeAnalysis()
        {
            TestInterfacesAsync(typeof(IInterfaceWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public void TestInterfaceWithMethodUsingCodeAnalysis()
        {
            TestInterfacesAsync(typeof(IInterfaceWithMethod));
        }

        [TestMethod]
        public void TestInterfaceWithMethodWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            TestInterfacesAsync(typeof(IInterfaceWithMethodWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestInterfaceWithMethodWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestInterfacesAsync(typeof(IInterfaceWithMethodWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestInterfaceWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestInterfacesAsync(typeof(IInterfaceWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestInterfaceWithMethodWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            TestInterfacesAsync(typeof(IInterfaceWithMethodWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestInterfaceWithMethodWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            TestInterfacesAsync(typeof(IInterfaceWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestInterfaceWithMethodWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            TestInterfacesAsync(typeof(IInterfaceWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestInterfaceWithMethodWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            TestInterfacesAsync(typeof(IInterfaceWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestInterfaceWithMethodWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            TestInterfacesAsync(typeof(IInterfaceWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestInterfaceWithMethodWithParametersWithModifiersUsingCodeAnalysis()
        {
            TestInterfacesAsync(typeof(IInterfaceWithMethodWithParametersWithModifiers));
        }
    }
}
