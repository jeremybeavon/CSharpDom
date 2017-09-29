using CSharpDom.TestTarget.Classes.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedEnums_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestClassWithNestedEnumWith1AttributeUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedEnumWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedEnumWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithPrivateNestedEnumUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public void TestClassWithProtectedNestedEnumUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public void TestClassWithProtectedInternalNestedEnumUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public void TestClassWithInternalNestedEnumUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithInternalNestedEnum));
        }

        [TestMethod]
        public void TestClassWithPublicNestedEnumUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithPublicNestedEnum));
        }
    }
}
