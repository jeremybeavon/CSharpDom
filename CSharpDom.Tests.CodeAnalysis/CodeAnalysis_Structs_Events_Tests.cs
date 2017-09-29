using CSharpDom.TestTarget.Structs.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_Events_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStructWithInternalEventUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithInternalEvent));
        }

        [TestMethod]
        public void TestStructWithPrivateEventUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithPrivateEvent));
        }

        [TestMethod]
        public void TestStructWithPublicEventUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithPublicEvent));
        }

        [TestMethod]
        public void TestStructWithStaticEventUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithStaticEvent));
        }
    }
}
