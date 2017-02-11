using CSharpDom.TestTarget.Classes.NestedStaticClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedStaticClasses_Fields_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestClassWithNestedStaticClassWithConstFieldUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStaticClassWithConstField));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithInternalFieldUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStaticClassWithInternalField));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithPrivateFieldUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStaticClassWithPrivateField));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithPublicFieldUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStaticClassWithPublicField));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithReadOnlyFieldUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStaticClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithVolatileFieldUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStaticClassWithVolatileField));
        }
    }
}
