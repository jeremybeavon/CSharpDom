using CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Destructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_SealedClasses_NestedSealedClasses_Destructors_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithDestructorWith1AttributeUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithDestructorWith1Attribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithDestructorWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithDestructorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithDestructorWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithDestructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithDestructorUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithDestructor));
        }
    }
}
