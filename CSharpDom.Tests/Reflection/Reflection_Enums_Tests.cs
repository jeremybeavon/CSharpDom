using CSharpDom.TestTarget.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Enums_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestEnumWith1AttributeUsingReflection()
        {
            await TestEnumsAsync(typeof(EnumWith1Attribute));
        }

        [TestMethod]
        public async Task TestEnumWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestEnumsAsync(typeof(EnumWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestEnumWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestEnumsAsync(typeof(EnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestInternalEnumUsingReflection()
        {
            await TestEnumsAsync(typeof(InternalEnum));
        }

        [TestMethod]
        public async Task TestPublicEnumUsingReflection()
        {
            await TestEnumsAsync(typeof(PublicEnum));
        }
    }
}
