using CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_StaticClasses_NestedAbstractClasses_Fields_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithConstFieldUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithConstField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithInternalFieldUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithInternalField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithNewFieldUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNewField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithNewStaticFieldUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNewStaticField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithNewStaticReadOnlyFieldUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithNewStaticVolatileFieldUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithNewVolatileFieldUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithPrivateFieldUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithPrivateField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithProtectedFieldUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithProtectedField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithProtectedInternalFieldUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithPublicFieldUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithPublicField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithReadOnlyFieldUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithStaticFieldUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithStaticField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithStaticReadOnlyFieldUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithStaticVolatileFieldUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithVolatileFieldUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithVolatileField));
        }
    }
}
