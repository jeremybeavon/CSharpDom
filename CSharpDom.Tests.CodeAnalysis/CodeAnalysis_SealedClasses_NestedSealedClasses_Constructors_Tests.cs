using CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_NestedSealedClasses_Constructors_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithConstructorWith1AttributeUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithConstructorWith1ParameterUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithConstructorWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithConstructorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithConstructorWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithConstructorWith2ParametersUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithInternalConstructorUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithInternalConstructor));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithConstructorWithParametersWithAttributesUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithConstructorWithParametersWithModifiersUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithPrivateConstructorUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithPrivateConstructor));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithProtectedConstructorUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithProtectedConstructor));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithProtectedInternalConstructorUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithProtectedInternalConstructor));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithPublicConstructorUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithPublicConstructor));
        }
    }
}
