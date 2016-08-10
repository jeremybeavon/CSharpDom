using CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_StaticClasses_NestedAbstractClasses_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWith1AttributeUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWith1Attribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWith1GenericParameterUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWith1GenericParameter));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWith1ImplementedInterfaceUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWith2GenericParametersUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWith2GenericParameters));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWith2ImplementedInterfacesUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithBaseClassUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithBaseClass));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithGenericParameterBaseClassConstraintUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithGenericParameterClassConstraintUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithGenericParameterInterfaceConstraintUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithGenericParameterStructConstraintUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithInternalNestedAbstractClassUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithInternalNestedAbstractClass));
        }

        [TestMethod]
        public void TestStaticClassWithPrivateNestedAbstractClassUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithPrivateNestedAbstractClass));
        }

        [TestMethod]
        public void TestStaticClassWithProtectedNestedAbstractClassUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithProtectedNestedAbstractClass));
        }

        [TestMethod]
        public void TestStaticClassWithProtectedInternalNestedAbstractClassUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithProtectedInternalNestedAbstractClass));
        }

        [TestMethod]
        public void TestStaticClassWithPublicNestedAbstractClassUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithPublicNestedAbstractClass));
        }
    }
}
