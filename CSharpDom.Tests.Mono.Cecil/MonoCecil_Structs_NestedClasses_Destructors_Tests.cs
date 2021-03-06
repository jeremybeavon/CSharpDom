using CSharpDom.TestTarget.Structs.NestedClasses.Destructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedClasses_Destructors_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStructWithNestedClassWithDestructorWith1AttributeUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithDestructorWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithDestructorWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithDestructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithDestructorUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithDestructor));
        }
    }
}
