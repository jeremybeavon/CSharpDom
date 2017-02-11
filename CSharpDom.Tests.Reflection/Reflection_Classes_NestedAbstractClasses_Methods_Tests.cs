using CSharpDom.TestTarget.Classes.NestedAbstractClasses.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedAbstractClasses_Methods_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestClassWithNestedAbstractClassWithMethodWith1AttributeUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithMethodWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithMethodWith1GenericParameterUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithMethodWith1ReturnAttributeUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithMethodWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithMethodWith2GenericParametersUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithMethodWith2ReturnAttributesIn2AttributeGroupsUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithMethodWithGenericParameterBaseClassConstraintUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithMethodWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithMethodWithGenericParameterClassConstraintUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithMethodWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithMethodWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithMethodWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithMethodWithGenericParameterInterfaceConstraintUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithMethodWithGenericParameterStructConstraintUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithInternalMethodUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithInternalMethod));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewMethodUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithNewMethod));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewStaticMethodUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithNewStaticMethod));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewVirtualMethodUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithNewVirtualMethod));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithOverrideMethodUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithOverrideMethod));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithMethodWithParametersWithAttributesUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithMethodWithParametersWithModifiersUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithPrivateMethodUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithPrivateMethod));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithProtectedMethodUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithProtectedMethod));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithProtectedInternalMethodUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithProtectedInternalMethod));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithPublicMethodUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithPublicMethod));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithSealedOverrideMethodUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithSealedOverrideMethod));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithStaticMethodUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithStaticMethod));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithVirtualMethodUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithVirtualMethod));
        }
    }
}
