using CSharpDom.TestTarget.Structs.NestedDelegates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedDelegates_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStructWithNestedDelegateWith1AttributeUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedDelegateWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedDelegateWith1GenericParameterUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedDelegateWith1GenericParameter));
        }

        [TestMethod]
        public void TestStructWithNestedDelegateWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedDelegateWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStructWithNestedDelegateWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedDelegateWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedDelegateWith2GenericParametersUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedDelegateWith2GenericParameters));
        }

        [TestMethod]
        public void TestStructWithNestedDelegateWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedDelegateWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedDelegateWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedDelegateWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedDelegateWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedDelegateWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedDelegateWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedDelegateWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedDelegateWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedDelegateWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedDelegateWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedDelegateWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestStructWithInternalNestedDelegateUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithInternalNestedDelegate));
        }

        [TestMethod]
        public void TestStructWithNestedDelegateWithParametersWithAttributesUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedDelegateWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestStructWithNestedDelegateWithParametersWithModifiersUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedDelegateWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestStructWithPrivateNestedDelegateUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithPrivateNestedDelegate));
        }

        [TestMethod]
        public void TestStructWithPublicNestedDelegateUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithPublicNestedDelegate));
        }
    }
}
