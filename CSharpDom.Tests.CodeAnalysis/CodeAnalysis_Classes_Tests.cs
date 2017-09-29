using CSharpDom.TestTarget.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestClassWith1AttributeUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWith1Attribute));
        }

        [TestMethod]
        public void TestClassWith1GenericParameterUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWith1GenericParameter<>));
        }

        [TestMethod]
        public void TestClassWith1ImplementedInterfaceUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestClassWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestClassWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWith2GenericParametersUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWith2GenericParameters<,>));
        }

        [TestMethod]
        public void TestClassWith2ImplementedInterfacesUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestClassWithBaseClassUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithBaseClass));
        }

        [TestMethod]
        public void TestClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithGenericParameterClassAndEmptyConstructorConstraints<>));
        }

        [TestMethod]
        public void TestClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints<>));
        }

        [TestMethod]
        public void TestClassWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithGenericParameterBaseClassConstraint<>));
        }

        [TestMethod]
        public void TestClassWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithGenericParameterClassConstraint<>));
        }

        [TestMethod]
        public void TestClassWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithGenericParameterEmptyConstructorConstraint<>));
        }

        [TestMethod]
        public void TestClassWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithGenericParameterGenericParameterConstraint<,>));
        }

        [TestMethod]
        public void TestClassWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithGenericParameterInterfaceConstraint<>));
        }

        [TestMethod]
        public void TestClassWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithGenericParameterStructConstraint<>));
        }

        [TestMethod]
        public void TestInternalClassUsingCodeAnalysis()
        {
            TestClassAsync(typeof(InternalClass));
        }

        [TestMethod]
        public void TestPublicClassUsingCodeAnalysis()
        {
            TestClassAsync(typeof(PublicClass));
        }
    }
}
