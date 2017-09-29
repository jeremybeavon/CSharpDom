using CSharpDom.TestTarget.Classes.NestedClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedClasses_Fields_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestClassWithNestedClassWithConstFieldUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithConstField));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithInternalFieldUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithInternalField));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewFieldUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNewField));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewStaticFieldUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNewStaticField));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewStaticReadOnlyFieldUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewStaticVolatileFieldUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewVolatileFieldUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPrivateFieldUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithPrivateField));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedFieldUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithProtectedField));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedInternalFieldUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPublicFieldUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithPublicField));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithReadOnlyFieldUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithStaticFieldUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithStaticField));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithStaticReadOnlyFieldUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithStaticVolatileFieldUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithVolatileFieldUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithVolatileField));
        }
    }
}
