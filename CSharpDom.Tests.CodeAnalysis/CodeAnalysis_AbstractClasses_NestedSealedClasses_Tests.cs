using CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_AbstractClasses_NestedSealedClasses_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWith1AttributeUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWith1GenericParameterUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWith1GenericParameter));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWith1ImplementedInterfaceUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWith2GenericParametersUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWith2GenericParameters));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWith2ImplementedInterfacesUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithBaseClassUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithBaseClass));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithInternalNestedSealedClassUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithInternalNestedSealedClass));
        }

        [TestMethod]
        public void TestAbstractClassWithPrivateNestedSealedClassUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithPrivateNestedSealedClass));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedNestedSealedClassUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithProtectedNestedSealedClass));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedInternalNestedSealedClassUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithProtectedInternalNestedSealedClass));
        }

        [TestMethod]
        public void TestAbstractClassWithPublicNestedSealedClassUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithPublicNestedSealedClass));
        }
    }
}
