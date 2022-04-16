using System;

class Student
{
    //insctance variables
    public String name;
    public String address;
    public int age;

    //default constructor
    public Student()
    {
        name = "";
        age = 0;
        address = "";
    }

    //non-default constructor
    public Student(String name, int age, String address)
    {
        this.name = name;
        this.age = age;
        this.address = address;
    }

    
}