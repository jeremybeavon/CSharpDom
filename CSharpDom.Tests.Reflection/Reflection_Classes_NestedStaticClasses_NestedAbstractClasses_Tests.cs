using CSharpDom.TestTarget.Classes.NestedStaticClasses.NestedAbstractClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedStaticClasses_NestedAbstractClasses_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestClassWithNestedStaticClassWithNestedAbstractClassWith1AttributeUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedAbstractClassWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithNestedAbstractClassWith1GenericParameterUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedAbstractClassWith1GenericParameter));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithNestedAbstractClassWith1ImplementedInterfaceUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedAbstractClassWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithNestedAbstractClassWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedAbstractClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithNestedAbstractClassWith2GenericParametersUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedAbstractClassWith2GenericParameters));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithNestedAbstractClassWith2ImplementedInterfacesUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedAbstractClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithNestedAbstractClassWithBaseClassUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedAbstractClassWithBaseClass));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterBaseClassConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterClassConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterInterfaceConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterStructConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithInternalNestedAbstractClassUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithInternalNestedAbstractClass));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithPrivateNestedAbstractClassUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithPrivateNestedAbstractClass));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithProtectedNestedAbstractClassUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithProtectedNestedAbstractClass));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithProtectedInternalNestedAbstractClassUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithProtectedInternalNestedAbstractClass));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithPublicNestedAbstractClassUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithPublicNestedAbstractClass));
        }
    }
}
