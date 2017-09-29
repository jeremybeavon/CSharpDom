using CSharpDom.TestTarget.Structs.NestedStructs.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedStructs_Methods_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStructWithNestedStructWithMethodWith1AttributeUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithMethodWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithMethodWith1GenericParameterUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithMethodWith1ReturnAttributeUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithMethodWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithMethodWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithMethodWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithMethodWith2GenericParametersUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithMethodWith2ReturnAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithMethodWith2ReturnAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithMethodWith2ReturnAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithMethodWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithMethodWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithMethodWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithMethodWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithMethodWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithMethodWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithMethodWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithMethodWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithMethodWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithMethodWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithInternalMethodUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithInternalMethod));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithMethodWithParametersWithAttributesUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithMethodWithParametersWithModifiersUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPrivateMethodUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithPrivateMethod));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPublicMethodUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithPublicMethod));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithStaticMethodUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithStaticMethod));
        }
    }
}
