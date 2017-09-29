using CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_StaticClasses_NestedAbstractClasses_NestedEnums_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithNestedEnumWith1AttributeUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithNestedEnumWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNestedEnumWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithInternalNestedEnumUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithInternalNestedEnum));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithPrivateNestedEnumUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithProtectedNestedEnumUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithProtectedInternalNestedEnumUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithPublicNestedEnumUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithPublicNestedEnum));
        }
    }
}
