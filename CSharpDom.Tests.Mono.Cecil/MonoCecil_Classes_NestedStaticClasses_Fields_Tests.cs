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
            TestClassAsync(typeof(ClassWithNestedStaticClassWithConstField));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithInternalFieldUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithInternalField));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithPrivateFieldUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithPrivateField));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithPublicFieldUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithPublicField));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithReadOnlyFieldUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithVolatileFieldUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithVolatileField));
        }
    }
}
