using CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Destructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_StaticClasses_NestedSealedClasses_Destructors_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithDestructorWith1AttributeUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithDestructorWith1Attribute));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithDestructorWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithDestructorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithDestructorWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithDestructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithDestructorUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithDestructor));
        }
    }
}
