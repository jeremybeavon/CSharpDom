using CSharpDom.TestTarget.Structs.NestedStructs.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedStructs_Properties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStructWithNestedStructWithInternalPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithInternalProperty));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPrivatePropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithPrivateProperty));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPublicPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithPublicProperty));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithStaticPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithStaticProperty));
        }
    }
}
