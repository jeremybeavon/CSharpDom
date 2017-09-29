using CSharpDom.TestTarget.Structs.NestedClasses.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedClasses_Constructors_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStructWithNestedClassWithConstructorWith1AttributeUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithConstructorWith1ParameterUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithConstructorWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithConstructorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithConstructorWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithConstructorWith2ParametersUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithInternalConstructorUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithInternalConstructor));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithConstructorWithParametersWithAttributesUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithConstructorWithParametersWithModifiersUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPrivateConstructorUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithPrivateConstructor));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedConstructorUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithProtectedConstructor));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedInternalConstructorUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithProtectedInternalConstructor));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPublicConstructorUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithPublicConstructor));
        }
    }
}
