using CSharpDom.TestTarget.Structs.NestedAbstractClasses.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedAbstractClasses_Constructors_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStructWithNestedAbstractClassWithConstructorWith1AttributeUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithConstructorWith1ParameterUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithConstructorWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithConstructorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithConstructorWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithConstructorWith2ParametersUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithInternalConstructorUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithInternalConstructor));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithConstructorWithParametersWithAttributesUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithConstructorWithParametersWithModifiersUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPrivateConstructorUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithPrivateConstructor));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedConstructorUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedConstructor));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedInternalConstructorUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedInternalConstructor));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPublicConstructorUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithPublicConstructor));
        }
    }
}
