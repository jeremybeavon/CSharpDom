using CSharpDom.TestTarget.Structs.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedEnums_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStructWithNestedEnumWith1AttributeUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedEnumWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedEnumWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStructWithNestedEnumWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithInternalNestedEnumUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithInternalNestedEnum));
        }

        [TestMethod]
        public void TestStructWithPrivateNestedEnumUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithPrivateNestedEnum));
        }

        [TestMethod]
        public void TestStructWithPublicNestedEnumUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithPublicNestedEnum));
        }
    }
}
