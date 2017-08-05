using CSharpDom.TestTarget.Classes.NestedStructs.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedStructs_Properties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestClassWithNestedStructWithInternalPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithInternalProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithPrivatePropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithPrivateProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithPublicPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithPublicProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithStaticPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithStaticProperty));
        }
    }
}
