using CSharpDom.TestTarget.Classes.Destructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_Destructors_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithDestructorWith1AttributeUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithDestructorWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithDestructorWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithDestructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithDestructorUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithDestructor));
        }
    }
}
