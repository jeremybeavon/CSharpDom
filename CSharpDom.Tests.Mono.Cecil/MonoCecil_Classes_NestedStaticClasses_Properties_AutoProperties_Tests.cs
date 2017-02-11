using CSharpDom.TestTarget.Classes.NestedStaticClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedStaticClasses_Properties_AutoProperties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestClassWithNestedStaticClassWithInternalAutoPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStaticClassWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithPrivateAutoPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStaticClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithPublicAutoPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStaticClassWithPublicAutoProperty));
        }
    }
}
