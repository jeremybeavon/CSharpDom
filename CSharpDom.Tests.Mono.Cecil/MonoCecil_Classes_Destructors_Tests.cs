using CSharpDom.TestTarget.Classes.Destructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_Destructors_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestClassWithDestructorWith1AttributeUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithDestructorWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithDestructorWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithDestructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithDestructorUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithDestructor));
        }
    }
}
