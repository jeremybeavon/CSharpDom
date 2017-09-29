using CSharpDom.TestTarget.Structs.NestedStaticClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedStaticClasses_Properties_AutoProperties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStructWithNestedStaticClassWithInternalAutoPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithPrivateAutoPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithPublicAutoPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithPublicAutoProperty));
        }
    }
}
