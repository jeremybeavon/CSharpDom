using CSharpDom.TestTarget.Structs.NestedStaticClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedStaticClasses_Properties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStructWithNestedStaticClassWithInternalPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithInternalProperty));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithPrivatePropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithPublicPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithPublicProperty));
        }
    }
}
