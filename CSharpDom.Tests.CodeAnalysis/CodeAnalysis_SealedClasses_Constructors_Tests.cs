using CSharpDom.TestTarget.SealedClasses.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_Constructors_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestSealedClassWithConstructorWith1AttributeUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithConstructorWith1ParameterUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public void TestSealedClassWithConstructorWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithConstructorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestSealedClassWithConstructorWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithConstructorWith2ParametersUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public void TestSealedClassWithInternalConstructorUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithInternalConstructor));
        }

        [TestMethod]
        public void TestSealedClassWithConstructorWithParametersWithAttributesUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestSealedClassWithConstructorWithParametersWithModifiersUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestSealedClassWithPrivateConstructorUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithPrivateConstructor));
        }

        [TestMethod]
        public void TestSealedClassWithPublicConstructorUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithPublicConstructor));
        }
    }
}
