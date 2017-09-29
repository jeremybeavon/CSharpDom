using CSharpDom.TestTarget.Classes.NestedSealedClasses.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedSealedClasses_Constructors_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestClassWithNestedSealedClassWithConstructorWith1AttributeUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithConstructorWith1ParameterUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithConstructorWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithConstructorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithConstructorWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithConstructorWith2ParametersUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithInternalConstructorUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithInternalConstructor));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithConstructorWithParametersWithAttributesUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithConstructorWithParametersWithModifiersUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPrivateConstructorUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithPrivateConstructor));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithProtectedConstructorUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedConstructor));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithProtectedInternalConstructorUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedInternalConstructor));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPublicConstructorUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithPublicConstructor));
        }
    }
}
