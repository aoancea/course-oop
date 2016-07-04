# course-oop
Simple course that helps me walk through important aspects of OOP

## Introduction and purpose
This course tries to introduce the basics of OOP by following a simple online shop example. It’s been designed so that everyone can understand it. After each chapter there is an assignment to strengthen your skills related to things you’ve learnt.

The purpose of this course is not to re-invent the wheel but to help me and maybe you, keep a very simple presentation of what OOP is all about. It tries to present things in an agnostic way in regards to programming languages so that it can be applies no matter of the qualification of the listener

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
    * Inheritance
    * Polymorphism

## What is Object-Oriented Programming
 * An approach to designing and building applications that are easy to understand and change
 * By focusing on objects that interact cleanly with one another
 * Somewhere around a few thousand lines of code, you need organization
 * Adding functions and constant declarations to a global namespace isn't going to scale forever
 * You also find yourself writing repetitive code, if you're not careful

## OOP – Basics
### What is a class?
 * A class can be thought of as a contract, blueprint or a template on how an object should look like
 * Each class should be designed and programmed to accomplish one, and only one, thing(The **S** from the **SOLID** principles)

![What is a class?](https://raw.githubusercontent.com/aoancea/course-oop/master/assests/001-oop-basics-cookie-template.png)

### What is an object?
 * Objects are the building blocks on Object-Oriented Programming
 * Every object is built from a class
 * An object is an instance of a class
 * Objects have two characteristics:
   * Attributes
      * The data stored within an object represents the state of the object. In OO programming terminology, this data is called ***attributes*** or ***state***
   * Actions
      * The ***action*** of an object represents what exactly that object can do. These actions are also called ***methods*** or ***behaviours***

## OOP – Identifying classes from requirements
 * Every project starts with some words or a user story, in short, with a description
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
 * Ignoring extraneous details - we do not care for irelevant information
 * Focusing on what is important for a purpose

#### Introducing abstraction for the Customer class
 * Previously we said that for the customer we are going to store only the desired information
 * Attributes:
    * Name – stores the name of the customer
    * Email address – stores the email address of the customer
    * Shipping address – stores the shipping address of the customer
    * Data of birth – stores the date of birth of the customer
 * Actions:
    * Get age – gets the age for the customer

 * Now that we understand how to identify classes and their attributes and actions from requirements, do that for the other two classes, ***Product*** and ***Order***
 * You can provide your own user story for each of the attributes/actions related to each of these

## Fundamental priciples of OOP
 * There are 3 great fundamental principles of OOP. Some might argue there is a 4th and that being ***Abstraction***, but I would go with the structure described in the **[Abstract](#abstract)**.
 * Just to set the record straight, I believe that there is no wrong in having them as this or with a 4th one as long as everybody understands and uses them correctly

### Encapsulation
 * You can think of ***Encapsulation*** as a way to hide the implementation but at the same time make it accessible only by calling a ***method***.
 * It can also be used for grouping attributes together so that they reside in the same class(context) like we had with the ***Customer*** class, all information related to it was placed inside a single class

#### Data hiding
 * How does this language hide an object’s internal implementation details and preserve data integrity?
 * Helps manage complexity
 * Only the class needs to understand the implementation
 * Implementation can be changed without impacting the usage(client)
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
   public Address CustomerAddress { get; set; }
   ...
}

public class Product
{
   ...
   public Address OwnerAddress { get; set; }
   ...
}
```
