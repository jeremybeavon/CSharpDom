using CSharpDom.TestTarget.Classes.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_Fields_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestClassWithConstFieldUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithConstField));
        }

        [TestMethod]
        public void TestClassWithInternalFieldUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithInternalField));
        }

        [TestMethod]
        public void TestClassWithNewFieldUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNewField));
        }

        [TestMethod]
        public void TestClassWithNewStaticFieldUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNewStaticField));
        }

        [TestMethod]
        public void TestClassWithNewStaticReadOnlyFieldUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestClassWithNewStaticVolatileFieldUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestClassWithNewVolatileFieldUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestClassWithPrivateFieldUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithPrivateField));
        }

        [TestMethod]
        public void TestClassWithProtectedFieldUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithProtectedField));
        }

        [TestMethod]
        public void TestClassWithProtectedInternalFieldUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestClassWithPublicFieldUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithPublicField));
        }

        [TestMethod]
        public void TestClassWithReadOnlyFieldUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestClassWithStaticFieldUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithStaticField));
        }

        [TestMethod]
        public void TestClassWithStaticReadOnlyFieldUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestClassWithStaticVolatileFieldUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestClassWithVolatileFieldUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithVolatileField));
        }
    }
}
