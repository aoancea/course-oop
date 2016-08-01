[![Build status](https://ci.appveyor.com/api/projects/status/hdm7brg0r5agm4ax/branch/master?svg=true)](https://ci.appveyor.com/project/aoancea/course-oop/branch/master)

# course-oop
Simple course that helps me walk through important aspects of OOP

## Introduction and purpose
This course tries to introduce the basics of OOP by following a simple online shop example. It’s been designed so that everyone can understand it. After each chapter there is an assignment to strengthen your skills related to things you’ve learnt.

The purpose of this course is not to re-invent the wheel but to help me and maybe you, keep a very simple presentation of what OOP is all about. It tries to present things in an agnostic way in regards to programming languages so that it can be applied regardless of the reader's experience.

Hope you'll enjoy it!

## Abstract
  * [What is Object-Oriented Programming](#what-is-object-oriented-programming)
    * [Basics](#oop--basics)
      * [What is a class ?](#what-is-a-class)
      * [What is an object ?](#what-is-an-object)
    * [Identifying classes from requirements](#oop--identifying-classes-from-requirements)
      * [Creating the Customer class](#creating-the-customer-class)
      * [Understanding the problem](#understanding-the-problem)
      * [Abstraction](#abstraction)
      * [Introducing abstraction for the Customer class](#introducing-abstraction-for-the-customer-class)
  * [Fundamental priciples of OOP](#fundamental-priciples-of-oop)
    * [Encapsulation](#encapsulation)
    * [Inheritance](#inheritance)
    * [Polymorphism](#polymorphism)

## What is Object-Oriented Programming
 * An approach to designing and building applications that are easy to understand and change
 * By focusing on objects that interact cleanly with one another
 
## Why and when do we use OOP?
 * Somewhere around a few thousand lines of code, you need organization
 * Adding functions and constant declarations to a global namespace isn't going to scale forever
 * You also find yourself writing repetitive code, if you're not careful

## OOP – Basics
### What is a class?
 * A class can be thought of as a *contract*, *blueprint* or a *template* of how an object should look like
 * Each class should be designed and programmed to accomplish one, and only one, thing(The **S** from the **SOLID** principles)

![What is a class?](https://raw.githubusercontent.com/aoancea/course-oop/master/assests/001-oop-basics-cookie-template.png)

### What is an object?
 * Objects are the building blocks of Object-Oriented Programming
 * Every object is built from a class
 * An object is an instance of a class
 * Objects have two characteristics:
   * Attributes
      * The data stored within an object represents the state of the object. In OO programming terminology, this data is called ***attributes*** or ***state***
   * Actions
      * The ***action*** of an object represents what exactly that object can do. These actions are also called ***methods*** or ***behaviours***

## OOP – Identifying classes from requirements
 * Every project starts with some words or a user story. In short, with a description
 * Our job is to identify the objects we will use in our application from that description
 * We can start with the nouns and extract the classes from them
 * Let’s see an example:

>As a ***User*** I want to be able to visit a website and select multiple ***Products*** so that I can place an ***Order***

 * The nouns from the description of the user story are:
   * Customer – this is how we’ll be referring to the User
   * Product
   * Order
 * Now that we have identified the classes that we’ll be using, let’s see what are their ***attributes*** and ***actions***

#### Creating the Customer class

 * These are some ***attributes*** that the Customer might have:
    * First name
    * Last name
    * Email address
    * Home address
    * Work address
    * Date of birth
    * Shoe size
    * Gender
    * Dog name
 * And these are the ***actions*** a Customer might perform
    * Chop wood
    * Validate
    * Drive a bike
    * Load
    * Drive a car
    * Save
    * Drink beer
    * Drive a boat
    * Get age

>As an ***Admin*** I want the system to track the following about a ***User***:
 * Name
 * Email address
 * Shipping address
 * Date of birth

 * This means that we do not need to add all the previous attributes to the customer class since the system is not going to need them
 * This goes for the actions a ***User*** can perform as well, we won’t be needing all of them, at least not yet

>As an ***Admin*** I want the system to be able to calculate a ***User's*** age so that in the future we can offer featured prices for different ages

 * The actions a User can perform could be:
    * Get age
    * Validate
    * Load
    * Save

 * This means that we do not need to add all the previous actions on the ***Customer*** class

#### Understanding the problem
 * As we saw previously, we do not need to store all the information related to the identified objects into the application
 * Identifying only the information that we need for the objects is called ***Abstraction***

#### Abstraction
 * Simplifying reality
 * Ignoring extraneous details - we do not care for irrelevant information
 * Focusing on what is important for our goal

#### Introducing abstraction for the Customer class
 * Previously we said that for the customer we are going to store only the desired information
 * Attributes:
    * Name – stores the name of the customer
    * Email address – stores the email address of the customer
    * Shipping address – stores the shipping address of the customer
    * Data of birth – stores the date of birth of the customer
 * Actions:
    * Get age – gets the age for the customer

```c#
public class Customer
{
   public string Name { get; set; }
   public string EmailAddress { get; set; }
   public string ShipppingAddress { get; set; }
   public DateTime DateOfBirth { get; set; }
   
   public int GetAge();
}
```

 * Now that we understand how to identify classes and their attributes and actions from requirements, do that for the other two classes, ***Product*** and ***Order***
 * You can provide your own user story for each of the attributes/actions related to each of these

## Fundamental principles of OOP
 * There are 3 great fundamental principles of OOP. Some might argue there is a 4th one: ***Abstraction***, but I would go with the structure described in the **[Abstract](#abstract)**.
 * Just to set the record straight, I believe that there is no wrong in having them as this or with a 4th one as long as everybody understands and uses them correctly

### Encapsulation
 * You can think of ***Encapsulation*** as a way to hide the implementation but at the same time make it accessible only by calling a ***method***.
 * It can also be used for grouping attributes together so that they reside in the same class (context) like we had with the ***Customer*** class. All information related to it was placed inside a single class

#### Data hiding
 * How does this language hide an object’s internal implementation details and preserve data integrity?
 * Helps manage complexity
 * Only the class needs to understand the implementation
 * Implementation can be changed without impacting the usage (client)
 * Let’s take again the ***Customer*** class and look at one of its methods
 * We can take for this example the ***GetAge()*** method
 * The implementation is hidden inside but is made available to us just by calling/invoking the method

#### Grouping
 * Another point in ***Encapsulation*** is grouping
 * Let's say that the business requirements have changed and it’s no longer feasible to store a single field for the ShippingAddress of the ***Customer***, rather we need several fields:
    * Street name
    * Street number
    * Apartment number
 * How can we accomplish this?
 * One way to do it would be to delete the ShippingAddress attribute and instead of it add these 3 new attributes
 * The ***Customer*** class will gain these 3 new attributes:

```c#
public class Customer
{
   ...
   public string CustomerStreetName { get; set; }
   public string CustomerStreetNumber { get; set; }
   public string CustomerApartmentNumber { get; set; }
   ...
}
```

 * We can now say that the information related to the ***Customer*** class is being handled correctly
 * By the time the application goes in production and everyone is happy, a new change request comes in that says that we need to be able to store these 3 new attributes for the ***Product*** as well
 * This is because the people using the application want to know the product's owner address so that they can filter through this information and get the closest product relative to their location
 * What do we do?
 * Well, we could just add these 3 attributes to the ***Product*** class which will look something like this:

```c#
public class Product
{
   ...
   public string OwnerStreetName { get; set; }
   public string OwnerStreetNumber { get; set; }
   public string OwnerApartmentNumber { get; set; }
   ...
}
```

 * Are you seeing the pattern?
 * Exactly! Now we have duplicated code which handles the same simple thing
 * And that is holding ***Address*** information
 * Any ideas?
 * Well, we could add a new class named ***Address*** since this is the information we want to hold in it, related to address
 * Now that we have a newly build class ***Address*** that stores information related to an address, we can drop the 3 attributes from both ***Customer*** and ***Product*** classes and add the ***Address*** attribute to them
 * By doing this we have grouped the information related strictly to the address context in just one class and we can reuse it wherever we feel it’s useful

```c#
public class Address
{
   public string StreetName { get; set; }
   public string StreetNumber { get; set; }
   public string ApartmentNumber { get; set; }
}

public class Customer
{
   ...
   public Address ShippingAddress { get; set; }
   ...
}

public class Product
{
   ...
   public Address OwnerAddress { get; set; }
   ...
}
```
 * As we have defined what encapsulation is and we also walked over some main scenarios where we can use it and for what it is beneficial, let's see some implementation for the actions of each class
 * Basic examples usually tend to write a message in console that describes the intended task
 * The next examples are going to return that message in order for it to be validated in a unit test

### Inheritance
 * The ability of a new class to be created from an existing class by extending it is called ***Inheritance***
 * We can also have interface based inheritance and we will discuss about this later in the course
 * Inheritance can be used for code re-use by providing the same code base for objects that have something in common and thus create a relationship between them
 * One of the most important relationships among objects is specialization, which can be described as the ***“is-a”*** relationship
 * This means that if we have two classes, Class A and Class B, and class B derives from class A, we can say that B ***“is-a”*** A

#### Understanding the "is-a" relationship
 * The business is changing again and it wants to support multiple kinds of products
 * The first products they want to support are:
    * Apples
    * Oranges
    * Mineral water
    * Sparkling water
 * We can identify two classes from these 4 products:
    * **Fruit** – apples and oranges are fruits with one of the differences being that the thickness of the crust between these two is different
    * **Water** – mineral and sparkling water is just water with the difference that the level of carbon-dioxide present in its composition is different
 * This means that we can treat both ***Apples*** and ***Oranges*** as ***Fruit*** which will end up becoming the ***Fruit*** class and as these are products, the ***Fruit*** class is going to inherit the ***Product*** class
 * This goes exactly the same for ***Mineral*** and ***Sparkling Water*** in defining the ***Water*** class that inherits from the ***Product*** class

```c#
public abstract class Product
{
   ...
}

public abstract class Fruit : Product
{
   ...
}

public abstract class Water : Product
{
   ...
}
```
 * As we saw from the code, the ***Product***, ***Fruit*** and ***Water*** classes were marked as abstract
 * This is preventing any direct instantiation of the ***Product***, ***Fruit*** and ***Water*** classes
 * This is also a way to signal at design time that the system will never ever have the need of instantiating these kinds of object because they do not possess enough information to for a working object
 * The business can't use this simple abstract classes but it needs a set of concrete specialized classes for each of their products which we already discussed previously
 * Marking these classes as abstract do not prevent us of using any of the specialized(subclass or derived class) classes that we defined, ***Apple***, ***Orange***, ***SparklingWater*** and ***MineralWater***, in instantiating an object from them and refer to it as it were a ***Product***

```c#
public class Apple : Fruit
{
   ...
}

public class Orange : Fruit
{
   ...
}

public class SparklingWater : Water
{
   ...
}

public class MineralWater : Water
{
   ...
}
```

 * This is what inheritance is all about, being able to refer to a subclass as it were a base class
 * The business is very pleased that we managed to implement the requirements for them but the time passes so fast and they realize that the customers can place an order but the products they’ve selected do not appear anywhere
 * If we have a look at our ***Order*** class we discover that there is no knowledge of any product the customer might have selected

```c#
public class Order
{

}
```
 * So until now our system was more like presenting stuff but not allowing the customer to buy anything, and this is really bad for business!
 * What can we do?

#### Using inheritance correctly!
 * Well, we could just add a collection of some sort on the Order class and we`ll be done with it

```c#
public class Order
{
   public List<Orange> OrangeCollection { get; set; }
   public List<Apple> AppleCollection { get; set; }
   public List<MineralWater> MineralWaterCollection { get; set; }
   public List<SparklingWater> SparklingWaterCollection { get; set; }
}
```
 * Not so fast!
 * Let's think... We just added a few classes that the business required us to add, so we could just add a collection for each
 * That might work, but what happens if tomorrow they want to add like ten more types of products? We can’t just continue adding on the same pattern on the ***Order*** class
 * So one way of doing it would be to add a collection of ***Product***'s since every actual product from the system will be a ***Product***

```c#
public class Order
{
   public List<Product> Products { get; set; }
}
```
#### Understanding the "has-a" relationship
 * This means that now the Order class will contain the following attributes:
    * Customer
    * OrderDate
    * Products

```c#
public class Order
{
   public Customer Customer { get; set; }
   public DateTime OrderDate { get; set; }
   public List<Product> Products { get; set; }
}
```

 * We can see that the ***Order*** class now contains the ***Customer*** and ***Product*** classes
 * This is called ***composition*** or the ***"has-a"*** relationship
 * The ***"has-a"*** relationship simply means that a class contains another class or in terms of objects, an object is composed of one or multiple objects which is very similar to our day to day lives
 * Let's take water for example:
 * Its chemical formula is H2O, which means that the water molecule is formed out of two hydrogen atoms and one oxygen atom
 * We can conclude that water is composed out of hydrogen and oxygen but water is not hydrogen nor oxygen
 * Water is water
 * The list of examples can continue forever!

#### An implementation detail: calling order of constructors
 * Consider the previous inheritance code sequences
 * They all have a compiler-provided constructor that takes no parameters, right?
 * They might have user-defined constructors instead
 * We know how constructors are called outside of inheritance, but how are they called for a derived class?
 * Consider the next code sequence. What do you think gets printed for each ***new*** line?

```c#
public class Fruit
{
   public Fruit()
   {
      Console.WriteLine("Fruit()");
   }
}

public class Apple : Fruit
{
   private int info;
   public Apple()
   {
      Console.WriteLine("Apple()");
   }
   public Apple(int info)
   {
      this.info = info;
      Console.WriteLine("Apple(int)");
   }
}

public class RedApple : Apple
{
   public RedApple()
   {
      Console.WriteLine("RedApple()");
   }
}

class Program
{
   static void Main(string[] args)
   {
      Fruit fruit = new Fruit();
      Apple apple = new Apple();
      Apple appleWithInt = new Apple(5);
      RedApple redApple = new RedApple();
   }
}
```

 * The first ***new*** line instantiates a Fruit object, so it will just call its constructor, printing ***Fruit()***
 * The second one instantiates an Apple. In order to construct an apple, we must first have a Fruit (its base class) constructed, so this will print ***Fruit()*** and ***Apple()***
 * The same applies for the third line, even if we call a constructor with a parameter. The parameter-less constructor of the base class will always get called
 * The last line demonstrates this process with a hierarchy of 3 classes. First ***Fruit()*** is called, then ***Apple()*** and finally ***RedApple()***
 * In general, parameter-less constructors are automatically called in a ***top-down fashion***: first the base class constructor, then the derived class(es) constructor(s) 
 * This is generally true in all languages that support OOP
 * Languages such as C++ also have a strong focus on ***destructors***. These are called in a ***bottom-up fashion***: first the derived class destructor, then the base class(es) destructor(s)
 * But in C#, most of the time we only have to worry about constructors
 * This does not mean that C# doesn't have destructors: it does, and the syntax for them is the same as in C++
 
#### Choosing between "is-a and "has-a" relationship
 * As we have defined and used both ***"is-a"*** and ***"has-a"*** relationship, we also need to understand when to use each of them
 * Some would say that the ***"is-a"*** relationship is better than the ***"has-a"*** relationship and others might say the opposite
 * My personal opinion is that neither is more important than the other, you just need to make sense of the situation you're in and decide which one is the best option to suite the need
 * As we saw in the water example, there is pretty much impossible to use the ***"is-a"*** relationship
 * Happy hunting!

#### Interface based inheritance
 * The first question we need to ask is, what exactly is an interface?
 * Well, simply put, an interface is a class without implementation and that’s all that it is
 * In an interface all members are considered abstract thus an object cannot be instantiated from an interface like an object cannot be instantiated from an abstract class either
 * Different from class based inheritance, a class can inherit multiple interfaces and the term for this is ***implements***
 * This is because, as stated above, all members of an interface are abstract by default thus require an actual implementation
 * There are two ways of implementing an interface:
    * Implicitly
    * Explicitly

#### Implicit vs Explicit interface implementation
 * As the name also implies, in the implicit implementation you do not need to specify the level from where the member declared in the interface is called
 * Its implicitly at class level and can be accessed by any object created from the class implementing the interface
 * On the other hand, in the explicit implementation you do specify the level from where the member declared in the interface is called and this is at the interface level
 * It is no longer visible to any object created from the class implementing the interface but only if casted to the interface type
 * It is useful when you want some encapsulation or you don’t want certain members to be accessible to everyone

#### Interface based inheritance
 * Now that we know what an interface is and how to use it we should put it to work
 * What if we would add an interface for the ***Product*** class then make it implement it and after replace all references of the ***Product*** class with the interface
 * What would this give us?
 * Well for starters, our system will become more elastic/flexible and we would be able to provide multiple implementation for the ***Product*** class but not changing a single thing on the communication between components level since our system knows how to work with an interface and the implementation is based on that interface
 * We will name the interface ***IProduct*** to follow the interface naming conventions


### Polymorphism
 * Polymorphism means "many shapes"
 * A single method with a given name can behave differently depending on the type of the object on which it is called
 * The question that we need to ask here is:
 * How does this feature let you treat related objects in a similar way?

#### Going further
 * We talked in the previous chapter about the business requiring an order to be populated with the selected products
 * We implemented that using a collection of ***IProduct*** which we decided was the way to go
 * Holding these products in the ***Order*** object and doing nothing with them isn’t helping anyone
 * This means that when the order is placed, the products should also be placed along with it
 * By placing an order we understand saving the information related to it somewhere

#### Implementing the actual order placing workflow
 * Before we can save anything we also must validate the information provided by any customer to be sure that is correct
 * This is because we don't want our system to crash or to let the customer live under the impression that everything went good when in fact it didn't because he was too late on placing the order and the product stocked emptied out
 * If we look over to the ***IProduct*** interface we can see that it has defined the ***Validate();*** method

```c#
public interface IProduct
{
   string[] Validate();
}
```

 * This means that any object that is inheriting from ***IProduct*** is going to have some implementation for this method
 * Having this in place we can say that the validation for the selected products is very easy
 * The list of products contains all types of known products like water and fruits and each of which has its own implementation of the ***Validation();*** method
 * This is achieved by using the special keyword ***override*** which means re-write or re-implement

```c#
public interface IProduct
{
   string[] Validate();
}

public abstract class Product : IProduct // mind this useless construct of abstract class implementing an interface
{
    ...
   public abstract string[] Validate();
    ...
}

public abstract class Fruit : Product
{
    ...
   public override string[] Validate()
   {
       ...
   }
    ...
}

public class Apple : Fruit
{
    ...
   public override string[] Validate()
   {
       base.Validate(); // if you want to also call the validation from the base class[optional]
       ...
   }
    ...
}

```

#### Benefits
 * Well for starters we can treat any type of product that the system supports so far or any type of product that the system will need to support in the future as if they were the same
 * This means:
    * Less code
    * Less changes when new types of products will need to be supported
 * The following is an example of how the ***Order*** class can look like

```c#
public class Order
{
    ...
   
   public IProduct[] Products { get; set; }
   
   public void PlaceOrder()
   {
       List<string> errors = new List<string>();
       for(int i = 0; i < Products.Length; ++i) // we could use foreach as well
       {
           errors.Add(Products[i].Validate());
       }
       
       if(!errors.Any())
       {
           // place order as we do not have errors
       }
       else
       {
           // do something with the errors
       }
   }
    ...
}

```
