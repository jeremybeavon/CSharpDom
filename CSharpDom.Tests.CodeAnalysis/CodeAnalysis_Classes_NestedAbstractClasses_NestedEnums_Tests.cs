using CSharpDom.TestTarget.Classes.NestedAbstractClasses.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedAbstractClasses_NestedEnums_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNestedEnumWith1AttributeUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNestedEnumWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNestedEnumWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithInternalNestedEnumUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithInternalNestedEnum));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithPrivateNestedEnumUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithProtectedNestedEnumUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithProtectedInternalNestedEnumUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithPublicNestedEnumUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithPublicNestedEnum));
        }
    }
}
