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
            TestClassAsync(typeof(ClassWithNestedStructWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPrivateAutoPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPublicAutoPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithPublicAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithStaticAutoPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithStaticAutoProperty));
        }
    }
}
