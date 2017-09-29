using CSharpDom.TestTarget.AbstractClasses.NestedClasses.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_AbstractClasses_NestedClasses_Constructors_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedClassWithConstructorWith1AttributeUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithConstructorWith1ParameterUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithConstructorWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithConstructorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithConstructorWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithConstructorWith2ParametersUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithInternalConstructorUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithInternalConstructor));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithConstructorWithParametersWithAttributesUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithConstructorWithParametersWithModifiersUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithPrivateConstructorUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithPrivateConstructor));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithProtectedConstructorUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithProtectedConstructor));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithProtectedInternalConstructorUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithProtectedInternalConstructor));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithPublicConstructorUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithPublicConstructor));
        }
    }
}
