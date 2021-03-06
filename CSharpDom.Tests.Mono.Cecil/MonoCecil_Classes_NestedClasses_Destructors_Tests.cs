using CSharpDom.TestTarget.Classes.NestedClasses.Destructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedClasses_Destructors_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestClassWithNestedClassWithDestructorWith1AttributeUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithDestructorWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithDestructorWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithDestructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithDestructorUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithDestructor));
        }
    }
}
