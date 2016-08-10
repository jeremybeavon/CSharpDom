using CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.Destructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_StaticClasses_NestedAbstractClasses_Destructors_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithDestructorWith1AttributeUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithDestructorWith1Attribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithDestructorWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithDestructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithDestructorUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithDestructor));
        }
    }
}
