using CSharpDom.TestTarget.SealedClasses.NestedSealedClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_NestedSealedClasses_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWith1AttributeUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWith1GenericParameterUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWith1GenericParameter));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWith1ImplementedInterfaceUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWith2GenericParametersUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWith2GenericParameters));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWith2ImplementedInterfacesUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithBaseClassUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithBaseClass));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithInternalNestedSealedClassUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithInternalNestedSealedClass));
        }

        [TestMethod]
        public void TestSealedClassWithPrivateNestedSealedClassUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithPrivateNestedSealedClass));
        }

        [TestMethod]
        public void TestSealedClassWithProtectedNestedSealedClassUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithProtectedNestedSealedClass));
        }

        [TestMethod]
        public void TestSealedClassWithProtectedInternalNestedSealedClassUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithProtectedInternalNestedSealedClass));
        }

        [TestMethod]
        public void TestSealedClassWithPublicNestedSealedClassUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithPublicNestedSealedClass));
        }
    }
}
