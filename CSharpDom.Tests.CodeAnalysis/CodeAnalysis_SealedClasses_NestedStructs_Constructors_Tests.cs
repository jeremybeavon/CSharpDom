using CSharpDom.TestTarget.SealedClasses.NestedStructs.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_NestedStructs_Constructors_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedStructWithConstructorWith1AttributeUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithConstructorWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithConstructorWith1ParameterUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithConstructorWith1Parameter));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithConstructorWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithConstructorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithConstructorWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithConstructorWith2ParametersUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithConstructorWith2Parameters));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithInternalConstructorUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithInternalConstructor));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithConstructorWithParametersWithAttributesUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithConstructorWithParametersWithModifiersUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithPrivateConstructorUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithPrivateConstructor));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithPublicConstructorUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithPublicConstructor));
        }
    }
}
