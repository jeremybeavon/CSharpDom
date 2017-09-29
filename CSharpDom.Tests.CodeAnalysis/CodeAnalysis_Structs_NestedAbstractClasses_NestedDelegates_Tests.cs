using CSharpDom.TestTarget.Structs.NestedAbstractClasses.NestedDelegates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedAbstractClasses_NestedDelegates_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNestedDelegateWith1AttributeUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedDelegateWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNestedDelegateWith1GenericParameterUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedDelegateWith1GenericParameter));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNestedDelegateWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedDelegateWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNestedDelegateWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedDelegateWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNestedDelegateWith2GenericParametersUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedDelegateWith2GenericParameters));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNestedDelegateWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedDelegateWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNestedDelegateWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedDelegateWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNestedDelegateWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedDelegateWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNestedDelegateWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedDelegateWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNestedDelegateWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedDelegateWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithInternalNestedDelegateUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithInternalNestedDelegate));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNestedDelegateWithParametersWithAttributesUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedDelegateWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNestedDelegateWithParametersWithModifiersUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedDelegateWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPrivateNestedDelegateUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithPrivateNestedDelegate));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedNestedDelegateUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedNestedDelegate));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedInternalNestedDelegateUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedInternalNestedDelegate));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPublicNestedDelegateUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithPublicNestedDelegate));
        }
    }
}
