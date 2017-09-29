using CSharpDom.TestTarget.SealedClasses.NestedStructs.NestedClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_NestedStructs_NestedClasses_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedStructWithNestedClassWith1AttributeUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedClassWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithNestedClassWith1GenericParameterUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedClassWith1GenericParameter));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithNestedClassWith1ImplementedInterfaceUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedClassWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithNestedClassWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithNestedClassWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithNestedClassWith2GenericParametersUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedClassWith2GenericParameters));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithNestedClassWith2ImplementedInterfacesUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithNestedClassWithBaseClassUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedClassWithBaseClass));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithNestedClassWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithNestedClassWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithNestedClassWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithNestedClassWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithNestedClassWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithNestedClassWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithInternalNestedClassUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithInternalNestedClass));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithPrivateNestedClassUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithPrivateNestedClass));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithPublicNestedClassUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithPublicNestedClass));
        }
    }
}
