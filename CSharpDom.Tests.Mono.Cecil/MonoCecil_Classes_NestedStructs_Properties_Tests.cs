using CSharpDom.TestTarget.Classes.NestedStructs.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedStructs_Properties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestClassWithNestedStructWithInternalPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStructWithInternalProperty));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPrivatePropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStructWithPrivateProperty));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPublicPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStructWithPublicProperty));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithStaticPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStructWithStaticProperty));
        }
    }
}
