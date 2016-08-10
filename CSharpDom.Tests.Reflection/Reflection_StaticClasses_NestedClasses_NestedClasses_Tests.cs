using CSharpDom.TestTarget.StaticClasses.NestedClasses.NestedClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_StaticClasses_NestedClasses_NestedClasses_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedClassWithNestedClassWith1AttributeUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedClassWith1Attribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNestedClassWith1GenericParameterUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedClassWith1GenericParameter));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNestedClassWith1ImplementedInterfaceUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedClassWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNestedClassWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNestedClassWith2GenericParametersUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedClassWith2GenericParameters));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNestedClassWith2ImplementedInterfacesUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNestedClassWithBaseClassUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedClassWithBaseClass));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNestedClassWithGenericParameterBaseClassConstraintUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNestedClassWithGenericParameterClassConstraintUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNestedClassWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNestedClassWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNestedClassWithGenericParameterInterfaceConstraintUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNestedClassWithGenericParameterStructConstraintUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNestedClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithInternalNestedClassUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithInternalNestedClass));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPrivateNestedClassUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPrivateNestedClass));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedNestedClassUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedNestedClass));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedInternalNestedClassUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedInternalNestedClass));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPublicNestedClassUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPublicNestedClass));
        }
    }
}
