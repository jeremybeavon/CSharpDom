using CSharpDom.TestTarget.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Enums_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestEnumWith1AttributeUsingCodeAnalysis()
        {
            TestEnumsAsync(typeof(EnumWith1Attribute));
        }

        [TestMethod]
        public void TestEnumWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestEnumsAsync(typeof(EnumWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestEnumWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestEnumsAsync(typeof(EnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestInternalEnumUsingCodeAnalysis()
        {
            TestEnumsAsync(typeof(InternalEnum));
        }

        [TestMethod]
        public void TestPublicEnumUsingCodeAnalysis()
        {
            TestEnumsAsync(typeof(PublicEnum));
        }
    }
}
