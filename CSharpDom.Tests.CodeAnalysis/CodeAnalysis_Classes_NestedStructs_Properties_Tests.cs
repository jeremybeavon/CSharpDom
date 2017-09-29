using CSharpDom.TestTarget.Classes.NestedStructs.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedStructs_Properties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestClassWithNestedStructWithInternalPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithInternalProperty));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPrivatePropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithPrivateProperty));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPublicPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithPublicProperty));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithStaticPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithStaticProperty));
        }
    }
}
