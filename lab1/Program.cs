using lab1;

// initialize and show
Counter newCounter = new Counter();
Console.WriteLine(newCounter.Count);

// increase by amount and show
newCounter.countManagement(5);
Console.WriteLine(newCounter.Count);

// increase by 1 and show
newCounter.increase();
Console.WriteLine(newCounter.Count);

// decrease by amount and show
newCounter.countManagement(-3);
Console.WriteLine(newCounter.Count);

// decrease by 1 and show
newCounter.decrease();
Console.WriteLine(newCounter.Count);

// trying to set to high value
newCounter.countManagement(100); // 99 is max limit
Console.WriteLine(newCounter.Count);

// trying to set to low value
newCounter.countManagement(-200); // -99 is min limit
Console.WriteLine(newCounter.Count);
