using CSharpDom.TestTarget.StaticClasses.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_StaticClasses_NestedEnums_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedEnumWith1AttributeUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedEnumWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedEnumWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStaticClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithInternalNestedEnumUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithInternalNestedEnum));
        }

        [TestMethod]
        public void TestStaticClassWithPrivateNestedEnumUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public void TestStaticClassWithProtectedNestedEnumUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public void TestStaticClassWithProtectedInternalNestedEnumUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public void TestStaticClassWithPublicNestedEnumUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithPublicNestedEnum));
        }
    }
}
