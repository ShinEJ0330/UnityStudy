using System.Collections.Generic;
using UnityEngine;

public class StudyInheritance : MonoBehaviour
{
    //public List<Student> students = new List<Student>();
    //public List<Soldier> soldiers = new List<Soldier>();
    public List<Person> persons = new List<Person>();

    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            Person student = new Student();
            persons.Add(student);
        }

        for (int i = 0; i < 10; i++)
        {
            Person soldier = new Soldier();
            persons.Add(soldier);
        }
    }

    public void AllMove()
    {
        foreach (var person in persons)
            person.Walk();
    }
}
