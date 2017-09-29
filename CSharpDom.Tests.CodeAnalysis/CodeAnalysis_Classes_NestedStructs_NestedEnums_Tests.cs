using CSharpDom.TestTarget.Classes.NestedStructs.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedStructs_NestedEnums_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestClassWithNestedStructWithNestedEnumWith1AttributeUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithNestedEnumWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithNestedEnumWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithNestedEnumWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithInternalNestedEnumUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithInternalNestedEnum));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPrivateNestedEnumUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithPrivateNestedEnum));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPublicNestedEnumUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithPublicNestedEnum));
        }
    }
}
