using CSharpDom.TestTarget.Structs.NestedStructs.NestedStructs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedStructs_NestedStructs_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStructWithNestedStructWithNestedStructWith1AttributeUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithNestedStructWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithNestedStructWith1GenericParameterUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithNestedStructWith1GenericParameter));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithNestedStructWith1ImplementedInterfaceUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithNestedStructWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithNestedStructWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithNestedStructWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithNestedStructWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithNestedStructWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithNestedStructWith2GenericParametersUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithNestedStructWith2GenericParameters));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithNestedStructWith2ImplementedInterfacesUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithNestedStructWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithNestedStructWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithNestedStructWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithNestedStructWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithNestedStructWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithNestedStructWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithNestedStructWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithNestedStructWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithNestedStructWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithNestedStructWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithNestedStructWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithNestedStructWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithNestedStructWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithInternalNestedStructUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithInternalNestedStruct));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPrivateNestedStructUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithPrivateNestedStruct));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPublicNestedStructUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithPublicNestedStruct));
        }
    }
}
