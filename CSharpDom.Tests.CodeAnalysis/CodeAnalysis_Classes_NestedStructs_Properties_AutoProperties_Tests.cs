using CSharpDom.TestTarget.Classes.NestedStructs.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedStructs_Properties_AutoProperties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestClassWithNestedStructWithInternalAutoPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPrivateAutoPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPublicAutoPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithPublicAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithStaticAutoPropertyUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithStaticAutoProperty));
        }
    }
}
