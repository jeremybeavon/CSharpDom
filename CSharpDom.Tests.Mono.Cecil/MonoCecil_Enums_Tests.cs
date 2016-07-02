using CSharpDom.TestTarget.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Enums_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestEnumWith1AttributeUsingMonoCecil()
        {
            await TestEnumsAsync(typeof(EnumWith1Attribute));
        }

        [TestMethod]
        public async Task TestEnumWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestEnumsAsync(typeof(EnumWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestEnumWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestEnumsAsync(typeof(EnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestInternalEnumUsingMonoCecil()
        {
            await TestEnumsAsync(typeof(InternalEnum));
        }

        [TestMethod]
        public async Task TestPublicEnumUsingMonoCecil()
        {
            await TestEnumsAsync(typeof(PublicEnum));
        }
    }
}
