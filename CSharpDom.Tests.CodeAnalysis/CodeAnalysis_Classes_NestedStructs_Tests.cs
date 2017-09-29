using CSharpDom.TestTarget.Classes.NestedStructs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedStructs_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestClassWithNestedStructWith1AttributeUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedStructWith1GenericParameterUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWith1GenericParameter));
        }

        [TestMethod]
        public void TestClassWithNestedStructWith1ImplementedInterfaceUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestClassWithNestedStructWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestClassWithNestedStructWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedStructWith2GenericParametersUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWith2GenericParameters));
        }

        [TestMethod]
        public void TestClassWithNestedStructWith2ImplementedInterfacesUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestClassWithInternalNestedStructUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithInternalNestedStruct));
        }

        [TestMethod]
        public void TestClassWithPrivateNestedStructUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithPrivateNestedStruct));
        }

        [TestMethod]
        public void TestClassWithProtectedNestedStructUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithProtectedNestedStruct));
        }

        [TestMethod]
        public void TestClassWithProtectedInternalNestedStructUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithProtectedInternalNestedStruct));
        }

        [TestMethod]
        public void TestClassWithPublicNestedStructUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithPublicNestedStruct));
        }
    }
}
