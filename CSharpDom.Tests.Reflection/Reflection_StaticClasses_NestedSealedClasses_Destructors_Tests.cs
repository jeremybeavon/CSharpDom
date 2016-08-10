using CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Destructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_StaticClasses_NestedSealedClasses_Destructors_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithDestructorWith1AttributeUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithDestructorWith1Attribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithDestructorWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithDestructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithDestructorUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithDestructor));
        }
    }
}
