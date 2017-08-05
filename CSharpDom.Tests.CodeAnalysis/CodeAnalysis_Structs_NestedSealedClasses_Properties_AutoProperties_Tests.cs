using CSharpDom.TestTarget.Structs.NestedSealedClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedSealedClasses_Properties_AutoProperties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithInternalAutoPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNewAutoPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNewAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNewStaticAutoPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithOverrideAutoPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithPrivateAutoPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithProtectedAutoPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithProtectedInternalAutoPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithPublicAutoPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithPublicAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithSealedOverrideAutoPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithStaticAutoPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithStaticAutoProperty));
        }
    }
}
