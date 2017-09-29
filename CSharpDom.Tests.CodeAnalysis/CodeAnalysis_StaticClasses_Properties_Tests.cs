using CSharpDom.TestTarget.StaticClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_StaticClasses_Properties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStaticClassWithInternalPropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithInternalProperty));
        }

        [TestMethod]
        public void TestStaticClassWithPrivatePropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestStaticClassWithPublicPropertyUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithPublicProperty));
        }
    }
}
