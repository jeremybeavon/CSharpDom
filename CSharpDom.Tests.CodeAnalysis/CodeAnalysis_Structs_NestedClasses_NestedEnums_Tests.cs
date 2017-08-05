using CSharpDom.TestTarget.Structs.NestedClasses.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedClasses_NestedEnums_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedEnumWith1AttributeUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedEnumWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedEnumWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithInternalNestedEnumUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithInternalNestedEnum));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithPrivateNestedEnumUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithProtectedNestedEnumUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithProtectedInternalNestedEnumUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithPublicNestedEnumUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithPublicNestedEnum));
        }
    }
}
