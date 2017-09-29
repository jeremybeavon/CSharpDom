using CSharpDom.TestTarget.Structs.NestedSealedClasses.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedSealedClasses_Constructors_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStructWithNestedSealedClassWithConstructorWith1AttributeUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithConstructorWith1ParameterUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithConstructorWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithConstructorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithConstructorWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithConstructorWith2ParametersUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithInternalConstructorUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithInternalConstructor));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithConstructorWithParametersWithAttributesUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithConstructorWithParametersWithModifiersUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPrivateConstructorUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithPrivateConstructor));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedConstructorUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedConstructor));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedInternalConstructorUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedInternalConstructor));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPublicConstructorUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithPublicConstructor));
        }
    }
}
