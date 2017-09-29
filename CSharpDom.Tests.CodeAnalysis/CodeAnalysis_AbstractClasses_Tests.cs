using CSharpDom.TestTarget.AbstractClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_AbstractClasses_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestAbstractClassWith1AttributeUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWith1GenericParameterUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWith1GenericParameter<>));
        }

        [TestMethod]
        public void TestAbstractClassWith1ImplementedInterfaceUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestAbstractClassWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestAbstractClassWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWith2GenericParametersUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWith2GenericParameters<,>));
        }

        [TestMethod]
        public void TestAbstractClassWith2ImplementedInterfacesUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestAbstractClassWithBaseClassUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithBaseClass));
        }

        [TestMethod]
        public void TestAbstractClassWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithGenericParameterBaseClassConstraint<>));
        }

        [TestMethod]
        public void TestAbstractClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithGenericParameterClassAndEmptyConstructorConstraints<>));
        }

        [TestMethod]
        public void TestAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints<>));
        }

        [TestMethod]
        public void TestAbstractClassWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithGenericParameterClassConstraint<>));
        }

        [TestMethod]
        public void TestAbstractClassWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithGenericParameterEmptyConstructorConstraint<>));
        }

        [TestMethod]
        public void TestAbstractClassWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithGenericParameterGenericParameterConstraint<,>));
        }

        [TestMethod]
        public void TestAbstractClassWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithGenericParameterInterfaceConstraint<>));
        }

        [TestMethod]
        public void TestAbstractClassWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithGenericParameterStructConstraint<>));
        }

        [TestMethod]
        public void TestInternalAbstractClassUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(InternalAbstractClass));
        }

        [TestMethod]
        public void TestPublicAbstractClassUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(PublicAbstractClass));
        }
    }
}
