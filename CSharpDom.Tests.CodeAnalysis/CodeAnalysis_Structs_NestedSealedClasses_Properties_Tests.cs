using CSharpDom.TestTarget.Structs.NestedSealedClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedSealedClasses_Properties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithInternalPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithInternalProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNewPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNewProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNewStaticPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNewStaticProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithOverridePropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithOverrideProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithPrivatePropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithPrivateProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithProtectedPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithProtectedInternalPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithPublicPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithPublicProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithSealedOverridePropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithStaticPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithStaticProperty));
        }
    }
}
