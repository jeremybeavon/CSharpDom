using CSharpDom.TestTarget.Classes.NestedAbstractClasses.Destructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedAbstractClasses_Destructors_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestClassWithNestedAbstractClassWithDestructorWith1AttributeUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithDestructorWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithDestructorWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithDestructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithDestructorUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithDestructor));
        }
    }
}
