using CSharpDom.TestTarget.Structs.NestedClasses.Destructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedClasses_Destructors_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStructWithNestedClassWithDestructorWith1AttributeUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithDestructorWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithDestructorWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithDestructorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithDestructorWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithDestructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithDestructorUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithDestructor));
        }
    }
}
