using CSharpDom.TestTarget.Classes.NestedStructs.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedStructs_Constructors_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestClassWithNestedStructWithConstructorWith1AttributeUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithConstructorWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithConstructorWith1ParameterUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithConstructorWith1Parameter));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithConstructorWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithConstructorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithConstructorWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithConstructorWith2ParametersUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithConstructorWith2Parameters));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithInternalConstructorUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithInternalConstructor));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithConstructorWithParametersWithAttributesUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithConstructorWithParametersWithModifiersUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPrivateConstructorUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithPrivateConstructor));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPublicConstructorUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithPublicConstructor));
        }
    }
}
