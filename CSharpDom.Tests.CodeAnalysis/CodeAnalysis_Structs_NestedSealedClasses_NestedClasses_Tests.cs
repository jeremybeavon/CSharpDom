using CSharpDom.TestTarget.Structs.NestedSealedClasses.NestedClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedSealedClasses_NestedClasses_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStructWithNestedSealedClassWithNestedClassWith1AttributeUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNestedClassWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNestedClassWith1GenericParameterUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNestedClassWith1GenericParameter));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNestedClassWith1ImplementedInterfaceUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNestedClassWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNestedClassWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNestedClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNestedClassWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNestedClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNestedClassWith2GenericParametersUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNestedClassWith2GenericParameters));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNestedClassWith2ImplementedInterfacesUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNestedClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNestedClassWithBaseClassUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNestedClassWithBaseClass));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNestedClassWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNestedClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNestedClassWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNestedClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNestedClassWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNestedClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNestedClassWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNestedClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNestedClassWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNestedClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNestedClassWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNestedClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithInternalNestedClassUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithInternalNestedClass));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPrivateNestedClassUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithPrivateNestedClass));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedNestedClassUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedNestedClass));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedInternalNestedClassUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedInternalNestedClass));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPublicNestedClassUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithPublicNestedClass));
        }
    }
}
