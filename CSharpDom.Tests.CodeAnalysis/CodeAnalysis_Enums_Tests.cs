using CSharpDom.TestTarget.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Enums_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestEnumWith1AttributeUsingCodeAnalysis()
        {
            await TestEnumsAsync(typeof(EnumWith1Attribute));
        }

        [TestMethod]
        public async Task TestEnumWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestEnumsAsync(typeof(EnumWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestEnumWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestEnumsAsync(typeof(EnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestInternalEnumUsingCodeAnalysis()
        {
            await TestEnumsAsync(typeof(InternalEnum));
        }

        [TestMethod]
        public async Task TestPublicEnumUsingCodeAnalysis()
        {
            await TestEnumsAsync(typeof(PublicEnum));
        }
    }
}
