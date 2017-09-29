using CSharpDom.TestTarget.SealedClasses.NestedStructs.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_NestedStructs_NestedEnums_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedStructWithNestedEnumWith1AttributeUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithNestedEnumWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedEnumWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithNestedEnumWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithInternalNestedEnumUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithInternalNestedEnum));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithPrivateNestedEnumUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithPrivateNestedEnum));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithPublicNestedEnumUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithPublicNestedEnum));
        }
    }
}
