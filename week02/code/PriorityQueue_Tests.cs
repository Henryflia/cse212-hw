using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Create a queae with the following people and priorities turn: mark (2), Jhon (4), Tim (5), Sue (3)
    // and dequeau the person with the highest prority
    // Expected Result: Tim
    // Defect(s) Found:  The last number in the list was not being considered when searching for high-priority numbers.
    public void TestPriorityQueue_1()
    {

        var mark = new PriorityItem("Mark", 2);
        var jhon = new PriorityItem("Jhon", 4);
        var tim = new PriorityItem("Tim", 1);
        var sue = new PriorityItem("Sue", 5);



        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue(mark.Value, mark.Priority);
        priorityQueue.Enqueue(jhon.Value, jhon.Priority);
        priorityQueue.Enqueue(tim.Value, tim.Priority);
        priorityQueue.Enqueue(sue.Value, sue.Priority);

        var item = priorityQueue.Dequeue();

        Assert.AreEqual("Sue", item);

    }

    [TestMethod]
    // Scenario: Create a queae with the following people and priorities turn: mark (2), Jhon (5), Tim (5), Sue (5)
    // and Dequeue the first highest priority
    // Expected Result: Jhon
    // Defect(s) Found: When there are two items with the same priority, it does not take the one at the front; instead, it takes the last one with that priority if it matches the one at the front.
    public void TestPriorityQueue_2()
    {
        var mark = new PriorityItem("Mark", 2);
        var jhon = new PriorityItem("Jhon", 5);
        var tim = new PriorityItem("Tim", 3);
        var sue = new PriorityItem("Sue", 5);



        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue(mark.Value, mark.Priority);
        priorityQueue.Enqueue(jhon.Value, jhon.Priority);
        priorityQueue.Enqueue(tim.Value, tim.Priority);
        priorityQueue.Enqueue(sue.Value, sue.Priority);

        var item = priorityQueue.Dequeue();

        Assert.AreEqual("Jhon", item);
    }

    // Add more test cases as needed below.
}