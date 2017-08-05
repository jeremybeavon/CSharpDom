using CSharpDom.TestTarget.Structs.NestedClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedClasses_Properties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStructWithNestedClassWithInternalPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithInternalProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNewPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNewProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNewStaticPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNewStaticProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNewVirtualPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNewVirtualProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithOverridePropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithOverrideProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithPrivatePropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithPrivateProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithProtectedPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithProtectedProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithProtectedInternalPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithPublicPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithPublicProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithSealedOverridePropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithStaticPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithStaticProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithVirtualPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithVirtualProperty));
        }
    }
}
