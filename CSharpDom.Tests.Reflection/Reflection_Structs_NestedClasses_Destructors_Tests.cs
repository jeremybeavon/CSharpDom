using CSharpDom.TestTarget.Structs.NestedClasses.Destructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedClasses_Destructors_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStructWithNestedClassWithDestructorWith1AttributeUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithDestructorWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithDestructorWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithDestructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithDestructorUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithDestructor));
        }
    }
}
