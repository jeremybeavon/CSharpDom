using CSharpDom.TestTarget.Classes.Destructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_Destructors_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestClassWithDestructorWith1AttributeUsingReflection()
        {
            TestClassAsync(typeof(ClassWithDestructorWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithDestructorWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithDestructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithDestructorUsingReflection()
        {
            TestClassAsync(typeof(ClassWithDestructor));
        }
    }
}
