using CSharpDom.TestTarget.Structs.NestedClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedClasses_Properties_AutoProperties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStructWithNestedClassWithInternalAutoPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNewAutoPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNewAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNewStaticAutoPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNewVirtualAutoPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNewVirtualAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithOverrideAutoPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithPrivateAutoPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithProtectedAutoPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithProtectedInternalAutoPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithPublicAutoPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithPublicAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithSealedOverrideAutoPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithStaticAutoPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithStaticAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithVirtualAutoPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithVirtualAutoProperty));
        }
    }
}
