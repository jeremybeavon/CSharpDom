using CSharpDom.TestTarget.Structs.NestedStructs.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedStructs_Properties_AutoProperties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStructWithNestedStructWithInternalAutoPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPrivateAutoPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPublicAutoPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithPublicAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithStaticAutoPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithStaticAutoProperty));
        }
    }
}
