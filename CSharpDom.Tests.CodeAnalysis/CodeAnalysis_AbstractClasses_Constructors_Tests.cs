using CSharpDom.TestTarget.AbstractClasses.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_AbstractClasses_Constructors_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestAbstractClassWithConstructorWith1AttributeUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithConstructorWith1ParameterUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public void TestAbstractClassWithConstructorWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithConstructorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestAbstractClassWithConstructorWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithConstructorWith2ParametersUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public void TestAbstractClassWithInternalConstructorUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithInternalConstructor));
        }

        [TestMethod]
        public void TestAbstractClassWithConstructorWithParametersWithAttributesUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestAbstractClassWithConstructorWithParametersWithModifiersUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestAbstractClassWithPrivateConstructorUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithPrivateConstructor));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedConstructorUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithProtectedConstructor));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedInternalConstructorUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithProtectedInternalConstructor));
        }

        [TestMethod]
        public void TestAbstractClassWithPublicConstructorUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithPublicConstructor));
        }
    }
}
