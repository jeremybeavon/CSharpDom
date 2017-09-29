using CSharpDom.TestTarget.Structs.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_Properties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStructWithInternalPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithInternalProperty));
        }

        [TestMethod]
        public void TestStructWithPrivatePropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithPrivateProperty));
        }

        [TestMethod]
        public void TestStructWithPublicPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithPublicProperty));
        }

        [TestMethod]
        public void TestStructWithStaticPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithStaticProperty));
        }
    }
}
