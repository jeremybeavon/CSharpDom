using CSharpDom.TestTarget.Classes.Destructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_Destructors_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestClassWithDestructorWith1AttributeUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithDestructorWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithDestructorWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithDestructorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithDestructorWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithDestructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithDestructorUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithDestructor));
        }
    }
}
