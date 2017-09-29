using CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_AbstractClasses_NestedAbstractClasses_Constructors_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithConstructorWith1AttributeUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithConstructorWith1ParameterUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithConstructorWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithConstructorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithConstructorWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithConstructorWith2ParametersUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithInternalConstructorUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithInternalConstructor));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithConstructorWithParametersWithAttributesUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithConstructorWithParametersWithModifiersUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithPrivateConstructorUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithPrivateConstructor));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithProtectedConstructorUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithProtectedConstructor));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithProtectedInternalConstructorUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithProtectedInternalConstructor));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithPublicConstructorUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithPublicConstructor));
        }
    }
}
