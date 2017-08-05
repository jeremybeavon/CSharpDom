using CSharpDom.TestTarget.Structs.NestedAbstractClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedAbstractClasses_Properties_AutoProperties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithInternalAutoPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNewAutoPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNewAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNewStaticAutoPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNewVirtualAutoPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNewVirtualAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithOverrideAutoPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithPrivateAutoPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithProtectedAutoPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithProtectedInternalAutoPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithPublicAutoPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithPublicAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithSealedOverrideAutoPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithStaticAutoPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithStaticAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithVirtualAutoPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithVirtualAutoProperty));
        }
    }
}
