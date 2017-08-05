using CSharpDom.TestTarget.Classes.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedEnums_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestClassWithNestedEnumWith1AttributeUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedEnumWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedEnumWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithPrivateNestedEnumUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public async Task TestClassWithProtectedNestedEnumUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public async Task TestClassWithProtectedInternalNestedEnumUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public async Task TestClassWithInternalNestedEnumUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithInternalNestedEnum));
        }

        [TestMethod]
        public async Task TestClassWithPublicNestedEnumUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithPublicNestedEnum));
        }
    }
}
