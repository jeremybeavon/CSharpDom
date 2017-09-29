using CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.NestedClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_AbstractClasses_NestedSealedClasses_NestedClasses_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithNestedClassWith1AttributeUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNestedClassWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithNestedClassWith1GenericParameterUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNestedClassWith1GenericParameter));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithNestedClassWith1ImplementedInterfaceUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNestedClassWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithNestedClassWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNestedClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithNestedClassWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNestedClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithNestedClassWith2GenericParametersUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNestedClassWith2GenericParameters));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithNestedClassWith2ImplementedInterfacesUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNestedClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithNestedClassWithBaseClassUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNestedClassWithBaseClass));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithNestedClassWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNestedClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithNestedClassWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNestedClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithNestedClassWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNestedClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithNestedClassWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNestedClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithNestedClassWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNestedClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithNestedClassWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNestedClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithInternalNestedClassUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithInternalNestedClass));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithPrivateNestedClassUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithPrivateNestedClass));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithProtectedNestedClassUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithProtectedNestedClass));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithProtectedInternalNestedClassUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithProtectedInternalNestedClass));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithPublicNestedClassUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithPublicNestedClass));
        }
    }
}
