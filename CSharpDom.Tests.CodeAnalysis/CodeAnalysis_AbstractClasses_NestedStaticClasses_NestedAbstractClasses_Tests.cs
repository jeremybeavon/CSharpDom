using CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses.NestedAbstractClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_AbstractClasses_NestedStaticClasses_NestedAbstractClasses_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithNestedAbstractClassWith1AttributeUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedAbstractClassWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithNestedAbstractClassWith1GenericParameterUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedAbstractClassWith1GenericParameter));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithNestedAbstractClassWith1ImplementedInterfaceUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedAbstractClassWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithNestedAbstractClassWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedAbstractClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithNestedAbstractClassWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedAbstractClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithNestedAbstractClassWith2GenericParametersUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedAbstractClassWith2GenericParameters));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithNestedAbstractClassWith2ImplementedInterfacesUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedAbstractClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithNestedAbstractClassWithBaseClassUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedAbstractClassWithBaseClass));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithInternalNestedAbstractClassUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithInternalNestedAbstractClass));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithPrivateNestedAbstractClassUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithPrivateNestedAbstractClass));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithProtectedNestedAbstractClassUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithProtectedNestedAbstractClass));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithProtectedInternalNestedAbstractClassUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithProtectedInternalNestedAbstractClass));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithPublicNestedAbstractClassUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithPublicNestedAbstractClass));
        }
    }
}
