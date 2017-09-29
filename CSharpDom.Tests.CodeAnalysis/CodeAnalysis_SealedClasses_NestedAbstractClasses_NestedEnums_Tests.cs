using CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_NestedAbstractClasses_NestedEnums_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithNestedEnumWith1AttributeUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithNestedEnumWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNestedEnumWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithInternalNestedEnumUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithInternalNestedEnum));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithPrivateNestedEnumUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithProtectedNestedEnumUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithProtectedInternalNestedEnumUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithPublicNestedEnumUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithPublicNestedEnum));
        }
    }
}
