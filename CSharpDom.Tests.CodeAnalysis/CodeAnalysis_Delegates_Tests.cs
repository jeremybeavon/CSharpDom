using CSharpDom.TestTarget.Delegates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Delegates_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestDelegateWith1AttributeUsingCodeAnalysis()
        {
            TestDelegatesAsync(typeof(DelegateWith1Attribute));
        }

        [TestMethod]
        public void TestDelegateWith1GenericParameterUsingCodeAnalysis()
        {
            TestDelegatesAsync(typeof(DelegateWith1GenericParameter<>));
        }

        [TestMethod]
        public void TestDelegateWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestDelegatesAsync(typeof(DelegateWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestDelegateWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestDelegatesAsync(typeof(DelegateWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestDelegateWith2GenericParametersUsingCodeAnalysis()
        {
            TestDelegatesAsync(typeof(DelegateWith2GenericParameters<,>));
        }

        [TestMethod]
        public void TestDelegateWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            TestDelegatesAsync(typeof(DelegateWithGenericParameterBaseClassConstraint<>));
        }

        [TestMethod]
        public void TestDelegateWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestDelegatesAsync(typeof(DelegateWithGenericParameterClassAndEmptyConstructorConstraints<>));
        }

        [TestMethod]
        public void TestDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestDelegatesAsync(typeof(DelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints<>));
        }

        [TestMethod]
        public void TestDelegateWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            TestDelegatesAsync(typeof(DelegateWithGenericParameterClassConstraint<>));
        }

        [TestMethod]
        public void TestDelegateWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            TestDelegatesAsync(typeof(DelegateWithGenericParameterEmptyConstructorConstraint<>));
        }

        [TestMethod]
        public void TestDelegateWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            TestDelegatesAsync(typeof(DelegateWithGenericParameterGenericParameterConstraint<,>));
        }

        [TestMethod]
        public void TestDelegateWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            TestDelegatesAsync(typeof(DelegateWithGenericParameterInterfaceConstraint<>));
        }

        [TestMethod]
        public void TestDelegateWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            TestDelegatesAsync(typeof(DelegateWithGenericParameterStructConstraint<>));
        }

        [TestMethod]
        public void TestInternalDelegateUsingCodeAnalysis()
        {
            TestDelegatesAsync(typeof(InternalDelegate));
        }

        [TestMethod]
        public void TestDelegateWithParametersWithAttributesUsingCodeAnalysis()
        {
            TestDelegatesAsync(typeof(DelegateWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestDelegateWithParametersWithModifiersUsingCodeAnalysis()
        {
            TestDelegatesAsync(typeof(DelegateWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestPublicDelegateUsingCodeAnalysis()
        {
            TestDelegatesAsync(typeof(PublicDelegate));
        }
    }
}
