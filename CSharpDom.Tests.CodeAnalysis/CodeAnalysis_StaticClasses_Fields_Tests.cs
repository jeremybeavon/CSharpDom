using CSharpDom.TestTarget.StaticClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_StaticClasses_Fields_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStaticClassWithConstFieldUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithConstField));
        }

        [TestMethod]
        public void TestStaticClassWithInternalFieldUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithInternalField));
        }

        [TestMethod]
        public void TestStaticClassWithPrivateFieldUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithPrivateField));
        }

        [TestMethod]
        public void TestStaticClassWithPublicFieldUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithPublicField));
        }

        [TestMethod]
        public void TestStaticClassWithReadOnlyFieldUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestStaticClassWithVolatileFieldUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithVolatileField));
        }
    }
}
