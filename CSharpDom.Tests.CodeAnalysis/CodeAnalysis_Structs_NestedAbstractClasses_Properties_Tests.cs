using CSharpDom.TestTarget.Structs.NestedAbstractClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedAbstractClasses_Properties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithInternalPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithInternalProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNewPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNewProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNewStaticPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNewStaticProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNewVirtualPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNewVirtualProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithOverridePropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithOverrideProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithPrivatePropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithPrivateProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithProtectedPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithProtectedInternalPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithPublicPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithPublicProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithSealedOverridePropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithStaticPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithStaticProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithVirtualPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithVirtualProperty));
        }
    }
}
