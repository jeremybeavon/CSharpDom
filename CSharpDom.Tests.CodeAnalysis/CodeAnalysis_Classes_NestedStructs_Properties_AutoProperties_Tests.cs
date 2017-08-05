using CSharpDom.TestTarget.Classes.NestedStructs.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedStructs_Properties_AutoProperties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestClassWithNestedStructWithInternalAutoPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithPrivateAutoPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithPrivateAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithPublicAutoPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithPublicAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithStaticAutoPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithStaticAutoProperty));
        }
    }
}
