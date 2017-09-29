using CSharpDom.TestTarget.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Interfaces_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestInterfaceWith1AttributeUsingCodeAnalysis()
        {
            TestInterfacesAsync(typeof(InterfaceWith1Attribute));
        }

        [TestMethod]
        public void TestInterfaceWith1GenericParameterUsingCodeAnalysis()
        {
            TestInterfacesAsync(typeof(InterfaceWith1GenericParameter<>));
        }

        [TestMethod]
        public void TestInterfaceWith1ImplementedInterfaceUsingCodeAnalysis()
        {
            TestInterfacesAsync(typeof(InterfaceWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestInterfaceWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestInterfacesAsync(typeof(InterfaceWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestInterfaceWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestInterfacesAsync(typeof(InterfaceWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestInterfaceWith2GenericParametersUsingCodeAnalysis()
        {
            TestInterfacesAsync(typeof(InterfaceWith2GenericParameters<,>));
        }

        [TestMethod]
        public void TestInterfaceWith2ImplementedInterfacesUsingCodeAnalysis()
        {
            TestInterfacesAsync(typeof(InterfaceWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestInterfaceWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            TestInterfacesAsync(typeof(InterfaceWithGenericParameterBaseClassConstraint<>));
        }

        [TestMethod]
        public void TestInterfaceWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestInterfacesAsync(typeof(InterfaceWithGenericParameterClassAndEmptyConstructorConstraints<>));
        }

        [TestMethod]
        public void TestInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestInterfacesAsync(typeof(InterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints<>));
        }

        [TestMethod]
        public void TestInterfaceWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            TestInterfacesAsync(typeof(InterfaceWithGenericParameterClassConstraint<>));
        }

        [TestMethod]
        public void TestInterfaceWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            TestInterfacesAsync(typeof(InterfaceWithGenericParameterEmptyConstructorConstraint<>));
        }

        [TestMethod]
        public void TestInterfaceWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            TestInterfacesAsync(typeof(InterfaceWithGenericParameterGenericParameterConstraint<,>));
        }

        [TestMethod]
        public void TestInterfaceWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            TestInterfacesAsync(typeof(InterfaceWithGenericParameterInterfaceConstraint<>));
        }

        [TestMethod]
        public void TestInterfaceWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            TestInterfacesAsync(typeof(InterfaceWithGenericParameterStructConstraint<>));
        }

        [TestMethod]
        public void TestInternalInterfaceUsingCodeAnalysis()
        {
            TestInterfacesAsync(typeof(InternalInterface));
        }

        [TestMethod]
        public void TestPublicInterfaceUsingCodeAnalysis()
        {
            TestInterfacesAsync(typeof(PublicInterface));
        }
    }
}
