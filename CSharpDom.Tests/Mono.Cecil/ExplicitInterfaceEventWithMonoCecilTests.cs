using CSharpDom.Common;
using CSharpDom.Mono.Cecil;
using CSharpDom.Mono.Cecil.Internal;
using CSharpDom.Tests.Common;
using CSharpDom.TestTarget.Classes;
using CSharpDom.TestTarget.Classes.Events.ExplicitInterfaceEvents;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mono.Cecil;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public class ExplicitInterfaceEventWithMonoCecilTests : AbstractSolutionTests<ProjectWithMonoCecil>
    {
        private ISolution<ProjectWithMonoCecil> solution;

        public override ISolution<ProjectWithMonoCecil> Solution
        {
            get { return solution; }
        }
        
        [TestInitialize]
        public void SetUp()
        {
            solution = new AssemblyWithMonoCecil(AssemblyDefinition.ReadAssembly(typeof(PublicClass).Assembly.Location)).AsSolution();
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithExplicitInterfaceEvent()
        {
            await TestClassAsync(typeof(ClassWithExplicitInterfaceEvent));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithExplicitInterfaceEventWith1AccessorAttribute()
        {
            await TestClassAsync(typeof(ClassWithExplicitInterfaceEventWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithExplicitInterfaceEventWith1Attribute()
        {
            await TestClassAsync(typeof(ClassWithExplicitInterfaceEventWith1Attribute));
        }
        
        [TestMethod]
        public async Task TestClassWithMonoCecilWithExplicitInterfaceEventWith2AccessorAttributesIn2AttributeGroups()
        {
            await TestClassAsync(typeof(ClassWithExplicitInterfaceEventWith2AccessorAttributesIn2AttributeGroups));
        }
        
        [TestMethod]
        public async Task TestClassWithMonoCecilWithExplicitInterfaceEventWith2AttributesIn2AttributeGroups()
        {
            await TestClassAsync(typeof(ClassWithExplicitInterfaceEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithExplicitInterfaceEventWithGenericDelegate()
        {
            await TestClassAsync(typeof(ClassWithExplicitInterfaceEventWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestClassWithMonoCecilWithExplicitInterfaceEventWithGenericInterface()
        {
            await TestClassAsync(typeof(ClassWithExplicitInterfaceEventWithGenericInterface));
        }
    }
}
