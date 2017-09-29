using CSharpDom.TestTarget.Structs.NestedStructs.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedStructs_NestedEnums_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStructWithNestedStructWithNestedEnumWith1AttributeUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithNestedEnumWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithNestedEnumWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithNestedEnumWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithInternalNestedEnumUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithInternalNestedEnum));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPrivateNestedEnumUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithPrivateNestedEnum));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPublicNestedEnumUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithPublicNestedEnum));
        }
    }
}
