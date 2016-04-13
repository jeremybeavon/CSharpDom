using CSharpDom.Common;
using CSharpDom.Reflection;
using CSharpDom.Reflection.Internal;
using CSharpDom.Tests.Common;
using CSharpDom.TestTarget.Classes;
using CSharpDom.TestTarget.Classes.NestedStaticClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed partial class ClassNestedStaticClassWithReflectionTests : AbstractSolutionTests<ProjectWithReflection>
    {
        private ISolution<ProjectWithReflection> solution;

        public override ISolution<ProjectWithReflection> Solution
        {
            get { return solution; }
        }

        [TestInitialize]
        public void SetUp()
        {
            solution = new AssemblyWithReflection(typeof(PublicClass).Assembly).AsSolution();
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedStaticClassWith1Attribute()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedStaticClassWith1GenericParameter()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedStaticClassWith2AttributesIn1AttributeGroup()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedStaticClassWith2AttributesIn2AttributeGroups()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedStaticClassWith2GenericParameters()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedStaticClassWithGenericParameterClassAndEmptyConstructorConstraints()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedStaticClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedStaticClassWithGenericParameterBaseClassConstraint()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedStaticClassWithGenericParameterClassConstraint()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedStaticClassWithGenericParameterEmptyConstructorConstraint()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedStaticClassWithGenericParameterGenericParameterConstraint()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedStaticClassWithGenericParameterInterfaceConstraint()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedStaticClassWithGenericParameterStructConstraint()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithInternalNestedStaticClass()
        {
            await TestClassAsync(typeof(ClassWithInternalNestedStaticClass));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithPrivateNestedStaticClass()
        {
            await TestClassAsync(typeof(ClassWithPrivateNestedStaticClass));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithProtectedNestedStaticClass()
        {
            await TestClassAsync(typeof(ClassWithProtectedNestedStaticClass));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithProtectedInternalNestedStaticClass()
        {
            await TestClassAsync(typeof(ClassWithProtectedInternalNestedStaticClass));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithPublicNestedStaticClass()
        {
            await TestClassAsync(typeof(ClassWithPublicNestedStaticClass));
        }
    }
}