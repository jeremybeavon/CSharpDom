using CSharpDom.TestTarget.SealedClasses.NestedDelegates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_NestedDelegates_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedDelegateWith1AttributeUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedDelegateWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedDelegateWith1GenericParameterUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedDelegateWith1GenericParameter));
        }

        [TestMethod]
        public void TestSealedClassWithNestedDelegateWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedDelegateWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestSealedClassWithNestedDelegateWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedDelegateWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedDelegateWith2GenericParametersUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedDelegateWith2GenericParameters));
        }

        [TestMethod]
        public void TestSealedClassWithNestedDelegateWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedDelegateWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestSealedClassWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestSealedClassWithNestedDelegateWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedDelegateWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedDelegateWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedDelegateWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedDelegateWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedDelegateWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedDelegateWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedDelegateWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithInternalNestedDelegateUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithInternalNestedDelegate));
        }

        [TestMethod]
        public void TestSealedClassWithNestedDelegateWithParametersWithAttributesUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedDelegateWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestSealedClassWithNestedDelegateWithParametersWithModifiersUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedDelegateWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestSealedClassWithPrivateNestedDelegateUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithPrivateNestedDelegate));
        }

        [TestMethod]
        public void TestSealedClassWithProtectedNestedDelegateUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithProtectedNestedDelegate));
        }

        [TestMethod]
        public void TestSealedClassWithProtectedInternalNestedDelegateUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithProtectedInternalNestedDelegate));
        }

        [TestMethod]
        public void TestSealedClassWithPublicNestedDelegateUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithPublicNestedDelegate));
        }
    }
}
