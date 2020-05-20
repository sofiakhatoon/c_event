# Asynchronous event processing
Program in c sharp demonstrates async event with ManualResetEventSlim
First you create an event and obtain its waithandle.
Second you pass the eventobject to a class that sets its flag to true asyncrnously
Third, you loop through all waitHandles to see if any of them has finshed.

Task provides following powerful features over thread.
If system has multiple tasks then it make use of the CLR thread pool internally, and so do not have the overhead associated with creating a dedicated thread using the Thread. Also reduce the context switching time among multiple threads.
Task can return a result. There is no direct mechanism to return the result from thread.
Wait on a set of tasks, without a signaling construct.
We can chain tasks together to execute one after the other.
Establish a parent/child relationship when one task is started from another task.
Child task exception can propagate to parent task.
Task support cancellation through the use of cancellation tokens.
Asynchronous implementation is easy in task, using’ async’ and ‘await’ keywords.
