using CSharpDom.TestTarget.StaticClasses.NestedClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_StaticClasses_NestedClasses_Fields_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedClassWithConstFieldUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithConstField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithInternalFieldUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithInternalField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewFieldUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewStaticFieldUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewStaticField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewStaticReadOnlyFieldUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewStaticVolatileFieldUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewVolatileFieldUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPrivateFieldUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPrivateField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedFieldUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedInternalFieldUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPublicFieldUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPublicField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithReadOnlyFieldUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithStaticFieldUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithStaticField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithStaticReadOnlyFieldUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithStaticVolatileFieldUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithVolatileFieldUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithVolatileField));
        }
    }
}
