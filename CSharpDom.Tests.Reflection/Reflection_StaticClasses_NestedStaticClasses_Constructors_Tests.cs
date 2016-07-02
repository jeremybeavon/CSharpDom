using CSharpDom.TestTarget.StaticClasses.NestedStaticClasses.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_StaticClasses_NestedStaticClasses_Constructors_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithEventWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }
    }
}
