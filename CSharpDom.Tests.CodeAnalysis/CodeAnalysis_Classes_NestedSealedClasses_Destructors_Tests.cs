using CSharpDom.TestTarget.Classes.NestedSealedClasses.Destructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedSealedClasses_Destructors_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestClassWithNestedSealedClassWithDestructorWith1AttributeUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithDestructorWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithDestructorWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithDestructorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithDestructorWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithDestructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithDestructorUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithDestructor));
        }
    }
}
