using CSharpDom.TestTarget.Structs.NestedStaticClasses.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedStaticClasses_NestedEnums_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedEnumWith1AttributeUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedEnumWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedEnumWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithInternalNestedEnumUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithInternalNestedEnum));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithPrivateNestedEnumUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithProtectedNestedEnumUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithProtectedInternalNestedEnumUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithPublicNestedEnumUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithPublicNestedEnum));
        }
    }
}
