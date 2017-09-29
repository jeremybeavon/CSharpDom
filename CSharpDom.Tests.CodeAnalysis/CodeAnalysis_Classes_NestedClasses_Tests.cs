using CSharpDom.TestTarget.Classes.NestedClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedClasses_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestClassWithNestedClassWith1AttributeUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedClassWith1GenericParameterUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWith1GenericParameter));
        }

        [TestMethod]
        public void TestClassWithNestedClassWith1ImplementedInterfaceUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestClassWithNestedClassWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestClassWithNestedClassWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedClassWith2GenericParametersUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWith2GenericParameters));
        }

        [TestMethod]
        public void TestClassWithNestedClassWith2ImplementedInterfacesUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithBaseClassUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithBaseClass));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestClassWithInternalNestedClassUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithInternalNestedClass));
        }

        [TestMethod]
        public void TestClassWithProtectedNestedClassUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithProtectedNestedClass));
        }

        [TestMethod]
        public void TestClassWithProtectedInternalNestedClassUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithProtectedInternalNestedClass));
        }

        [TestMethod]
        public void TestClassWithPrivateNestedClassUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithPrivateNestedClass));
        }

        [TestMethod]
        public void TestClassWithPublicNestedClassUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithPublicNestedClass));
        }
    }
}
