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
            TestClassAsync(typeof(ClassWithNestedStaticClassWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithPrivateAutoPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithPublicAutoPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithPublicAutoProperty));
        }
    }
}
