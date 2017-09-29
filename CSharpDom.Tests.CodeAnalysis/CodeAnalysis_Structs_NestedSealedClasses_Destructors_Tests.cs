using CSharpDom.TestTarget.Structs.NestedSealedClasses.Destructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedSealedClasses_Destructors_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStructWithNestedSealedClassWithDestructorWith1AttributeUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithDestructorWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithDestructorWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithDestructorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithDestructorWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithDestructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithDestructorUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithDestructor));
        }
    }
}
