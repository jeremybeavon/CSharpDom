using CSharpDom.TestTarget.Classes.NestedStructs.NestedDelegates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedStructs_NestedDelegates_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestClassWithNestedStructWithNestedDelegateWith1AttributeUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithNestedDelegateWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithNestedDelegateWith1GenericParameterUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithNestedDelegateWith1GenericParameter));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithNestedDelegateWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithNestedDelegateWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithNestedDelegateWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithNestedDelegateWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithNestedDelegateWith2GenericParametersUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithNestedDelegateWith2GenericParameters));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithNestedDelegateWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithNestedDelegateWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithNestedDelegateWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithNestedDelegateWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithNestedDelegateWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithNestedDelegateWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithNestedDelegateWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithNestedDelegateWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithNestedDelegateWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithNestedDelegateWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithNestedDelegateWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithNestedDelegateWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithInternalNestedDelegateUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithInternalNestedDelegate));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithNestedDelegateWithParametersWithAttributesUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithNestedDelegateWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithNestedDelegateWithParametersWithModifiersUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithNestedDelegateWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPrivateNestedDelegateUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithPrivateNestedDelegate));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPublicNestedDelegateUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithPublicNestedDelegate));
        }
    }
}
