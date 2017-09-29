using CSharpDom.TestTarget.Classes.Destructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_Destructors_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestClassWithDestructorWith1AttributeUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithDestructorWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithDestructorWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithDestructorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestClassWithDestructorWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithDestructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithDestructorUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithDestructor));
        }
    }
}
