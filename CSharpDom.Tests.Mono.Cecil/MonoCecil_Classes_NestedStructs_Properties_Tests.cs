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
            TestClassAsync(typeof(ClassWithNestedStructWithInternalProperty));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPrivatePropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithPrivateProperty));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPublicPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithPublicProperty));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithStaticPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithStaticProperty));
        }
    }
}
