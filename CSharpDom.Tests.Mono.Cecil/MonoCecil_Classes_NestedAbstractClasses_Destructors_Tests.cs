using CSharpDom.TestTarget.Classes.NestedAbstractClasses.Destructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedAbstractClasses_Destructors_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithDestructorWith1AttributeUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithDestructorWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithDestructorWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithDestructorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithDestructorWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithDestructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithDestructorUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithDestructor));
        }
    }
}
