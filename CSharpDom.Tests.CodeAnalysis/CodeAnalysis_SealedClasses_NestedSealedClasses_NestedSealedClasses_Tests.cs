using CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.NestedSealedClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_NestedSealedClasses_NestedSealedClasses_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithNestedSealedClassWith1AttributeUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNestedSealedClassWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithNestedSealedClassWith1GenericParameterUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNestedSealedClassWith1GenericParameter));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithNestedSealedClassWith1ImplementedInterfaceUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNestedSealedClassWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithNestedSealedClassWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNestedSealedClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithNestedSealedClassWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNestedSealedClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithNestedSealedClassWith2GenericParametersUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNestedSealedClassWith2GenericParameters));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithNestedSealedClassWith2ImplementedInterfacesUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNestedSealedClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithNestedSealedClassWithBaseClassUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNestedSealedClassWithBaseClass));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithNestedSealedClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNestedSealedClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithNestedSealedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNestedSealedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithNestedSealedClassWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNestedSealedClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithNestedSealedClassWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNestedSealedClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithNestedSealedClassWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNestedSealedClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithNestedSealedClassWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNestedSealedClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithNestedSealedClassWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNestedSealedClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithNestedSealedClassWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNestedSealedClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithInternalNestedSealedClassUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithInternalNestedSealedClass));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithPrivateNestedSealedClassUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithPrivateNestedSealedClass));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithProtectedNestedSealedClassUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithProtectedNestedSealedClass));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithProtectedInternalNestedSealedClassUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithProtectedInternalNestedSealedClass));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithPublicNestedSealedClassUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithPublicNestedSealedClass));
        }
    }
}
