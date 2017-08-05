using CSharpDom.TestTarget.SealedClasses.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_NestedEnums_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedEnumWith1AttributeUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedEnumWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedEnumWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithInternalNestedEnumUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithInternalNestedEnum));
        }

        [TestMethod]
        public async Task TestSealedClassWithPrivateNestedEnumUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public async Task TestSealedClassWithProtectedNestedEnumUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public async Task TestSealedClassWithProtectedInternalNestedEnumUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public async Task TestSealedClassWithPublicNestedEnumUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithPublicNestedEnum));
        }
    }
}
