using CSharpDom.TestTarget.StaticClasses.NestedClasses.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_StaticClasses_NestedClasses_Constructors_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedClassWithConstructorWith1AttributeUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithConstructorWith1ParameterUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithConstructorWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithConstructorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithConstructorWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithConstructorWith2ParametersUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithInternalConstructorUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithInternalConstructor));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithConstructorWithParametersWithAttributesUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithConstructorWithParametersWithModifiersUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPrivateConstructorUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPrivateConstructor));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedConstructorUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedConstructor));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedInternalConstructorUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedInternalConstructor));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPublicConstructorUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPublicConstructor));
        }
    }
}
