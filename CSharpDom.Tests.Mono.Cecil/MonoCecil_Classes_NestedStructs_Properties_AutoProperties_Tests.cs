using CSharpDom.TestTarget.Classes.NestedStructs.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedStructs_Properties_AutoProperties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestClassWithNestedStructWithInternalAutoPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStructWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPrivateAutoPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStructWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPublicAutoPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStructWithPublicAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithStaticAutoPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStructWithStaticAutoProperty));
        }
    }
}
