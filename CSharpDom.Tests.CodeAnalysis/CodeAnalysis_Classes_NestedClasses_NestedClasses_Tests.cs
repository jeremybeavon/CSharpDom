using CSharpDom.TestTarget.Classes.NestedClasses.NestedClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedClasses_NestedClasses_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestClassWithNestedClassWithNestedClassWith1AttributeUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedClassWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNestedClassWith1GenericParameterUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedClassWith1GenericParameter));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNestedClassWith1ImplementedInterfaceUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedClassWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNestedClassWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNestedClassWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNestedClassWith2GenericParametersUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedClassWith2GenericParameters));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNestedClassWith2ImplementedInterfacesUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNestedClassWithBaseClassUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedClassWithBaseClass));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNestedClassWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNestedClassWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNestedClassWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNestedClassWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNestedClassWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNestedClassWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithInternalNestedClassUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithInternalNestedClass));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPrivateNestedClassUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithPrivateNestedClass));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedNestedClassUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithProtectedNestedClass));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedInternalNestedClassUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithProtectedInternalNestedClass));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPublicNestedClassUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithPublicNestedClass));
        }
    }
}
