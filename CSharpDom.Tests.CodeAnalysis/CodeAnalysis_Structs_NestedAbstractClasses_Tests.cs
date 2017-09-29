using CSharpDom.TestTarget.Structs.NestedAbstractClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedAbstractClasses_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStructWithNestedAbstractClassWith1AttributeUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWith1GenericParameterUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWith1GenericParameter));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWith1ImplementedInterfaceUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWith2GenericParametersUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWith2GenericParameters));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWith2ImplementedInterfacesUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithBaseClassUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithBaseClass));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestStructWithInternalNestedAbstractClassUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithInternalNestedAbstractClass));
        }

        [TestMethod]
        public void TestStructWithPrivateNestedAbstractClassUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithPrivateNestedAbstractClass));
        }

        [TestMethod]
        public void TestStructWithPublicNestedAbstractClassUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithPublicNestedAbstractClass));
        }
    }
}
