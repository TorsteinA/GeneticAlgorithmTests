I've modified java code from Wikipedia one-on-one radar to create my target locking system. I chose Width Lock. 
Modified java code to c# for Circular Targeting

After feedback from last time I added enter/exit-State methods and run them when I switch state, though I've yet to use them for anything meaningful.

After I managed to get the radar and gun system to work nicely together, but still didn't have any steering behaviour, I thought that was a fantstic time to split the FSM into one for the driving and one for targeting/shooting

Wandering steering behavior has been downprioritized because I aim to exit that state as fast as possible, and its better to spend the time on states with more play time. 
