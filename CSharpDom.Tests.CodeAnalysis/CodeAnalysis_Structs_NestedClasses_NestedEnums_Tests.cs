using CSharpDom.TestTarget.Structs.NestedClasses.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedClasses_NestedEnums_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStructWithNestedClassWithNestedEnumWith1AttributeUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedEnumWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNestedEnumWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithInternalNestedEnumUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithInternalNestedEnum));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPrivateNestedEnumUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedNestedEnumUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedInternalNestedEnumUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPublicNestedEnumUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithPublicNestedEnum));
        }
    }
}
