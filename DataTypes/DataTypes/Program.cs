Task delayTask = Task.Delay(5000);
delayTask.Wait();  // Waits for the delay to finish
Console.WriteLine(delayTask);