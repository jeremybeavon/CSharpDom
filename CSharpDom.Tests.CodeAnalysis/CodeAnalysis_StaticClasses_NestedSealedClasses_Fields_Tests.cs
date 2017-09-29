using CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_StaticClasses_NestedSealedClasses_Fields_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithConstFieldUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithConstField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithInternalFieldUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithInternalField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithNewFieldUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNewField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithNewStaticFieldUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNewStaticField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithNewStaticReadOnlyFieldUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithNewStaticVolatileFieldUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithNewVolatileFieldUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithPrivateFieldUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithPrivateField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithProtectedFieldUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithProtectedField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithProtectedInternalFieldUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithPublicFieldUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithPublicField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithReadOnlyFieldUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithStaticFieldUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithStaticField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithStaticReadOnlyFieldUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithStaticVolatileFieldUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithVolatileFieldUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithVolatileField));
        }
    }
}
