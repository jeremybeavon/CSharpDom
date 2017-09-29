using CSharpDom.TestTarget.Classes.NestedClasses.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedClasses_Constructors_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestClassWithNestedClassWithConstructorWith1AttributeUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithConstructorWith1ParameterUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithConstructorWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithConstructorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithConstructorWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithConstructorWith2ParametersUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithInternalConstructorUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithInternalConstructor));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithConstructorWithParametersWithAttributesUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithConstructorWithParametersWithModifiersUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPrivateConstructorUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithPrivateConstructor));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedConstructorUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithProtectedConstructor));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedInternalConstructorUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithProtectedInternalConstructor));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPublicConstructorUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithPublicConstructor));
        }
    }
}
