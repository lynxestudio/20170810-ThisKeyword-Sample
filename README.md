# The this Reference

Every object can access a reference to itself, called the this reference. The this reference can refer implicitly to the instance variable, properties and methods of an object.

Two uses of the this keyword are:

To resolve ambiguity between instance variables and parameters
To pass the current object as a parameter to another method
The following class demonstrates these uses.
Fig 1 The Use of the this Keyword



The first constructor receives three uint parameters which names are identical to the instance variables of the class. I did this to illustrate explicit use of the this reference.

Fig 2 This reference output



The explicit use of the this reference can increase program clarity in some contexts where this is optional.

Download the example source code
