using CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_AbstractClasses_NestedAbstractClasses_NestedEnums_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithNestedEnumWith1AttributeUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithNestedEnumWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNestedEnumWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithInternalNestedEnumUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithInternalNestedEnum));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithPrivateNestedEnumUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithProtectedNestedEnumUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithProtectedInternalNestedEnumUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithPublicNestedEnumUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithPublicNestedEnum));
        }
    }
}
