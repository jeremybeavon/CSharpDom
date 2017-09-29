using CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_AbstractClasses_NestedStaticClasses_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWith1AttributeUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWith1GenericParameterUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWith1GenericParameter));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWith2GenericParametersUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWith2GenericParameters));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithInternalNestedStaticClassUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithInternalNestedStaticClass));
        }

        [TestMethod]
        public void TestAbstractClassWithPrivateNestedStaticClassUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithPrivateNestedStaticClass));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedNestedStaticClassUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithProtectedNestedStaticClass));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedInternalNestedStaticClassUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithProtectedInternalNestedStaticClass));
        }

        [TestMethod]
        public void TestAbstractClassWithPublicNestedStaticClassUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithPublicNestedStaticClass));
        }
    }
}
