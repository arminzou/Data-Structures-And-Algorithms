# How JavaScript Works

## What Is A Program?

-   Allocate memory
-   Parse and execute scripts (Read and run commands)

There's the JavaScript engine that each browser implements, for example, Chrome implements V8 engine that reads JavaScript we write and changes into machine executable instructions for the browser.

The engine consists of two parts, a memory heap and a call stack.

---

**Memory Heap** is where the memory allocation happens.

Example to allocate memory

```
const a = 1;
const b = 10;
const c = 100;
```

**Memory Leak**: It happens when you have unused memory, such as we are not using variable a, but it's still there. By having unused memory just laying around, it fills up this memory heap.

---

**Call Stack** is where the code is read and executed (It tells you where you are in the program)

**JavaScript is a single threaded language that can be non-blocking?**
(_Single threaded means that it has only one call stack_)

-   True. JavaScript is a singled threaded language that can be non-blocking. It has one call stack and it does one thing at a time, in order to not block the singled thread, it can be asynchronous with callback functions and these callback functions get run in the background through the callback queue and then event loop to bring it back into the call stack.

-   Running code on a single threaded can be quite easy since you don't have to deal with complicated scenarios that arise in multithreaded environment. For example, issues such as deadlocks.

**Stack Overflow**: An overflowing call stack that is when the call stack gets bigger and bigger until it doesn't have enough space anymore. (Non-stopping Recursive function)

**JavaScript Run-Time Environment**: A part of the browser that has Web APIs, Callback Queue, Event Loop on top of the engine and allow us to do asynchronous programming.

```
// call stack

// web api

// callback queue

// event loop

```

What is synchronous programming? And What is asynchronous programming? Example?

-   Synchronous programming simply means program executed line by line
-   Asynchronous programming simply means a second task can begin executing in parallel, without waiting for an earlier task to finish.
  *(In Asynchronous programming, program can continue to be responsive and running instead of having to wait for a long-runing task to finished.)*

Real world example:

**Synchronous**: You want a burger decided to go to McDonald's. After you order the burger at the counter, you are told to wait as your burger is prepared. In this synchronous situation, you are stuck at the counter until you are served your burger.

**Asynchronous**: You want a burger and decide to go to Five Guys. You go to the counter and order a burger. Five Guys gives you a buzzer that will notify you once your burger is ready. In this asynchronous situation, you have more freedom while you wait.
