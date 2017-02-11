using CSharpDom.TestTarget.Classes.NestedStaticClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedStaticClasses_Properties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestClassWithNestedStaticClassWithInternalPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStaticClassWithInternalProperty));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithPrivatePropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStaticClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithPublicPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStaticClassWithPublicProperty));
        }
    }
}
