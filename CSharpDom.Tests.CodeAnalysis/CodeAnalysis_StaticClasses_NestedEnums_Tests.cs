using CSharpDom.TestTarget.StaticClasses.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_StaticClasses_NestedEnums_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStaticClassWithNestedEnumWith1AttributeUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedEnumWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedEnumWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStaticClassWithInternalNestedEnumUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithInternalNestedEnum));
        }

        [TestMethod]
        public async Task TestStaticClassWithPrivateNestedEnumUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public async Task TestStaticClassWithProtectedNestedEnumUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public async Task TestStaticClassWithProtectedInternalNestedEnumUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public async Task TestStaticClassWithPublicNestedEnumUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithPublicNestedEnum));
        }
    }
}
