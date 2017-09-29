using CSharpDom.TestTarget.SealedClasses.NestedClasses.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_NestedClasses_Constructors_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedClassWithConstructorWith1AttributeUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithConstructorWith1ParameterUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithConstructorWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithConstructorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithConstructorWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithConstructorWith2ParametersUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithInternalConstructorUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithInternalConstructor));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithConstructorWithParametersWithAttributesUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithConstructorWithParametersWithModifiersUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPrivateConstructorUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPrivateConstructor));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithProtectedConstructorUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithProtectedConstructor));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithProtectedInternalConstructorUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithProtectedInternalConstructor));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPublicConstructorUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPublicConstructor));
        }
    }
}
