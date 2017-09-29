using CSharpDom.TestTarget.SealedClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestSealedClassWith1AttributeUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWith1GenericParameterUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWith1GenericParameter<>));
        }

        [TestMethod]
        public void TestSealedClassWith1ImplementedInterfaceUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestSealedClassWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestSealedClassWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWith2GenericParametersUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWith2GenericParameters<,>));
        }

        [TestMethod]
        public void TestSealedClassWith2ImplementedInterfacesUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestSealedClassWithBaseClassUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithBaseClass));
        }

        [TestMethod]
        public void TestSealedClassWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithGenericParameterBaseClassConstraint<>));
        }

        [TestMethod]
        public void TestSealedClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithGenericParameterClassAndEmptyConstructorConstraints<>));
        }

        [TestMethod]
        public void TestSealedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints<>));
        }

        [TestMethod]
        public void TestSealedClassWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithGenericParameterClassConstraint<>));
        }

        [TestMethod]
        public void TestSealedClassWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithGenericParameterEmptyConstructorConstraint<>));
        }

        [TestMethod]
        public void TestSealedClassWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithGenericParameterGenericParameterConstraint<,>));
        }

        [TestMethod]
        public void TestSealedClassWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithGenericParameterInterfaceConstraint<>));
        }

        [TestMethod]
        public void TestSealedClassWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithGenericParameterStructConstraint<>));
        }

        [TestMethod]
        public void TestInternalSealedClassUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(InternalSealedClass));
        }

        [TestMethod]
        public void TestPublicSealedClassUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(PublicSealedClass));
        }
    }
}
