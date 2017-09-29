using CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.NestedStructs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_NestedSealedClasses_NestedStructs_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithNestedStructWith1AttributeUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNestedStructWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithNestedStructWith1GenericParameterUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNestedStructWith1GenericParameter));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithNestedStructWith1ImplementedInterfaceUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNestedStructWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithNestedStructWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNestedStructWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithNestedStructWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNestedStructWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithNestedStructWith2GenericParametersUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNestedStructWith2GenericParameters));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithNestedStructWith2ImplementedInterfacesUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNestedStructWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithNestedStructWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNestedStructWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithNestedStructWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNestedStructWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithNestedStructWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNestedStructWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithNestedStructWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNestedStructWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithNestedStructWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNestedStructWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithNestedStructWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNestedStructWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithInternalNestedStructUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithInternalNestedStruct));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithPrivateNestedStructUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithPrivateNestedStruct));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithProtectedNestedStructUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithProtectedNestedStruct));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithProtectedInternalNestedStructUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithProtectedInternalNestedStruct));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithPublicNestedStructUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithPublicNestedStruct));
        }
    }
}
