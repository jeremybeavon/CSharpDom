using CSharpDom.TestTarget.Structs.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_Constructors_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStructWithConstructorWith1AttributeUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithConstructorWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithConstructorWith1ParameterUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithConstructorWith1Parameter));
        }

        [TestMethod]
        public void TestStructWithConstructorWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithConstructorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStructWithConstructorWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithConstructorWith2ParametersUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithConstructorWith2Parameters));
        }

        [TestMethod]
        public void TestStructWithInternalConstructorUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithInternalConstructor));
        }

        [TestMethod]
        public void TestStructWithConstructorWithParametersWithAttributesUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestStructWithConstructorWithParametersWithModifiersUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestStructWithPrivateConstructorUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithPrivateConstructor));
        }

        [TestMethod]
        public void TestStructWithPublicConstructorUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithPublicConstructor));
        }
    }
}
