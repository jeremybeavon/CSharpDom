using CSharpDom.TestTarget.Classes.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_Constructors_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestClassWithConstructorWithParametersWithAttributesUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestClassWithConstructorWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithConstructorWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithConstructorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestClassWithConstructorWith1AttributeUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithConstructorWithParametersWithModifiersUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestClassWithConstructorWith2ParametersUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public void TestClassWithConstructorWith1ParameterUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public void TestClassWithPublicConstructorUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithPublicConstructor));
        }

        [TestMethod]
        public void TestClassWithProtectedConstructorUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithProtectedConstructor));
        }

        [TestMethod]
        public void TestClassWithProtectedInternalConstructorUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithProtectedInternalConstructor));
        }

        [TestMethod]
        public void TestClassWithPrivateConstructorUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithPrivateConstructor));
        }

        [TestMethod]
        public void TestClassWithInternalConstructorUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithInternalConstructor));
        }
    }
}
