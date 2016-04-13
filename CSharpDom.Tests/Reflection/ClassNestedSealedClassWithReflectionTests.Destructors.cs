using CSharpDom.TestTarget.Classes.NestedSealedClasses.Destructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    public sealed partial class ClassNestedSealedClassWithReflectionTests
    {

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithDestructorWith1Attribute()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithDestructorWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithDestructorWith2AttributesIn1AttributeGroup()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithDestructorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithDestructorWith2AttributesIn2AttributeGroups()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithDestructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithDestructor()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithDestructor));
        }
    }
}