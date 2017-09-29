using CSharpDom.TestTarget.Structs.NestedAbstractClasses.NestedClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedAbstractClasses_NestedClasses_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNestedClassWith1AttributeUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedClassWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNestedClassWith1GenericParameterUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedClassWith1GenericParameter));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNestedClassWith1ImplementedInterfaceUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedClassWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNestedClassWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNestedClassWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNestedClassWith2GenericParametersUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedClassWith2GenericParameters));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNestedClassWith2ImplementedInterfacesUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNestedClassWithBaseClassUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedClassWithBaseClass));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNestedClassWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNestedClassWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNestedClassWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNestedClassWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNestedClassWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNestedClassWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNestedClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithInternalNestedClassUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithInternalNestedClass));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPrivateNestedClassUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithPrivateNestedClass));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedNestedClassUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedNestedClass));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedInternalNestedClassUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedInternalNestedClass));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPublicNestedClassUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithPublicNestedClass));
        }
    }
}
