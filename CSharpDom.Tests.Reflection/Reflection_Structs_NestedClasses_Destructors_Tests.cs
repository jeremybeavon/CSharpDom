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
            TestStruct(typeof(StructWithNestedClassWithDestructorWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithDestructorWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithDestructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithDestructorUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithDestructor));
        }
    }
}
