using CSharpDom.TestTarget.Structs.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_EventProperties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStructWithInternalEventPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithInternalEventProperty));
        }

        [TestMethod]
        public void TestStructWithPrivateEventPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestStructWithPublicEventPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithPublicEventProperty));
        }

        [TestMethod]
        public void TestStructWithStaticEventPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithStaticEventProperty));
        }
    }
}
