using CSharpDom.TestTarget.StaticClasses.NestedClasses.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_StaticClasses_NestedClasses_NestedEnums_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNestedEnumWith1AttributeUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNestedEnumWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedEnumWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithInternalNestedEnumUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithInternalNestedEnum));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithPrivateNestedEnumUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithProtectedNestedEnumUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithProtectedInternalNestedEnumUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithPublicNestedEnumUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPublicNestedEnum));
        }
    }
}
