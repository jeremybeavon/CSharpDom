using CSharpDom.TestTarget.Classes.Destructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_Destructors_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestClassWithDestructorWith1AttributeUsingMonoCecil()
        {
            TestClass(typeof(ClassWithDestructorWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithDestructorWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClass(typeof(ClassWithDestructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithDestructorUsingMonoCecil()
        {
            TestClass(typeof(ClassWithDestructor));
        }
    }
}
