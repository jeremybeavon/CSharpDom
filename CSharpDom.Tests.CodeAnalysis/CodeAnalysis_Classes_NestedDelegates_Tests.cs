using CSharpDom.TestTarget.Classes.NestedDelegates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedDelegates_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestClassWithNestedDelegateWith1AttributeUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedDelegateWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedDelegateWith1GenericParameterUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedDelegateWith1GenericParameter));
        }

        [TestMethod]
        public void TestClassWithNestedDelegateWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedDelegateWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestClassWithNestedDelegateWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedDelegateWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedDelegateWith2GenericParametersUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedDelegateWith2GenericParameters));
        }

        [TestMethod]
        public void TestClassWithNestedDelegateWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedDelegateWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithNestedDelegateWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedDelegateWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedDelegateWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedDelegateWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedDelegateWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedDelegateWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedDelegateWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedDelegateWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestClassWithProtectedNestedDelegateUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithProtectedNestedDelegate));
        }

        [TestMethod]
        public void TestClassWithPrivateNestedDelegateUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithPrivateNestedDelegate));
        }

        [TestMethod]
        public void TestClassWithProtectedInternalNestedDelegateUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithProtectedInternalNestedDelegate));
        }

        [TestMethod]
        public void TestClassWithInternalNestedDelegateUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithInternalNestedDelegate));
        }

        [TestMethod]
        public void TestClassWithNestedDelegateWithParametersWithAttributesUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedDelegateWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestClassWithNestedDelegateWithParametersWithModifiersUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedDelegateWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestClassWithPublicNestedDelegateUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithPublicNestedDelegate));
        }
    }
}
