using CSharpDom.TestTarget.StaticClasses.NestedStaticClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_StaticClasses_NestedStaticClasses_Fields_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithConstFieldUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithConstField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithInternalFieldUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithInternalField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithPrivateFieldUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithPrivateField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithPublicFieldUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithPublicField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithReadOnlyFieldUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithVolatileFieldUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithVolatileField));
        }
    }
}
