using CSharpDom.TestTarget.Structs.NestedStructs.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedStructs_Constructors_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStructWithNestedStructWithConstructorWith1AttributeUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithConstructorWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithConstructorWith1ParameterUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithConstructorWith1Parameter));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithConstructorWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithConstructorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithConstructorWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithConstructorWith2ParametersUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithConstructorWith2Parameters));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithInternalConstructorUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithInternalConstructor));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithConstructorWithParametersWithAttributesUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithConstructorWithParametersWithModifiersUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPrivateConstructorUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithPrivateConstructor));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPublicConstructorUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithPublicConstructor));
        }
    }
}
