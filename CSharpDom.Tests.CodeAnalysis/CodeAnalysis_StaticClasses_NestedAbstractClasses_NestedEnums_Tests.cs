using CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_StaticClasses_NestedAbstractClasses_NestedEnums_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithNestedEnumWith1AttributeUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithNestedEnumWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNestedEnumWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithInternalNestedEnumUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithInternalNestedEnum));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithPrivateNestedEnumUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithProtectedNestedEnumUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithProtectedInternalNestedEnumUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithPublicNestedEnumUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithPublicNestedEnum));
        }
    }
}
