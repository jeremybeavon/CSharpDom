using CSharpDom.TestTarget.SealedClasses.NestedStructs.NestedSealedClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_NestedStructs_NestedSealedClasses_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedStructWithNestedSealedClassWith1AttributeUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedSealedClassWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithNestedSealedClassWith1GenericParameterUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedSealedClassWith1GenericParameter));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithNestedSealedClassWith1ImplementedInterfaceUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedSealedClassWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithNestedSealedClassWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedSealedClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithNestedSealedClassWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedSealedClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithNestedSealedClassWith2GenericParametersUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedSealedClassWith2GenericParameters));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithNestedSealedClassWith2ImplementedInterfacesUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedSealedClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithNestedSealedClassWithBaseClassUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedSealedClassWithBaseClass));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithNestedSealedClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedSealedClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithNestedSealedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedSealedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithNestedSealedClassWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedSealedClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithNestedSealedClassWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedSealedClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithNestedSealedClassWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedSealedClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithNestedSealedClassWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedSealedClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithNestedSealedClassWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedSealedClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithNestedSealedClassWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedSealedClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithInternalNestedSealedClassUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithInternalNestedSealedClass));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithPrivateNestedSealedClassUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithPrivateNestedSealedClass));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithPublicNestedSealedClassUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithPublicNestedSealedClass));
        }
    }
}
