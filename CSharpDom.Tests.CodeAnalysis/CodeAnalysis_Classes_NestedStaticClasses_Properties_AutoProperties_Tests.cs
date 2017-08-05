using CSharpDom.TestTarget.Classes.NestedStaticClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedStaticClasses_Properties_AutoProperties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithInternalAutoPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithPrivateAutoPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithPublicAutoPropertyUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithPublicAutoProperty));
        }
    }
}
