using CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Destructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_StaticClasses_NestedSealedClasses_Destructors_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithDestructorWith1AttributeUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithDestructorWith1Attribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithDestructorWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithDestructorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithDestructorWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithDestructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithDestructorUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithDestructor));
        }
    }
}
